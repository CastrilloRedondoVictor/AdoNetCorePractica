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
    public class RepositoryHospitalesPlantillas
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public RepositoryHospitalesPlantillas() {
            string connectionString = ConfigurationHelper.GetSqlTemplate();

            this.conn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.conn;
        }

        public async Task<List<string>> GetHospitalesAsync()
        {
            string sql = "SP_ALL_NOMBRE_HOSPITALES";

            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            List<string> nombres = new List<string>();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync()) {
                nombres.Add(this.reader["NOMBRE"].ToString());
            }

            await this.reader.CloseAsync();
            await this.conn.CloseAsync();

            return nombres;
        }

        public async Task<List<Plantilla>> GetPlantillaHospitalAsync(string nombreHospital)
        {
            string sql = "SP_PLANTILLA_HOSPITAL";

            this.cmd.Parameters.AddWithValue("@nombreHospital", nombreHospital);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            List<Plantilla> plantilla = new List<Plantilla>();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                plantilla.Add(new Plantilla(int.Parse(this.reader["HOSPITAL_COD"].ToString()), int.Parse(this.reader["SALA_COD"].ToString()), int.Parse(this.reader["EMPLEADO_NO"].ToString()), this.reader["APELLIDO"].ToString(), ));
            }

            await this.reader.CloseAsync();
            this.cmd.Parameters.Clear();
            await this.conn.CloseAsync();

            return plantilla;
        }

    }
}
