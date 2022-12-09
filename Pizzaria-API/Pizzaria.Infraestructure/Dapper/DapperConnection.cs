using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infraestructure.Dapper
{
    public sealed class DapperConnection : IDisposable
    {
        private readonly IConfiguration _configuration;
        public IDbConnection Connection { get; set; }
        public DapperConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            Connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            Connection.Open();
        }
        public void Dispose() => Connection?.Dispose();
    }
}
