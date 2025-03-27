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

            if ((nombreBox.Text.Trim()=="") && (apellidoBox.Text.Trim()== ""))
            {
                MessageBox.Show("Debe ingresar nombre y apellido.", "Atencion!");
            }
            else if (nombreBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre.", "Atencion!");
            }
            else if (apellidoBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un apellido.", "Atencion!");
            }
            else
            {
                string nombreCompleto;
                nombreCompleto = nombreBox.Text.Trim() + " " + apellidoBox.Text.Trim();
                bool nombreExiste = false;
                foreach (string persona in listaDeNombres.Items)
                {
                    if (persona.Trim().ToUpper() == nombreCompleto.ToUpper())
                    {
                        nombreExiste = true;
                        break;
                    }
                }

                if (nombreExiste)
                {
                    MessageBox.Show("El nombre ya existe");
                }
                else
                {
                    listaDeNombres.Items.Add(nombreCompleto);
                    nombreBox.Clear();
                    apellidoBox.Clear();
                }   
            }
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {   
            if(listaDeNombres.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar un item para eliminarlo", "Warning");
                return;
            }

            listaDeNombres.Items.RemoveAt(listaDeNombres.SelectedIndex);
        }
    }
}