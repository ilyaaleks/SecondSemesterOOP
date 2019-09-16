using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly UnitOfWork _unitRepository;

        public MainWindow()
        {
            InitializeComponent();
            _unitRepository = new UnitOfWork();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _unitRepository.SqlServerRepository.Create(studentGrid);
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _unitRepository.SqlServerRepository.Update();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            _unitRepository.SqlServerRepository.Delete(studentGrid);
        }

        private void Button_Click_Upload(object sender, RoutedEventArgs e)
        {
            var op = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png"
            };
            if (op.ShowDialog() != true) return;
            var currentRowIndex = studentGrid.Items.IndexOf(studentGrid.CurrentItem);
            var image = new Image();
            var bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(op.FileName, UriKind.Absolute);
            bi.EndInit();
            image.Source = bi;
            if (_unitRepository.SqlServerRepository.Table.Rows.Count == currentRowIndex)
            {
                var dataRow = _unitRepository.SqlServerRepository.Table.NewRow();
                dataRow["photo"] = BufferFromImage(bi);
                dataRow["name"] = "";
                _unitRepository.SqlServerRepository.Table.Rows.Add(dataRow);
            }
            else
            {
                _unitRepository.SqlServerRepository.Table.Rows[currentRowIndex]["photo"] = BufferFromImage(bi);
            }
        }

        private static byte[] BufferFromImage(BitmapSource imageSource)
        {
            byte[] data;
            var encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageSource));
            using (var ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }
    }
}
