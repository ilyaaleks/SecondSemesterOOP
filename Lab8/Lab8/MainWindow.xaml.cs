using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly string _connectionString;
        private SqlDataAdapter _adapter;
        private DataTable _studentTable;

        public MainWindow()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            const string sql = "SELECT * FROM Student";
            _studentTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
                var command = new SqlCommand(sql, connection);
                _adapter = new SqlDataAdapter(command)
                {
                    InsertCommand = new SqlCommand("sp_InsertStudent", connection)
                };
                _adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.VarBinary, byte.MaxValue, "Photo"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@dateOfBirth", SqlDbType.Date, 0, "DateOfBirth"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@group", SqlDbType.NVarChar, 50, "Group"));
                SqlParameter parameter = _adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                connection.Open();
                _adapter.Fill(_studentTable);
                studentGrid.ItemsSource = _studentTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
        }

        private void UpdateDb()
        {
            //try
            //{
                _adapter.Update(_studentTable);
                MessageBox.Show("Database updated.");
            //}
            //catch
            //{
            //    MessageBox.Show("Name cannot be null!");
            //}
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateDb();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (studentGrid.SelectedItems != null)
            {
                for (int i=0; i<studentGrid.SelectedItems.Count; i++)
                {
                    DataRowView dataRowView = studentGrid.SelectedItems[i] as DataRowView;
                    if (dataRowView != null)
                    {
                        DataRow dataRow = (DataRow) dataRowView.Row;
                        dataRow.Delete();
                    }
                }

                UpdateDb();
            }
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
            //if (_studentTable.Rows.Count == currentRowIndex)
            //{
            //    var dataRow = _studentTable.NewRow();
            //    dataRow["photo"] = BufferFromImage(bi);
            //    dataRow["name"] = "";
            //    _studentTable.Rows.Add(dataRow);
            //}
            //else
            //{
            //   _studentTable.Rows[currentRowIndex]["photo"] = BufferFromImage(bi);
                    //  }
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
