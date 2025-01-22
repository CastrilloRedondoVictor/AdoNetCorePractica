using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCorePractica.Helpers;
using AdoNetCorePractica.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCorePractica.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = ConfigurationHelper.GetSqlTemplate();

            this.conn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.conn;
        }

        public async Task<List<string>> GetDepartamentos()
        {
            string sql = "select * from DEPT";

            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            List<string> nombres = new List<string>();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                nombres.Add(this.reader["DNOMBRE"].ToString());
            }

            await this.reader.CloseAsync();
            await this.conn.CloseAsync();

            return nombres;
        }

        public async Task InsertDepartamento(int deptno, string dnombre, string loc)
        {
            string sql = "SP_INSERT_DEPARTAMENTO";

            this.cmd.Parameters.AddWithValue("@deptno", deptno);
            this.cmd.Parameters.AddWithValue("@dnombre", dnombre);
            this.cmd.Parameters.AddWithValue("@loc", loc);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            await this.cmd.ExecuteNonQueryAsync();

            await this.conn.CloseAsync();
        }
    }
}
