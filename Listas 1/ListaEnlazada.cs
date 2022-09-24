using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_1
{
    public class ListaEnlazada
    {
        public Nodo Inicio;


        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente==null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }
        public void AgregarAlFinal(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;

            }


        }

        public void AgregarAlPrincipio (Nodo unNodo)
        {
            if (Inicio==null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
            }

        }
    }
}
