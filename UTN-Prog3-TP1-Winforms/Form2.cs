﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN_Prog3_TP1_Winforms
{
    public partial class FmActividad1 : Form
    {
        public FmActividad1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                lbValores.Items.Add(txtNombre.Text.Trim());
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre primero.", "Atencion!");
            }
        }
    }
}
