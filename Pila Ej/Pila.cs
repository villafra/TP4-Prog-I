using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila_Ej
{
    public class Pila
    {
        Nodo tope;

        public Nodo Tope()
        {
            return tope;
        }
        public void Apilar(Nodo unNodo)
        {
            if (tope==null)
            {
                tope = unNodo;
            }
            else
            {
                Nodo aux = tope;
                tope = unNodo;
                tope.Siguiente = aux;
            }

        }
        public void Desapilar()
        {
            if (tope!=null)
            {
                tope = tope.Siguiente;

            }

        }
    }
}
