using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EstructuradeDatos
{
    class ListaSimple
    {
        public Nodo Primero;

        public void Agregar (Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.codigo < Primero.codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    Nodo aux = Primero;
                    Nodo ant = Primero;
                    while (Nuevo.codigo > aux.codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }
        public void Eliminar (Int32 Codigo)
        {
            if (Primero.codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                Nodo aux = Primero;
                Nodo ant = Primero;
                while (aux.codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente; //sirve para que avance uno x uno
                }
                ant.Siguiente = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            Nodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.codigo + "--" + Aux.Nombre + "--" + Aux.Tramite);
                Aux = Aux.Siguiente;
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
    }
}
