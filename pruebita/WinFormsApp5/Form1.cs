using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection carpetacol;
        public Form1()
        {
            InitializeComponent();
            carpetacol = new System.Collections.Specialized.StringCollection();
            CrearCabecerayLlenarListView();
            DibujarListView(@"C:\");
            carpetacol.Add(@"C:\");

        }

        private void CrearCabecerayLlenarListView()
        {
            ColumnHeader colCab; //Declaro un objeto ColumnHeader.
            colCab = new ColumnHeader(); //Instancio el objeto ColumnHeader.
            colCab.Text = "Nombre Archivo";
            listView1.Columns.Add(colCab); // Inserto la Cabecera Nombre Archivo.
            colCab = new ColumnHeader();
            colCab.Text = "Tamaño";
            listView1.Columns.Add(colCab); // Inserto la Cabecera Tamaño.
            colCab = new ColumnHeader();
            colCab.Text = "Ultima Modificacion";
            listView1.Columns.Add(colCab); // Inserto la Cabecera Ultima Modificacion.
        }

        private void DibujarListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                listView1.Items.Clear();
                etiDirectorio.Text = root;
                listView1.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    listView1.Items.Add(lvi);
                }
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    listView1.Items.Add(lvi);
                }
                listView1.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                DibujarListView(filename);
                carpetacol.Add(filename);
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (carpetacol.Count > 1)
            {
                DibujarListView(carpetacol[carpetacol.Count - 2].ToString());
                carpetacol.RemoveAt(carpetacol.Count - 1);
            }
            else
                DibujarListView(carpetacol[0].ToString());
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                listView1.View = View.SmallIcon;
        }

        private void rbLista_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                listView1.View = View.List;
        }

        private void rbDetalle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                listView1.View = View.Details;
        }

        private void rbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                listView1.View = View.Tile;
        }
    }

  
}
