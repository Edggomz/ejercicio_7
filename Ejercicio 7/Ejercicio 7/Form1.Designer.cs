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
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1037, 406);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 105);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbConversion
            // 
            this.grbConversion.Controls.Add(this.lblPesos);
            this.grbConversion.Controls.Add(this.txtPesos);
            this.grbConversion.Controls.Add(this.lblSon);
            this.grbConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbConversion.Location = new System.Drawing.Point(107, 372);
            this.grbConversion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbConversion.Name = "grbConversion";
            this.grbConversion.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbConversion.Size = new System.Drawing.Size(853, 138);
            this.grbConversion.TabIndex = 10;
            this.grbConversion.TabStop = false;
            this.grbConversion.Text = "Resultado";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(418, 73);
            this.lblPesos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(56, 18);
            this.lblPesos.TabIndex = 10;
            this.lblPesos.Text = "Pesos";
            // 
            // txtPesos
            // 
            this.txtPesos.BackColor = System.Drawing.Color.Thistle;
            this.txtPesos.Location = new System.Drawing.Point(175, 64);
            this.txtPesos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.ReadOnly = true;
            this.txtPesos.Size = new System.Drawing.Size(164, 24);
            this.txtPesos.TabIndex = 9;
            this.txtPesos.TextChanged += new System.EventHandler(this.txtPesos_TextChanged_1);
            // 
            // lblSon
            // 
            this.lblSon.AutoSize = true;
            this.lblSon.Location = new System.Drawing.Point(38, 68);
            this.lblSon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSon.Name = "lblSon";
            this.lblSon.Size = new System.Drawing.Size(48, 18);
            this.lblSon.TabIndex = 1;
            this.lblSon.Text = "Son :";
            // 
            // txtDolares
            // 
            this.txtDolares.BackColor = System.Drawing.Color.Thistle;
            this.txtDolares.Location = new System.Drawing.Point(150, 156);
            this.txtDolares.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(147, 24);
            this.txtDolares.TabIndex = 11;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // lblIngPesos
            // 
            this.lblIngPesos.AutoSize = true;
            this.lblIngPesos.Location = new System.Drawing.Point(145, 114);
            this.lblIngPesos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngPesos.Name = "lblIngPesos";
            this.lblIngPesos.Size = new System.Drawing.Size(385, 18);
            this.lblIngPesos.TabIndex = 13;
            this.lblIngPesos.Text = "Ingresa los Dolares que quieras convertir a Pesos";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvertir.Location = new System.Drawing.Point(1037, 79);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(182, 105);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(1037, 234);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(182, 105);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblIngPesos);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.grbConversion);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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

