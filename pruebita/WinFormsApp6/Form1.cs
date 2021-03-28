using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fuentes.SelectedIndex = 0;
        }

   

        private void showHelpMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            showHelpMenuToolStripMenuItem.Visible = item.Checked;
            
        }

        private void menuNuevo_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
        }
        private void menuAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile("Example.rtf");
            }
            catch { }
        }
        private void menuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile("Example.rtf");
            }
            catch { }
        }

        private void richTextBoxText_Click(object sender, EventArgs e)
        {

        }
   
        private void negrita_Click(object sender, EventArgs e)
        {
            Font viejaFuente; //Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente; //Declaro una variable Class Font para la Fuente Nueva.
                              //Asigno a viejaFuente el tipo de fuente seleccionado.
                              //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
                              //del Control RichTextBox.
            viejaFuente = richTextBoxText.SelectionFont;
            if (viejaFuente.Bold) //Pregunto si ya es Negrita.
                                  //Si ya Tenia Negrita, establece nuevaFuente sin Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Bold);
            else
                //Si no Tenia Negrita, establece nuevaFuente con Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Bold);

            //Establezco la nuevaFuente a la Selección.
            richTextBoxText.SelectionFont = nuevaFuente;
            //Realizo un foco para posicionarme en el Control.
            richTextBoxText.Focus();
            
        }

        private void subrayado_Click(object sender, EventArgs e)
        {
            Font viejaFuente; //Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente; //Declaro una variable Class Font para la Fuente Nueva.
                              //Asigno a viejaFuente el tipo de fuente seleccionado.
                              //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
                              //del Control RichTextBox.
            viejaFuente = richTextBoxText.SelectionFont;
            if (viejaFuente.Underline) //Pregunto si ya es Subrayado.
                                       //Si ya Tenia Subrayado, establece nuevaFuente sin Subrayado.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Underline);
            else
                //Si no Tenia Subrayado, establece nuevaFuente con Subrayado.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Underline);
            //Establezco la nuevaFuente a la Selección.
            richTextBoxText.SelectionFont = nuevaFuente;
            //Realizo un foco para posicionarme en el Control.
            richTextBoxText.Focus();
        }

        private void cursiva_Click(object sender, EventArgs e)
        {
            Font viejaFuente; //Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente; //Declaro una variable Class Font para la Fuente Nueva.
                              //Asigno a viejaFuente el tipo de fuente seleccionado.
                              //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
                              //del Control RichTextBox.
            viejaFuente = richTextBoxText.SelectionFont;
            if (viejaFuente.Italic) //Pregunto si ya es Cursiva.
                                    //Si ya Tenia Cursiva, establece nuevaFuente sin Cursiva.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Italic);
            else
                //Si no Tenia Cursiva, establece nuevaFuente con Cursiva.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Italic);
            //Establesco la nuevaFuente a la Selección.
            richTextBoxText.SelectionFont = nuevaFuente;
            //Realizo un foco para posicionarme en el Control.
            richTextBoxText.Focus();
        }

        private void fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            Font newFont = null;
            if (richTextBoxText.SelectionFont == null)
                newFont = new Font(text, richTextBoxText.Font.Size);
            else
                newFont = new Font(text, richTextBoxText.SelectionFont.Size,
                richTextBoxText.SelectionFont.Style);
            richTextBoxText.SelectionFont = newFont;



        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Number of characters: " +
            richTextBoxText.Text.Length;
           
        }
    }
}
