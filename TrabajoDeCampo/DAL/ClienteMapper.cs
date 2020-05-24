using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class ClienteMapper
    {
        public ClienteBE ObtenerCliente(ClienteBE clienteBE)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Usuario", clienteBE.Cod_Usuario));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_Cliente", parametros);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    ClienteBE cliente = new ClienteBE();
                    cliente.Cod_Usuario = int.Parse(fila["Cod_Usuario"].ToString());
                    cliente.Nombre = fila["Nombre"].ToString();
                    cliente.Mail = fila["Mail"].ToString();
                    cliente.Cod_Tipo = short.Parse(fila["Cod_Tipo"].ToString());
                    cliente.TipoUsuario = fila["DescripcionTipo"].ToString();
                    cliente.Cod_Cliente = short.Parse(fila["Cod_Cliente"].ToString());
                    cliente.Cod_TipoCliente = short.Parse(fila["Cod_TipoCliente"].ToString());
                    cliente.TipoCliente = fila["Detalle_TipoCliente"].ToString();

                    return cliente;
                }
            }
            return null;
        }
    }
}
