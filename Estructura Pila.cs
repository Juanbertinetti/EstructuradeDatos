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
    public partial class Estructura_Pila : Form
    {
        public Estructura_Pila()
        {
            InitializeComponent();
        }
        Pila filadepersonas = new Pila();

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
            if (filadepersonas.Primero != null)
            {
                TxtCodigoDos.Text = filadepersonas.Primero.codigo.ToString();
                TxtNombreDos.Text = filadepersonas.Primero.Nombre;
                TxtTramiteDos.Text = filadepersonas.Primero.Tramite;
                filadepersonas.Eliminar();
                filadepersonas.Recorrer(DgvLista);
            }
            else
            {
                TxtCodigoDos.Text = "";
                TxtNombreDos.Text = "";
                TxtTramiteDos.Text = "";
            }

        }

        private void Estructura_Pila_Load(object sender, EventArgs e)
        {

        }

        private void LStLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

