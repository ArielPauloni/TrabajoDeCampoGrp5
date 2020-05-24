﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    internal class AccesoSQL
    {
        private SqlConnection myConnection = new SqlConnection();
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;   

        private void Abrir()
        {
            myConnection.ConnectionString = ConnectionString;
            myConnection.Open();
        }

        private void Cerrar()
        {
            if (myConnection != null && myConnection.State == ConnectionState.Open)
            myConnection.Close();
        }

        public int Escribir(string NombreSP, List<SqlParameter> Parametros)
        {
            int ret = 0;
            Abrir();
            using (SqlCommand myCommand = new SqlCommand())
            {
                myCommand.Connection = myConnection;
                myCommand.CommandText = NombreSP;
                myCommand.CommandType = CommandType.StoredProcedure;

                if (Parametros != null && Parametros.Count > 0)
                    myCommand.Parameters.AddRange(Parametros.ToArray());
                try
                {
                    ret = myCommand.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    ret = -1;
                }
            }
            Cerrar();
            return ret;
        }

        public DataTable Leer(string NombreSP, List<SqlParameter> Parametros)
        {
            DataTable TablaRet = new DataTable();
            Abrir();
            using (SqlDataAdapter myAdaptador = new SqlDataAdapter())
            {
                myAdaptador.SelectCommand = new SqlCommand();
                myAdaptador.SelectCommand.CommandText = NombreSP;
                myAdaptador.SelectCommand.Connection = myConnection;
                myAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (Parametros != null && Parametros.Count > 0)
                    myAdaptador.SelectCommand.Parameters.AddRange(Parametros.ToArray());

                try
                {
                    myAdaptador.Fill(TablaRet);
                }
                catch (Exception)
                {
                    TablaRet = null;
                }
            }
            Cerrar();
            return TablaRet;
        }

        public SqlParameter CrearParametroStr(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.String;
            parametro.Value = valor;
            return parametro;
        }

        public SqlParameter CrearParametroInt(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Int16;
            parametro.Value = valor;
            return parametro;
        }

        public SqlParameter CrearParametroInt64(string nombre, Int64 valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Int64;
            parametro.Value = valor;
            return parametro;
        }

        public SqlParameter CrearParametroBit(string nombre, Boolean valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Boolean;
            parametro.Value = valor;
            return parametro;
        }

        public SqlParameter CrearParametroDate(string nombre, DateTime? valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.DateTime;
            if (valor != null)
            {
                parametro.Value = valor;
            }
            else
            {
                parametro.Value = DBNull.Value;
            }
            return parametro;
        }
    }
}
