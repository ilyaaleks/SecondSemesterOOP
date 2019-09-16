using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["STUDCONNECTION"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction = connection.BeginTransaction();
            command.Transaction = transaction;
            // 

            command.CommandText = "Select * from STUDENT";
            SqlDataReader info = command.ExecuteReader();
            
           
            if (info.HasRows)
            {
                MessageBox.Show(info.GetName(0)+info.GetValue(1));
                ViewInfo.Items.Clear();
                ViewInfo.Items.Refresh();
               
            }
            transaction.Commit();
        }
    }
}
