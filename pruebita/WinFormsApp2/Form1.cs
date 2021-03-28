using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarOk()
        {
            txtNombre.Text = txtNombre.Text.Trim();
            if (txtNombre.Text.Length > 0) btnOk.Enabled = true;
            if(txtNombre.Text.Length == 0) btnOk.Enabled = false;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
    
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           ValidarOk();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String salida; //Declaro una variable para armar la salida.
            salida = "Nombe: " + txtNombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(checkProgramador.Checked ?
            "Programador" : "No es Programador") + "\r\n";
            salida += "Sexo: " + (string)(radioBtnHombre.Checked ? "Hombre" :
            "Mujer") + "\r\n";

            //Vuelco la salida al TextBox Salida.
            txtSalida.Text = salida;

        }
    }
}
