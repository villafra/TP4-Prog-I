using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila_Ej
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Nodo unNuevoNodo = new Nodo();
            unNuevoNodo.Nombre=txtNodo.Text;
            txtNodo.Clear();
            pila.Apilar(unNuevoNodo);
            MostrarPila();

        }

        public void MostrarPila()
        {
            lstPila.Items.Clear();

            if (pila.Tope() != null)
            {
                MostrarNodoenLista(pila.Tope());
            }
        }

        public void MostrarNodoenLista (Nodo unNodo)
        {
            lstPila.Items.Add(unNodo.Nombre);

            if (unNodo.Siguiente!=null)
            {
                MostrarNodoenLista(unNodo.Siguiente);
            }

        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            pila.Desapilar();
            MostrarPila();
        }
    }
}
