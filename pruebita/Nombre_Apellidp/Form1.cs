using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nombre_Apellidp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau perri...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cargando App");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text.Length > 0 && txtNombre.Text.Length > 0 && txtEdad.Text.Length > 0 && txtDireccion.Text.Length > 0)
            {
                txtResultado.Text = "NOMBRE Y APELLIDO: " + txtNombre.Text + " " + txtApellido.Text;
                txtResultado.Text = txtResultado.Text + "\r\n" + "EDAD: " + txtEdad.Text;
                txtResultado.Text = txtResultado.Text + "\r\n" + "DIRECCION: " + txtDireccion.Text;}

            else
            {
                if (txtApellido.Text.Length == 0){txtApellido.BackColor = Color.Red;}
                if(txtNombre.Text.Length == 0) { txtNombre.BackColor = Color.Red;}
                if (txtEdad.Text.Length == 0) { txtEdad.BackColor = Color.Red;}
                if (txtDireccion.Text.Length == 0) { txtDireccion.BackColor = Color.Red;}
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = Color.White;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = Color.White;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }
    }
}
