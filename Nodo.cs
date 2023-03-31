using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EstructuradeDatos
{
    internal class Nodo
    {
        private Int32 Cod;
        private String Nom;
        private String tra;
        private Nodo sig;

        public Int32 codigo
        {
            get { return Cod; }  
            set { Cod = value; }
        }

        public String Nombre
        {
            get { return Nom; }
            set { Nom = value; }

        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }


    }
}
