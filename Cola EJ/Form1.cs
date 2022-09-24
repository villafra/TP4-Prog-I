using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola_EJ
{
    public partial class Form1 : Form
    {
        Cola UnaCola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre", "Colas, Ejemplo", MessageBoxButtons.OK);
            }
            else
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNombreNodo.Text;
                txtNombreNodo.Clear();
                UnaCola.Encolar(unNuevoNodo);
                MostrarCola();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (UnaCola.ColaVacia())
            {
                MessageBox.Show("La cola está vacía", "Colas,Ejemplos",MessageBoxButtons.OK);
            }
            else
            {
                UnaCola.Desencolar();
                MostrarCola();
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarColaEnPantalla(UnaCola.Inicio);

        }

        private void MostrarColaEnPantalla (Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstCola.Items.Add(unNodo.Nombre);

                if (unNodo.Siguiente != null)
                {
                    MostrarColaEnPantalla(unNodo.Siguiente);
                }
                
            }

            
        }
    }
}
