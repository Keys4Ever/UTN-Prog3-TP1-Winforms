﻿
namespace UTN_Prog3_TP1_Winforms
{
    partial class FormPrincipal
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
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.textGonzaloCubilla = new System.Windows.Forms.Label();
            this.textValentínLópez = new System.Windows.Forms.Label();
            this.textCalvaIgnacio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Location = new System.Drawing.Point(46, 60);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(116, 41);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "Ejercicio 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(42, 150);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(104, 22);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Integrantes:";
      
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.Location = new System.Drawing.Point(217, 60);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(116, 41);
            this.btnEjercicio2.TabIndex = 2;
            this.btnEjercicio2.Text = "Ejercicio 2";
            this.btnEjercicio2.UseVisualStyleBackColor = true;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // textGonzaloCubilla
            // 
            this.textGonzaloCubilla.AutoSize = true;
            this.textGonzaloCubilla.Font = new System.Drawing.Font("Minecraftia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGonzaloCubilla.Location = new System.Drawing.Point(154, 181);
            this.textGonzaloCubilla.Name = "textGonzaloCubilla";
            this.textGonzaloCubilla.Size = new System.Drawing.Size(163, 26);
            this.textGonzaloCubilla.TabIndex = 3;
            this.textGonzaloCubilla.Text = "Cubilla Gonzalo";
           
            // 
            // textValentínLópez
            // 
            this.textValentínLópez.AutoSize = true;
            this.textValentínLópez.Font = new System.Drawing.Font("Minecraftia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValentínLópez.Location = new System.Drawing.Point(154, 207);
            this.textValentínLópez.Name = "textValentínLópez";
            this.textValentínLópez.Size = new System.Drawing.Size(165, 26);
            this.textValentínLópez.TabIndex = 4;
            this.textValentínLópez.Text = "López Valentín ";
          
            // 
            // textCalvaIgnacio
            // 
            this.textCalvaIgnacio.AutoSize = true;
            this.textCalvaIgnacio.Font = new System.Drawing.Font("Minecraftia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCalvaIgnacio.Location = new System.Drawing.Point(154, 233);
            this.textCalvaIgnacio.Name = "textCalvaIgnacio";
            this.textCalvaIgnacio.Size = new System.Drawing.Size(146, 26);
            this.textCalvaIgnacio.TabIndex = 5;
            this.textCalvaIgnacio.Text = "Calva Ignacio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.textCalvaIgnacio);
            this.Controls.Add(this.textValentínLópez);
            this.Controls.Add(this.textGonzaloCubilla);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEjercicio1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
     
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Label textGonzaloCubilla;
        private System.Windows.Forms.Label textValentínLópez;
        private System.Windows.Forms.Label textCalvaIgnacio;
    }
}

