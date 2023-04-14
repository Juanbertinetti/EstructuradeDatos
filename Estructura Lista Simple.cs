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
            filadepersonas.Recorrer(LStLista);
            filadepersonas.Recorrer(CbCodigo);
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtTramite.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (filadepersonas.Primero != null)
            {

                filadepersonas.Eliminar(Convert.ToInt32(CbCodigo.Text));
                filadepersonas.Recorrer(CbCodigo);
                filadepersonas.Recorrer(DgvLista);
                filadepersonas.Recorrer(LStLista);
            }
          
        }

        private void CbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbCodigo.Items.Add(TxtCodigo.Text);
        }

        private void Estructura_Lista_Simple_Load(object sender, EventArgs e)
        {

        }

        private void LStLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnpasar_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
