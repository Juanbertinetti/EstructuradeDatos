using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuradeDatos
{
     class Cola
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar (Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar ()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            Nodo Aux = Primero;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrrer (DataGridView grilla)
        {
            Nodo Aux = Primero;
            grilla.Rows.Clear();
            while (Aux != null)
            {
                grilla.Rows.Add(Aux.codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer (ListBox Lista)
        {
            Nodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.codigo + "" + Aux.Nombre + "" + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer (ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
