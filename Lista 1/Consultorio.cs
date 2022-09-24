using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lista_1
{
    public partial class Consultorio : Form
    {
        Lista listaPacientes = new Lista();
        private bool mostrarOrdenAscendente = true;
        public Consultorio()
        {
            InitializeComponent();
        }

        
       
        private void Consultorio_Load(object sender, EventArgs e)
        {
            Reinicializar();
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reinicializar();
        }

        private void Reinicializar()
        {
            listBoxPacientes.ClearSelected();
            txtCodigo.Enabled = true;
            txtCodigo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodigo.Focus();
            btnActualizar.Enabled = false;
            btnEliminarPorCodigo.Enabled = false;
            btnEliminarPorReferencia.Enabled = false;
            btnNuevo.Enabled = false;
            btnRegistrar.Enabled = true;
        }
        private void MostrarLista()
        {
            if (mostrarOrdenAscendente)
                MostrarListaInicioFin();
            else
                MostrarListaFinInicio();
        }
        private void MostrarListaInicioFin()
        {
            listBoxPacientes.Items.Clear();

            Paciente pacienteAMostrar = listaPacientes.Inicio;

            while (pacienteAMostrar != null)
            {
                //Para que se pueda ver, la clase Paciente tiene que tener implementado el método ToString
                listBoxPacientes.Items.Add(pacienteAMostrar);
                pacienteAMostrar = pacienteAMostrar.Siguiente;
            }

            Reinicializar();
        }

        private void MostrarListaFinInicio()
        {
            listBoxPacientes.Items.Clear();

            Paciente pacienteAMostrar = listaPacientes.Fin;

            while (pacienteAMostrar != null)
            {
                //Para que se pueda ver, la clase Paciente tiene que tener implementado el método ToString
                listBoxPacientes.Items.Add(pacienteAMostrar);
                pacienteAMostrar = pacienteAMostrar.Anterior;
            }

            Reinicializar();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            listaPacientes.RegistrarPaciente(txtCodigo.Text, txtApellido.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text);
            MostrarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro que desea actualizar los datos del paciente??", "Actualizar Paciente", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Paciente pacienteSeleccionado = (Paciente)listBoxPacientes.SelectedItem;
                //Al ser una referencia al objeto de la lista, al cambiar el objeto, cambia el que esta en la lista.
                pacienteSeleccionado.Codigo = txtCodigo.Text;
                pacienteSeleccionado.Apellido = txtApellido.Text;
                pacienteSeleccionado.Nombre = txtNombre.Text;
                pacienteSeleccionado.Direccion = txtDireccion.Text;
                pacienteSeleccionado.Telefono = txtTelefono.Text;
                MostrarLista();
            }
        }

        private void listBoxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPacientes.SelectedIndex > -1)
            {
                btnRegistrar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminarPorCodigo.Enabled = true;
                btnEliminarPorReferencia.Enabled = true;
                btnNuevo.Enabled = true;

                Paciente pacienteSeleccionado = (Paciente)listBoxPacientes.SelectedItem;
                txtCodigo.Enabled = false;
                txtCodigo.Text = pacienteSeleccionado.Codigo;
                txtApellido.Text = pacienteSeleccionado.Apellido;
                txtNombre.Text = pacienteSeleccionado.Nombre;
                txtDireccion.Text = pacienteSeleccionado.Direccion;
                txtTelefono.Text = pacienteSeleccionado.Telefono;

            }
            else
            {
                Reinicializar();
            }
        }

        private void btnEliminarPorCodigo_Click(object sender, EventArgs e)
        {
            Paciente pacienteSeleccionado = (Paciente)listBoxPacientes.SelectedItem;
            listaPacientes.EliminarPaciente(pacienteSeleccionado.Codigo);
            MostrarLista();
        }

        private void btnEliminarPorReferencia_Click(object sender, EventArgs e)
        {
            Paciente pacienteSeleccionado = (Paciente)listBoxPacientes.SelectedItem;
            listaPacientes.EliminarPaciente(pacienteSeleccionado);
            MostrarLista();
        }

        private void btnMostrarInicioFin_Click(object sender, EventArgs e)
        {
            mostrarOrdenAscendente = true;
            MostrarLista();
        }

        private void btnMostrarFinInicio_Click(object sender, EventArgs e)
        {
            mostrarOrdenAscendente = false;
            MostrarLista();
        }
    }
}
