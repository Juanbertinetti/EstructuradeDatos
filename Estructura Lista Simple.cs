using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuradeDatos
{
    public partial class Estructura_Lista_Simple : Form
    {
        public Estructura_Lista_Simple()
        {
            InitializeComponent();
        }

        ListaSimple filadepersonas = new ListaSimple();
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Nodo ObjNodo = new Nodo();
            ObjNodo.codigo = Convert.ToInt32(TxtCodigo.Text);
            ObjNodo.Nombre = TxtNombre.Text;
            ObjNodo.Tramite = TxtTramite.Text;

            filadepersonas.Agregar(ObjNodo);
            filadepersonas.Recorrer(DgvLista);
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CbCodigo == null)
            {
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnEliminar.Enabled = false;
            }
        }

        private void CbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
