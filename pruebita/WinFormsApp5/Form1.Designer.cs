
namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiDirectorio = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbLista = new System.Windows.Forms.RadioButton();
            this.rbDetalle = new System.Windows.Forms.RadioButton();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.gpModo = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gpModo.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiDirectorio
            // 
            this.etiDirectorio.Location = new System.Drawing.Point(18, 20);
            this.etiDirectorio.Name = "etiDirectorio";
            this.etiDirectorio.Size = new System.Drawing.Size(368, 15);
            this.etiDirectorio.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(18, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(368, 307);
            this.listView1.SmallImageList = this.imageListSmall;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "IMG_6949.JPG");
            this.imageListLarge.Images.SetKeyName(1, "IMG_6950.JPG");
            this.imageListLarge.Images.SetKeyName(2, "IMG_6951.JPG");
            this.imageListLarge.Images.SetKeyName(3, "IMG_6952.JPG");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "IMG_6956.JPG");
            this.imageListSmall.Images.SetKeyName(1, "IMG_6957.JPG");
            this.imageListSmall.Images.SetKeyName(2, "IMG_6958.JPG");
            this.imageListSmall.Images.SetKeyName(3, "IMG_6960.JPG");
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(59, 65);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(80, 19);
            this.rbLargeIcon.TabIndex = 2;
            this.rbLargeIcon.Text = "Large Icon";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.rbLargeIcon_CheckedChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(59, 100);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(80, 19);
            this.rbSmallIcon.TabIndex = 3;
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.rbSmallIcon_CheckedChanged);
            // 
            // rbLista
            // 
            this.rbLista.AutoSize = true;
            this.rbLista.Location = new System.Drawing.Point(59, 134);
            this.rbLista.Name = "rbLista";
            this.rbLista.Size = new System.Drawing.Size(49, 19);
            this.rbLista.TabIndex = 4;
            this.rbLista.Text = "Lista";
            this.rbLista.UseVisualStyleBackColor = true;
            this.rbLista.CheckedChanged += new System.EventHandler(this.rbLista_CheckedChanged);
            // 
            // rbDetalle
            // 
            this.rbDetalle.AutoSize = true;
            this.rbDetalle.Checked = true;
            this.rbDetalle.Location = new System.Drawing.Point(59, 172);
            this.rbDetalle.Name = "rbDetalle";
            this.rbDetalle.Size = new System.Drawing.Size(61, 19);
            this.rbDetalle.TabIndex = 5;
            this.rbDetalle.TabStop = true;
            this.rbDetalle.Text = "Detalle";
            this.rbDetalle.UseVisualStyleBackColor = true;
            this.rbDetalle.CheckedChanged += new System.EventHandler(this.rbDetalle_CheckedChanged);
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.Location = new System.Drawing.Point(59, 208);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(55, 19);
            this.rbTitulo.TabIndex = 6;
            this.rbTitulo.Text = "Título";
            this.rbTitulo.UseVisualStyleBackColor = true;
            this.rbTitulo.CheckedChanged += new System.EventHandler(this.rbTitulo_CheckedChanged);
            // 
            // gpModo
            // 
            this.gpModo.Controls.Add(this.rbTitulo);
            this.gpModo.Controls.Add(this.rbDetalle);
            this.gpModo.Controls.Add(this.rbLista);
            this.gpModo.Controls.Add(this.rbSmallIcon);
            this.gpModo.Controls.Add(this.rbLargeIcon);
            this.gpModo.Location = new System.Drawing.Point(554, 52);
            this.gpModo.Name = "gpModo";
            this.gpModo.Size = new System.Drawing.Size(194, 307);
            this.gpModo.TabIndex = 7;
            this.gpModo.TabStop = false;
            this.gpModo.Text = "Modo de Vista";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(103, 384);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(183, 38);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gpModo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.etiDirectorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpModo.ResumeLayout(false);
            this.gpModo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etiDirectorio;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbLista;
        private System.Windows.Forms.RadioButton rbDetalle;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.GroupBox gpModo;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Button btnAtras;
    }
}

