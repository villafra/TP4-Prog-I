﻿
namespace Pila_Ej
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Item";
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(12, 62);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(12, 108);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarNuevo.TabIndex = 2;
            this.btnAgregarNuevo.Text = "Apilar";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(13, 176);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(99, 23);
            this.btnDesapilar.TabIndex = 3;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(194, 44);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(120, 186);
            this.lstPila.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 273);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.ListBox lstPila;
    }
}

