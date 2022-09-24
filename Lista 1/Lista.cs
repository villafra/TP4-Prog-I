using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    public class Lista
    {

        public Paciente Inicio { get; set; }
        public Paciente Fin { get; set; }

        public void RegistrarPaciente(string codigoNuevo, string apellidoNuevo, string nombreNuevo, string direccionNueva, string telefonoNuevo)
        {
            Paciente pacienteNuevo = new Paciente();
            pacienteNuevo.Codigo = codigoNuevo;
            pacienteNuevo.Apellido = apellidoNuevo;
            pacienteNuevo.Nombre = nombreNuevo;
            pacienteNuevo.Direccion = direccionNueva;
            pacienteNuevo.Telefono = telefonoNuevo;

            //Si el inicio es vacio, se entiende que el fin también
            if (Inicio == null)
            {
                //la lista está vacía entonces el nuevo nodo es el primero
                this.Inicio = pacienteNuevo;
                this.Fin = pacienteNuevo;
            }
            else
            {
                //agregar un paciente al final de la lista
                this.Fin.Siguiente = pacienteNuevo;
                //como es doblemente enlazada indico cual es el anterior.
                pacienteNuevo.Anterior = this.Fin;
                //Ahora el nuevo fin es el que acabo de agregar
                this.Fin = pacienteNuevo;
            }
        }

        public void EliminarPaciente(string pCodigo)
        {

            if (Inicio == null)
            {
                //lista sin elementos (no tengo que hacer nada)
            }
            else
            {
                if (Inicio == Fin)
                {
                    //hay un único nodo
                    if (Inicio.Codigo == pCodigo)
                    {
                        Inicio = null;
                        Fin = null;
                    }
                }
                else
                {
                    //Se asume que el código existe si o si
                    Paciente pacienteAEliminar = BuscarPorCodigo(pCodigo);

                    //Si no estoy eliminado el primero
                    if (pacienteAEliminar.Anterior != null)
                        pacienteAEliminar.Anterior.Siguiente = pacienteAEliminar.Siguiente;
                    else
                        Inicio = pacienteAEliminar.Siguiente;

                    //Si no estoy eliminando el último
                    if (pacienteAEliminar.Siguiente != null)
                        pacienteAEliminar.Siguiente.Anterior = pacienteAEliminar.Anterior;
                    else
                        Fin = pacienteAEliminar.Anterior;
                }
            }
        }

        public void EliminarPaciente(Paciente pPaciente)
        {
            if (Inicio == null)
            {
                //lista sin elementos (no tengo que hacer nada)
            }
            else
            {
                if (Inicio == Fin)
                {
                    //hay un único nodo
                    if (Inicio.Codigo == pPaciente.Codigo)
                    {
                        Inicio = null;
                        Fin = null;
                    }
                }
                else
                {
                    //Se asume que el paciente pasado pertenece a la lista
                    //Si no estoy eliminado el primero
                    if (pPaciente.Anterior != null)
                        pPaciente.Anterior.Siguiente = pPaciente.Siguiente;
                    else
                        Inicio = pPaciente.Siguiente;

                    //Si no estoy eliminando el último
                    if (pPaciente.Siguiente != null)
                        pPaciente.Siguiente.Anterior = pPaciente.Anterior;
                    else
                        Fin = pPaciente.Anterior;
                }
            }

        }

        private Paciente BuscarPorCodigo(string pCodigo)
        {
            Paciente pacienteEncontrado = null;

            Paciente pacienteBusqueda = Inicio;
            //Mientras no lo encontré y tengo mas para seguir buscando
            while (pacienteEncontrado == null && pacienteBusqueda != null)
            {
                //Si lo encontré 
                if (pacienteBusqueda.Codigo == pCodigo)
                {
                    pacienteEncontrado = pacienteBusqueda;
                }
                else
                {
                    //Si no lo encontré avanzo al siguiente
                    pacienteBusqueda = pacienteBusqueda.Siguiente;
                }
            }

            //Si llegué al final y no lo encontré, retorno null
            return pacienteEncontrado;
        }


    }

}
