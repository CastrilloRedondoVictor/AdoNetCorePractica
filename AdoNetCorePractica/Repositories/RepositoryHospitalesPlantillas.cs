﻿using System;
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
            string sql = "SP_PLANTILLA_DOCTORES_HOSPITAL";

            this.cmd.Parameters.AddWithValue("@nombreHospital", nombreHospital);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            List<Plantilla> plantilla = new List<Plantilla>();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                plantilla.Add(new Plantilla(this.reader["APELLIDO"].ToString(), this.reader["FUNCION"].ToString(), int.Parse(this.reader["SALARIO"].ToString()))); 
            }

            await this.reader.CloseAsync();
            this.cmd.Parameters.Clear();
            await this.conn.CloseAsync();

            return plantilla;
        }

        public async Task<List<string>> GetDatos(string nombreHospital)
        {
            string sql = "SP_GET_PRACTICA";

            this.cmd.Parameters.AddWithValue("@nombreHospital", nombreHospital);
            this.cmd.CommandType = System.Data.CommandType.StoredProcedure;
            this.cmd.CommandText = sql;

            await this.conn.OpenAsync();

            List<string> datos = new List<string>();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                datos.Add(this.reader["TOTAL_SALARIO"].ToString());
                datos.Add(this.reader["MEDIA_SALARIO"].ToString());
                datos.Add(this.reader["EMPLEADOS"].ToString());
            }

            await this.reader.CloseAsync();
            this.cmd.Parameters.Clear();
            await this.conn.CloseAsync();

            return datos;
        }

    }
}
