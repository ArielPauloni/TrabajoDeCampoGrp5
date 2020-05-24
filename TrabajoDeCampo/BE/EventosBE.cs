using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EventosBE
    {
        public enum Eventos
        {
            Login,
            Logout
        }

        private string descripcionEvento;
        public string DescripcionEvento
        {
            get { return descripcionEvento; }
            set { descripcionEvento = value; }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
