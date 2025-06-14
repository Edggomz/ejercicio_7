using System;

namespace Ejercicio_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbConversion = new System.Windows.Forms.GroupBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.lblSon = new System.Windows.Forms.Label();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.lblIngPesos = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(622, 293);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 76);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbConversion
            // 
            this.grbConversion.Controls.Add(this.lblPesos);
            this.grbConversion.Controls.Add(this.txtPesos);
            this.grbConversion.Controls.Add(this.lblSon);
            this.grbConversion.Location = new System.Drawing.Point(64, 269);
            this.grbConversion.Name = "grbConversion";
            this.grbConversion.Size = new System.Drawing.Size(512, 100);
            this.grbConversion.TabIndex = 10;
            this.grbConversion.TabStop = false;
            this.grbConversion.Text = "Resultado";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(251, 53);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(36, 13);
            this.lblPesos.TabIndex = 10;
            this.lblPesos.Text = "Pesos";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(105, 46);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.ReadOnly = true;
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 9;
            this.txtPesos.TextChanged += new System.EventHandler(this.txtPesos_TextChanged_1);
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Location = new System.Drawing.Point(23, 49);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(32, 13);
            this.lblSon.TabIndex = 1;
            this.lblSon.Text = "Son :";
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(90, 113);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(90, 20);
            this.txtDolares.TabIndex = 11;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // lblIngPesos
            // 
            this.lblIngPesos.AutoSize = true;
            this.lblIngPesos.Location = new System.Drawing.Point(87, 82);
            this.lblIngPesos.Name = "lblIngPesos";
            this.lblIngPesos.Size = new System.Drawing.Size(240, 13);
            this.lblIngPesos.TabIndex = 13;
            this.lblIngPesos.Text = "Ingresa los Dolares que quieras convertir a Pesos";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvertir.Location = new System.Drawing.Point(622, 57);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(109, 76);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(622, 169);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 76);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblIngPesos);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.grbConversion);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbConversion.ResumeLayout(false);
            this.grbConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPesos_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbConversion;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label lblSon;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Label lblIngPesos;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnBorrar;
    }
}

