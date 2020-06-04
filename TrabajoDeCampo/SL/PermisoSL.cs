using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using SL.PatronComposite;

namespace SL
{
    public class PermisoSL
    {
        private PermisoMapper PermisoMapper = new PermisoMapper();

        public List<PermisoBE> ListarPermisos()
        {
            PermisoMapper m = new PermisoMapper();
            return m.ListarPermisos();
        }

        public int InsertarPermiso(PermisoBE permiso)
        {
            PermisoMapper m = new PermisoMapper();
            return m.InsertarPermiso(permiso);
        }

        public List<PatronComposite.ComponentPermiso> ListarPermisosArbol()
        {
            List<PatronComposite.ComponentPermiso> gruposDePermisos = new List<PatronComposite.ComponentPermiso>();
            PermisoBE permisoRoot = new PermisoBE();
            permisoRoot.CodPermiso = 0;
            List<PermisoBE> PermisosGrupo = PermisoMapper.ListarPermisosPorPadre(permisoRoot);

            foreach (PermisoBE permiso in PermisosGrupo)
            {
                PatronComposite.CompositePermiso FamiliaPermiso = new PatronComposite.CompositePermiso(permiso);
                gruposDePermisos.Add(FamiliaPermiso);
                List<PermisoBE> PermisosHijos = PermisoMapper.ListarPermisosPorPadre(permiso);
                SubNodoAgregar(FamiliaPermiso, PermisosHijos);
            }
            return gruposDePermisos;
        }

        private void SubNodoAgregar(PatronComposite.ComponentPermiso nodo, List<PermisoBE> hijos)
        {
            if (hijos.Count > 0)
            {
                foreach (PermisoBE hijo in hijos)
                {
                    List<PermisoBE> newHijos = new List<PermisoBE>();
                    newHijos = PermisoMapper.ListarPermisosPorPadre(hijo);

                    if (newHijos.Count() == 0)
                    {
                        nodo.Agregar(new PatronComposite.HojaPermiso(hijo));
                    }
                    else
                    {
                        PatronComposite.CompositePermiso compositePermiso = new PatronComposite.CompositePermiso(hijo);
                        nodo.Agregar(compositePermiso);
                        SubNodoAgregar(compositePermiso, newHijos);
                    }
                }
            }
        }

        public List<ComponentPermiso> ListarPermisosPorTipoUsuario(TipoUsuarioBE tipoUsuario)
        {
            List<PatronComposite.ComponentPermiso> gruposDePermisos = new List<PatronComposite.ComponentPermiso>();
            List<PermisoBE> PermisosGrupo = PermisoMapper.ListarPermisosPorTipoUsuario(tipoUsuario);

            foreach (PermisoBE permiso in PermisosGrupo)
            {
                if (permiso.CodPermisoPadre == null)
                {
                    PatronComposite.CompositePermiso FamiliaPermiso = new PatronComposite.CompositePermiso(permiso);
                    gruposDePermisos.Add(FamiliaPermiso);
                    List<PermisoBE> PermisosHijos = PermisoMapper.ListarPermisosPorPadre(permiso);
                    SubNodoAgregar(FamiliaPermiso, PermisosHijos);
                }
            }
            return gruposDePermisos;
        }

        public int RelacionarPermisos(PermisoBE permisoPadre, PermisoBE permisoHijo)
        {
            PermisoMapper m = new PermisoMapper();
            return m.RelacionarPermisos(permisoPadre, permisoHijo);
        }

        public int QuitarRelacionPermisos(PermisoBE permisoPadre, PermisoBE permisoHijo)
        {
            PermisoMapper m = new PermisoMapper();
            return m.QuitarRelacionPermisos(permisoPadre, permisoHijo);
        }

        public int InsertarPermisoPorTipoUsuario(TipoUsuarioBE tipoUsuario, PermisoBE permiso)
        {
            PermisoMapper m = new PermisoMapper();
            return m.InsertarPermisoPorTipoUsuario(tipoUsuario, permiso);
        }

        public int EliminarPermisoPorTipoUsuario(TipoUsuarioBE tipoUsuario, PermisoBE permiso)
        {
            PermisoMapper m = new PermisoMapper();
            return m.EliminarPermisoPorTipoUsuario(tipoUsuario, permiso);
        }
    }
}
