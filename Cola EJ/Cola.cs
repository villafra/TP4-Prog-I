using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_EJ
{
    public class Cola
    {
        Nodo _Inicio;
        public void Encolar(Nodo UnNodo)
        {
            if (_Inicio == null)
            {
                _Inicio = UnNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(_Inicio);
                aux.Siguiente = UnNodo;
            }

        }

        public bool ColaVacia()
        {
            return (_Inicio == null);
        }
        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void Desencolar()
        {
            _Inicio = _Inicio.Siguiente;
        }

        public Nodo Inicio
        {
            get
            {
                return _Inicio;
            }
        }
    }
}
