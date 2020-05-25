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
    public class UsuarioMapper
    {
        public int Insertar(BE.UsuarioBE usuario)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("Nombre", usuario.Nombre));
            parametros.Add(AccesoSQL.CrearParametroStr("Mail", usuario.Mail));
            parametros.Add(AccesoSQL.CrearParametroStr("Contraseña", SimpleEncrypt(usuario.Contraseña)));
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Tipo", usuario.TipoUsuario.Cod_Tipo));
            return AccesoSQL.Escribir("pr_Insertar_Usuario", parametros);
        }

        public int Editar(BE.UsuarioBE usuario)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Usuario", usuario.Cod_Usuario));
            parametros.Add(AccesoSQL.CrearParametroStr("Nombre", usuario.Nombre));
            parametros.Add(AccesoSQL.CrearParametroStr("Mail", usuario.Mail));
            parametros.Add(AccesoSQL.CrearParametroStr("Contraseña", SimpleEncrypt(usuario.Contraseña)));
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Tipo", usuario.TipoUsuario.Cod_Tipo));
            return AccesoSQL.Escribir("pr_Actualizar_Usuario", parametros);
        }

        public int Eliminar(BE.UsuarioBE usuario)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Usuario", usuario.Cod_Usuario));
            return AccesoSQL.Escribir("pr_Eliminar_Usuario", parametros);
        }

        public UsuarioBE ObtenerUsuarioLogin(UsuarioBE usuarioBE)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("Mail", usuarioBE.Mail));
            parametros.Add(AccesoSQL.CrearParametroStr("Contraseña", SimpleEncrypt(usuarioBE.Contraseña)));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_UsuarioLogin", parametros);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    //TODO: Esto es repetitivo!
                    UsuarioBE usuario = new UsuarioBE();
                    TipoUsuarioBE tipoUsuario = new TipoUsuarioBE();
                    usuario.TipoUsuario = tipoUsuario;
                    usuario.Cod_Usuario = int.Parse(fila["Cod_Usuario"].ToString());
                    usuario.Nombre = fila["Nombre"].ToString();
                    usuario.Mail = fila["Mail"].ToString();
                    usuario.Contraseña = SimpleDecrypt(fila["Contraseña"].ToString());
                    usuario.TipoUsuario.Cod_Tipo = short.Parse(fila["Cod_Tipo"].ToString());
                    usuario.TipoUsuario.Descripcion_Tipo = fila["DescripcionTipo"].ToString();

                    return usuario;
                }
            }
            return null;
        }

        public UsuarioBE ObtenerUsuarioPorMail(UsuarioBE usuarioBE)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroStr("Mail", usuarioBE.Mail));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_UsuarioPorMail", parametros);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    //TODO: Esto es repetitivo!
                    UsuarioBE usuario = new UsuarioBE();
                    TipoUsuarioBE tipoUsuario = new TipoUsuarioBE();
                    usuario.TipoUsuario = tipoUsuario;
                    usuario.Cod_Usuario = int.Parse(fila["Cod_Usuario"].ToString());
                    usuario.Nombre = fila["Nombre"].ToString();
                    usuario.Mail = fila["Mail"].ToString();
                    usuario.Contraseña = SimpleDecrypt(fila["Contraseña"].ToString());
                    usuario.TipoUsuario.Cod_Tipo = short.Parse(fila["Cod_Tipo"].ToString());
                    usuario.TipoUsuario.Descripcion_Tipo = fila["DescripcionTipo"].ToString();

                    return usuario;
                }
            }
            return null;
        }

        public UsuarioBE ObtenerUsuarioPorCod(UsuarioBE usuarioBE)
        {
            AccesoSQL AccesoSQL = new AccesoSQL();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(AccesoSQL.CrearParametroInt("Cod_Usuario", usuarioBE.Cod_Usuario));
            DataTable tabla = AccesoSQL.Leer("pr_Listar_UsuarioPorCod", parametros);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    //TODO: Esto es repetitivo!
                    UsuarioBE usuario = new UsuarioBE();
                    TipoUsuarioBE tipoUsuario = new TipoUsuarioBE();
                    usuario.TipoUsuario = tipoUsuario;
                    usuario.Cod_Usuario = int.Parse(fila["Cod_Usuario"].ToString());
                    usuario.Nombre = fila["Nombre"].ToString();
                    usuario.Mail = fila["Mail"].ToString();
                    usuario.Contraseña = SimpleDecrypt(fila["Contraseña"].ToString());
                    usuario.TipoUsuario.Cod_Tipo = short.Parse(fila["Cod_Tipo"].ToString());
                    usuario.TipoUsuario.Descripcion_Tipo = fila["DescripcionTipo"].ToString();

                    return usuario;
                }
            }
            return null;
        }

        public List<BE.UsuarioBE> Listar()
        {
            List<BE.UsuarioBE> myLista = new List<BE.UsuarioBE>();
            AccesoSQL AccesoSQL = new AccesoSQL();
            DataTable tabla = AccesoSQL.Leer("pr_Listar_Usuarios", null);
            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BE.UsuarioBE usuario = new BE.UsuarioBE();
                    TipoUsuarioBE tipoUsuario = new TipoUsuarioBE();
                    usuario.TipoUsuario = tipoUsuario;
                    usuario.Cod_Usuario = int.Parse(fila["Cod_Usuario"].ToString());
                    usuario.Nombre = fila["Nombre"].ToString();
                    usuario.Mail = fila["Mail"].ToString();
                    usuario.Contraseña = SimpleDecrypt(fila["Contraseña"].ToString());
                    usuario.TipoUsuario.Cod_Tipo = short.Parse(fila["Cod_Tipo"].ToString());
                    usuario.TipoUsuario.Descripcion_Tipo = fila["DescripcionTipo"].ToString();
                    myLista.Add(usuario);
                }
            }
            return myLista;
        }

        #region Encriptado
        public static string SimpleEncrypt(string PlainText)
        {
            return PlainText + "123";
        }

        public static string SimpleDecrypt(string EncryptedText)
        {
            return EncryptedText.Substring(0,EncryptedText.Length-3);
        }
        #endregion
    }
}
