namespace UTN_Prog3_TP1_Winforms
{
    partial class FmActividad1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPasarItem = new System.Windows.Forms.Button();
            this.btnPasarItems = new System.Windows.Forms.Button();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.lbValores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(383, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPasarItem
            // 
            this.btnPasarItem.Location = new System.Drawing.Point(237, 200);
            this.btnPasarItem.Name = "btnPasarItem";
            this.btnPasarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPasarItem.TabIndex = 3;
            this.btnPasarItem.Text = ">";
            this.btnPasarItem.UseVisualStyleBackColor = true;
            this.btnPasarItem.Click += new System.EventHandler(this.btnPasarItem_Click);
            // 
            // btnPasarItems
            // 
            this.btnPasarItems.Location = new System.Drawing.Point(237, 264);
            this.btnPasarItems.Name = "btnPasarItems";
            this.btnPasarItems.Size = new System.Drawing.Size(75, 23);
            this.btnPasarItems.TabIndex = 4;
            this.btnPasarItems.Text = ">>";
            this.btnPasarItems.UseVisualStyleBackColor = true;
            this.btnPasarItems.Click += new System.EventHandler(this.btnPasarItems_Click);
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.Location = new System.Drawing.Point(360, 159);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.Size = new System.Drawing.Size(188, 212);
            this.lbSeleccionados.TabIndex = 5;
            // 
            // lbValores
            // 
            this.lbValores.FormattingEnabled = true;
            this.lbValores.Location = new System.Drawing.Point(12, 159);
            this.lbValores.Name = "lbValores";
            this.lbValores.Size = new System.Drawing.Size(188, 212);
            this.lbValores.TabIndex = 6;
            // 
            // FmActividad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.lbValores);
            this.Controls.Add(this.lbSeleccionados);
            this.Controls.Add(this.btnPasarItems);
            this.Controls.Add(this.btnPasarItem);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FmActividad1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnPasarItem;
        private System.Windows.Forms.Button btnPasarItems;
        private System.Windows.Forms.ListBox lbSeleccionados;
        private System.Windows.Forms.ListBox lbValores;
    }
}