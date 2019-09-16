using System;
using System.Data;
using System.Windows.Controls;

namespace Lab9
{
    public interface IRepository : IDisposable
    {
        DataTable Table { get; }

        void Create(DataGrid grid);
        void Update();
        void Delete(DataGrid grid);
    }
}