
namespace Lista_1
{
    partial class Consultorio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarPorReferencia = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminarPorCodigo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnMostrarFinInicio = new System.Windows.Forms.Button();
            this.btnMostrarInicioFin = new System.Windows.Forms.Button();
            this.gbPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Pacientes.";
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.ItemHeight = 16;
            this.listBoxPacientes.Location = new System.Drawing.Point(16, 53);
            this.listBoxPacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(304, 308);
            this.listBoxPacientes.TabIndex = 6;
            this.listBoxPacientes.TabStop = false;
            this.listBoxPacientes.SelectedIndexChanged += new System.EventHandler(this.listBoxPacientes_SelectedIndexChanged);
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.btnEliminarPorReferencia);
            this.gbPaciente.Controls.Add(this.btnNuevo);
            this.gbPaciente.Controls.Add(this.btnEliminarPorCodigo);
            this.gbPaciente.Controls.Add(this.btnActualizar);
            this.gbPaciente.Controls.Add(this.lblTelefono);
            this.gbPaciente.Controls.Add(this.txtTelefono);
            this.gbPaciente.Controls.Add(this.btnRegistrar);
            this.gbPaciente.Controls.Add(this.lblDireccion);
            this.gbPaciente.Controls.Add(this.txtDireccion);
            this.gbPaciente.Controls.Add(this.label2);
            this.gbPaciente.Controls.Add(this.txtCodigo);
            this.gbPaciente.Controls.Add(this.label3);
            this.gbPaciente.Controls.Add(this.txtNombre);
            this.gbPaciente.Controls.Add(this.label4);
            this.gbPaciente.Controls.Add(this.txtApellido);
            this.gbPaciente.Location = new System.Drawing.Point(369, 54);
            this.gbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Padding = new System.Windows.Forms.Padding(4);
            this.gbPaciente.Size = new System.Drawing.Size(528, 372);
            this.gbPaciente.TabIndex = 10;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // btnEliminarPorReferencia
            // 
            this.btnEliminarPorReferencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminarPorReferencia.Location = new System.Drawing.Point(264, 310);
            this.btnEliminarPorReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPorReferencia.Name = "btnEliminarPorReferencia";
            this.btnEliminarPorReferencia.Size = new System.Drawing.Size(224, 42);
            this.btnEliminarPorReferencia.TabIndex = 9;
            this.btnEliminarPorReferencia.Text = "Eliminar x Referencia";
            this.btnEliminarPorReferencia.UseVisualStyleBackColor = false;
            this.btnEliminarPorReferencia.Click += new System.EventHandler(this.btnEliminarPorReferencia_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(263, 48);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(225, 28);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminarPorCodigo
            // 
            this.btnEliminarPorCodigo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminarPorCodigo.Location = new System.Drawing.Point(20, 309);
            this.btnEliminarPorCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPorCodigo.Name = "btnEliminarPorCodigo";
            this.btnEliminarPorCodigo.Size = new System.Drawing.Size(235, 43);
            this.btnEliminarPorCodigo.TabIndex = 8;
            this.btnEliminarPorCodigo.Text = "Eliminar x Código";
            this.btnEliminarPorCodigo.UseVisualStyleBackColor = false;
            this.btnEliminarPorCodigo.Click += new System.EventHandler(this.btnEliminarPorCodigo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(23, 265);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(465, 37);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(260, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(263, 158);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(229, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(24, 219);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(468, 36);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(21, 138);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(24, 158);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(229, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(24, 52);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(264, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(24, 111);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(229, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // btnMostrarFinInicio
            // 
            this.btnMostrarFinInicio.Location = new System.Drawing.Point(180, 372);
            this.btnMostrarFinInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarFinInicio.Name = "btnMostrarFinInicio";
            this.btnMostrarFinInicio.Size = new System.Drawing.Size(140, 54);
            this.btnMostrarFinInicio.TabIndex = 13;
            this.btnMostrarFinInicio.Text = "Fin -> Inicio";
            this.btnMostrarFinInicio.UseVisualStyleBackColor = true;
            this.btnMostrarFinInicio.Click += new System.EventHandler(this.btnMostrarFinInicio_Click);
            // 
            // btnMostrarInicioFin
            // 
            this.btnMostrarInicioFin.Location = new System.Drawing.Point(16, 372);
            this.btnMostrarInicioFin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarInicioFin.Name = "btnMostrarInicioFin";
            this.btnMostrarInicioFin.Size = new System.Drawing.Size(136, 54);
            this.btnMostrarInicioFin.TabIndex = 12;
            this.btnMostrarInicioFin.Text = "Inicio -> Fin";
            this.btnMostrarInicioFin.UseVisualStyleBackColor = true;
            this.btnMostrarInicioFin.Click += new System.EventHandler(this.btnMostrarInicioFin_Click);
            // 
            // Consultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 438);
            this.Controls.Add(this.btnMostrarFinInicio);
            this.Controls.Add(this.btnMostrarInicioFin);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.listBoxPacientes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consultorio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Consultorio_Load);
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.Button btnEliminarPorReferencia;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminarPorCodigo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnMostrarFinInicio;
        private System.Windows.Forms.Button btnMostrarInicioFin;
    }
}

