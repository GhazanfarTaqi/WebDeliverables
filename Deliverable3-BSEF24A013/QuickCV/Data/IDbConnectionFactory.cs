using System.Data;
using Microsoft.Data.SqlClient;

namespace QuickCV.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection Create();
    }
}
