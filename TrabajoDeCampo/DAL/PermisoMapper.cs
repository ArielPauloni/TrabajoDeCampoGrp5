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
    public class PermisoMapper
    {
        public int Insertar(BE.PermisoBE permiso)
        {

            return 1;
        }

        public List<PermisoBE> ListarPermisos()
        {
            //estos NO son permisos BE, estos son componentes... porque puede ser nodo u hoja
            List<PermisoBE> listaPermisos = new List<PermisoBE>();
            AccesoSQL AccesoSQL = new AccesoSQL();
            DataTable tabla = AccesoSQL.Leer("pr_Listar_Permisos", null);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    PermisoBE permiso = new PermisoBE();
                    permiso.CodPermiso = short.Parse(fila["Cod_Permiso"].ToString());
                    permiso.DescripcionPermiso = fila["Nombre"].ToString();
                    listaPermisos.Add(permiso);
                }
            }
            return listaPermisos;
        }

        public int InsertarPermiso(PermisoBE permiso)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("Nombre", permiso.DescripcionPermiso));
            return AccesoSQL.Escribir("pr_Insertar_Permiso", parametros);
        }

        public int CargarPermisosAlUsuario(ref UsuarioBE usuario)
        {
            int retVal = 0;
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroInt("TipoUsuario", usuario.TipoUsuario.Cod_Tipo));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_PermisosPorTipoUsuario", parametros);
            if (tabla != null)
            {
                usuario.Permisos = new List<PermisoBE>();
                foreach (DataRow fila in tabla.Rows)
                {
                    PermisoBE permiso = new PermisoBE();
                    permiso.CodPermiso = int.Parse(fila["Cod_Permiso"].ToString());
                    permiso.DescripcionPermiso = fila["Nombre"].ToString();
                    usuario.Permisos.Add(permiso);
                }
                retVal = 1;
            }
            return retVal;
        }

        public static List<PermisoBE> ListarPermisosPorTipoUsuario(TipoUsuarioBE tipoUsuario)
        {
            List<PermisoBE> listaPermisos = new List<PermisoBE>();

            return listaPermisos;
        }
    }
}
