namespace UTN_Prog3_TP1_Winforms
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSoltero = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.oficiosList = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatic = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblStaticOficio = new System.Windows.Forms.Label();
            this.lblOficioList = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(71, 49);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(118, 83);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(16, 51);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.Text = "Masculino\r\n";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Checked = true;
            this.rbFemenino.Location = new System.Drawing.Point(16, 28);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstadoCivil.Controls.Add(this.rbSoltero);
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(302, 49);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(120, 83);
            this.gbEstadoCivil.TabIndex = 1;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // rbSoltero
            // 
            this.rbSoltero.AutoSize = true;
            this.rbSoltero.Location = new System.Drawing.Point(16, 51);
            this.rbSoltero.Name = "rbSoltero";
            this.rbSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbSoltero.TabIndex = 2;
            this.rbSoltero.Text = "Soltero";
            this.rbSoltero.UseVisualStyleBackColor = true;
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Checked = true;
            this.rbCasado.Location = new System.Drawing.Point(16, 28);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // oficiosList
            // 
            this.oficiosList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oficiosList.FormattingEnabled = true;
            this.oficiosList.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.oficiosList.Location = new System.Drawing.Point(165, 138);
            this.oficiosList.Name = "oficiosList";
            this.oficiosList.Size = new System.Drawing.Size(160, 79);
            this.oficiosList.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(165, 233);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo seleccionado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblStatic
            // 
            this.lblStatic.AutoSize = true;
            this.lblStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblStatic.Location = new System.Drawing.Point(68, 287);
            this.lblStatic.Name = "lblStatic";
            this.lblStatic.Size = new System.Drawing.Size(353, 22);
            this.lblStatic.TabIndex = 5;
            this.lblStatic.Text = "Usted seleccionó los siguientes elementos:";
            this.lblStatic.Visible = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSex.Location = new System.Drawing.Point(68, 309);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(61, 22);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sexo: ";
            this.lblSex.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblState.Location = new System.Drawing.Point(68, 331);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(106, 22);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "Estado civil:";
            this.lblState.Visible = false;
            // 
            // lblStaticOficio
            // 
            this.lblStaticOficio.AutoSize = true;
            this.lblStaticOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblStaticOficio.Location = new System.Drawing.Point(68, 353);
            this.lblStaticOficio.Name = "lblStaticOficio";
            this.lblStaticOficio.Size = new System.Drawing.Size(66, 22);
            this.lblStaticOficio.TabIndex = 8;
            this.lblStaticOficio.Text = "Oficio: ";
            this.lblStaticOficio.Visible = false;
            // 
            // lblOficioList
            // 
            this.lblOficioList.AutoSize = true;
            this.lblOficioList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblOficioList.Location = new System.Drawing.Point(99, 375);
            this.lblOficioList.Name = "lblOficioList";
            this.lblOficioList.Size = new System.Drawing.Size(0, 22);
            this.lblOficioList.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 525);
            this.Controls.Add(this.lblOficioList);
            this.Controls.Add(this.lblStaticOficio);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblStatic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.oficiosList);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.gbSexo);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbSoltero;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.CheckedListBox oficiosList;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatic;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStaticOficio;
        private System.Windows.Forms.Label lblOficioList;
    }
}