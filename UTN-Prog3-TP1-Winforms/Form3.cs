using System;
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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCompleto;
            nombreCompleto = nombreBox.Text + " " + apellidoBox.Text;

            listaDeNombres.Items.Add(nombreCompleto);
            nombreBox.Clear(); 
            apellidoBox.Clear();
        }
 
    }
}