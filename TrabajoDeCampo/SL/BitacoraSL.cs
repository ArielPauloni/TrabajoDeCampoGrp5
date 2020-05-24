using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace SL
{
    public class BitacoraSL
    {
        public int Insertar(BitacoraBE bitacora, UsuarioBE usuario)
        {
            BitacoraMapper m = new BitacoraMapper();
            return m.Insertar(bitacora);
        }


        public List<BitacoraBE> Listar()
        {
            BitacoraMapper m = new BitacoraMapper();
            return m.Listar();
        }

        public List<BitacoraBE> ObtenerBitacoraPorUsuario(UsuarioBE usuario)
        {
            BitacoraMapper m = new BitacoraMapper();
            return m.ListarBitacoraPorUsuario(usuario);
        }
    }
}
