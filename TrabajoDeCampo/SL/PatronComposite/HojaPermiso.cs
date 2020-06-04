﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace SL.PatronComposite
{
    public class HojaPermiso : ComponentPermiso
    {
        public HojaPermiso(PermisoBE permiso)
          : base(permiso)
        {
        }

        public override void Agregar(ComponentPermiso componentePermiso)
        {
            //no se puede agregar si es hoja
        }


        public override void Remover(ComponentPermiso componentePermiso)
        {
            //no se puede remover si es hoja
        }


        public override void Mostrar(TreeNodeCollection nodo)
        {
            TreeNode treeNode = new TreeNode()
            {
                Name = Permiso.CodPermiso.ToString(),
                Text = Permiso.DescripcionPermiso,
                Tag = Permiso.DescripcionPermiso
            };
            nodo.Add(treeNode);
        }
    }
}
