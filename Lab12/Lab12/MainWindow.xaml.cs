using Lab12.Models;
using System.Data.Entity;
using System.Windows;

namespace Lab12
{
    public partial class MainWindow
    {
        private readonly MobileContext _db;
        public MainWindow()
        {
            InitializeComponent();

            _db = new MobileContext();
            _db.Phones.Load();
            phonesGrid.ItemsSource = _db.Phones.Local.ToBindingList();

            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems.Count > 0)
            {
                foreach (var t in phonesGrid.SelectedItems)
                {
                    if (t is Phone phone)
                    {
                        _db.Phones.Remove(phone);
                    }
                }
            }
            _db.SaveChanges();
        }
    }
}
