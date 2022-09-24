
namespace Listas_1
{
    partial class Form1
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
            this.lstListaEnlazada = new System.Windows.Forms.ListBox();
            this.btnPrincipio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListaEnlazada
            // 
            this.lstListaEnlazada.FormattingEnabled = true;
            this.lstListaEnlazada.Location = new System.Drawing.Point(12, 43);
            this.lstListaEnlazada.Name = "lstListaEnlazada";
            this.lstListaEnlazada.Size = new System.Drawing.Size(120, 329);
            this.lstListaEnlazada.TabIndex = 0;
            // 
            // btnPrincipio
            // 
            this.btnPrincipio.Location = new System.Drawing.Point(168, 127);
            this.btnPrincipio.Name = "btnPrincipio";
            this.btnPrincipio.Size = new System.Drawing.Size(125, 23);
            this.btnPrincipio.TabIndex = 1;
            this.btnPrincipio.Text = "Agregar al Principio";
            this.btnPrincipio.UseVisualStyleBackColor = true;
            this.btnPrincipio.Click += new System.EventHandler(this.btnPrincipio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(168, 191);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(125, 23);
            this.btnFinal.TabIndex = 2;
            this.btnFinal.Text = "Agregar al Final";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(138, 73);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(192, 20);
            this.txtNodo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Nodo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnPrincipio);
            this.Controls.Add(this.lstListaEnlazada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListaEnlazada;
        private System.Windows.Forms.Button btnPrincipio;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Label label1;
    }
}

