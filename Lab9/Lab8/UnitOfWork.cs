using System;
using Lab9.Repositories;

namespace Lab9
{
    public class UnitOfWork : IDisposable
    {
        private SqlServerRepository _sqlServerRepository;

        public SqlServerRepository SqlServerRepository => _sqlServerRepository ?? (_sqlServerRepository = new SqlServerRepository());

        public void Dispose()
        {
            _sqlServerRepository?.Dispose();
        }
    }
}
