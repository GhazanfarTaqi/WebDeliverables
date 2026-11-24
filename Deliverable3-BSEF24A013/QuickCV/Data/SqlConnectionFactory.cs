using Microsoft.Data.SqlClient;
using System.Data;

namespace QuickCV.Data
{
    public class SqlConnectionFactory:IDbConnectionFactory
    {
        private readonly string _cs;
        public SqlConnectionFactory(IConfiguration config) =>
            _cs = config.GetConnectionString("DefaultConnection")!;
        public IDbConnection Create() => new SqlConnection(_cs);
    }
}
