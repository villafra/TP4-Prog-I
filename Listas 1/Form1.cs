using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_1
{
    public partial class Form1 : Form
    {

        ListaEnlazada lista = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItem(Nodo unNodo)
        {
            if (unNodo!= null)
            {
                lstListaEnlazada.Items.Add(unNodo.Nombre);
                AgregarItem(unNodo.Siguiente);
            }
        }
        public void MostrarLista()
        {
            lstListaEnlazada.Items.Clear();

            if (lista.Inicio != null)
            {
                AgregarItem(lista.Inicio);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrincipio_Click(object sender, EventArgs e)
        {
            if (txtNodo.Text.Length > 0)
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNodo.Text;
                lista.AgregarAlPrincipio(unNuevoNodo);
                txtNodo.Clear();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nodo", "Lista Enlazada", MessageBoxButtons.OK);
            }

        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (txtNodo.Text.Length > 0)
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Nombre = txtNodo.Text;
                lista.AgregarAlFinal(unNuevoNodo);
                txtNodo.Clear();
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nodo", "Lista Enlazada", MessageBoxButtons.OK);
            }
        }
    }
}