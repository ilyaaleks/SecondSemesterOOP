using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace Lab9.Repositories
{
    public class SqlServerRepository : IRepository
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _connection;
        private string _connectionString;

        public string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }
        public DataTable Table { get; private set; }

        public SqlServerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public SqlServerRepository(string connectionString)
        {
            _connectionString = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        }

        public void Dispose()
        {
            _connection?.Close();
        }

        public void Create(DataGrid grid)
        {
            const string sql = "SELECT * FROM Student";
            Table = new DataTable();
            _connection = null;
            try
            {
                _connection = new SqlConnection(_connectionString);
                var command = new SqlCommand(sql, _connection);
                _adapter = new SqlDataAdapter(command)
                {
                    InsertCommand = new SqlCommand("sp_InsertStudent", _connection)
                };
                _adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.VarBinary, byte.MaxValue, "Photo"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@dateOfBirth", SqlDbType.Date, 0, "DateOfBirth"));
                _adapter.InsertCommand.Parameters.Add(new SqlParameter("@group", SqlDbType.NVarChar, 50, "Group"));
                var parameter = _adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                _connection.Open();
                _adapter.Fill(Table);
                grid.ItemsSource = Table.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _connection?.Close();
            }
        }

        public void Update()
        {
            try
            {
                _adapter.Update(Table);
                MessageBox.Show("Database updated.");
            }
            catch
            {
                MessageBox.Show("Name cannot be null!");
            }
        }

        public void Delete(DataGrid grid)
        {
            foreach (var t in grid.SelectedItems)
            {
                if (!(t is DataRowView datarowView)) continue;
                var dataRow = datarowView.Row;
                dataRow.Delete();
            }
        }
    }
}
