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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            // Volver a settear todas las labels manualmente
            lblState.Text = "Estado civil: ";
            lblSex.Text = "Sexo: ";
            lblOficioList.Text = "";

            // Labels estáticas. Se settean a visible para que se muestren
            lblStatic.Visible = false;
            lblStaticOficio.Visible = false;

            // Settear las labels con los valores de los radio buttons
            lblState.Text += rbCasado.Checked ? "Casado" : "Soltero"; // Quizás hacer que cambie de casado o soltero a casada o soltera dependiendo del sexo seleccionado? - solo en el output, no en el rb
            lblState.Visible = false;

            lblSex.Text += rbMasculino.Checked ? "Masculino" : "Femenino";
            lblSex.Visible = false;

            // Acá setteo el label de los oficios

            if(oficiosList.CheckedItems.Count == 0)
            {
                lblOficioList.Text += "-Sin oficio";

            }
            else
            {
                foreach (var item in oficiosList.CheckedItems)
                {
                    lblOficioList.Text += "-" + item.ToString() + '\n';
                }

            }
                ///hago visibles los labels al confirmar que se selecciono un oficio
                lblStatic.Visible = true;
                lblState.Visible = true;
                lblStaticOficio.Visible = true;
                lblSex.Visible = true;
            
        }

    }
}
