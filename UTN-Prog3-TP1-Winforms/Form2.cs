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



            //validacion nombres vacios
            if (txtNombre.Text.Trim() == "")
            {
                
                MessageBox.Show("Debe ingresar un nombre primero.", "Atencion!");
                return;
            }



            //validacion nombres repetidos

            bool estaRepetido = true;


            foreach (var item in lbValores.Items)
            {

                if (txtNombre.Text.Trim().ToUpper() == item.ToString().Trim().ToUpper())
                {
                    estaRepetido = false;

                }

            }

            foreach (var item in lbSeleccionados.Items)
            {
                if (txtNombre.Text.Trim().ToUpper() == item.ToString().Trim().ToUpper())
                {
                    estaRepetido = false;

                }

            }

            ///asi lo veo mas escalable al codigo, se pueden meter muchas validaciones y solo modificar el booleano

            //si  no es valido, no lo acepta.
            //si es valido, lo añade
            if (!estaRepetido)
            {
                MessageBox.Show("Debe ingresar un nombre que no este repetido");
            }
            else
            {
                lbValores.Items.Add(txtNombre.Text.Trim());
                txtNombre.Clear();
            }



        }

        private void btnPasarItem_Click(object sender, EventArgs e)
        {
            if (lbValores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un nombre.");
            }
            else
            {
                lbSeleccionados.Items.Add(lbValores.SelectedItem);
                lbValores.Items.Remove(lbValores.SelectedItem);
            }
        }

        private void btnPasarItems_Click(object sender, EventArgs e)
        {
            if (lbValores.Items.Count == 0)
            {
                MessageBox.Show("Debe haber al menos un nombre ingresado.");
                return;
            }
            foreach (var item in lbValores.Items)
            {
                lbSeleccionados.Items.Add(item);
            }
            lbValores.Items.Clear();
        }

   
    }
}
