
namespace WinFormsApp2
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
            this.etiNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.checkProgramador = new System.Windows.Forms.CheckBox();
            this.radioBtnHombre = new System.Windows.Forms.RadioButton();
            this.radioBtnMujer = new System.Windows.Forms.RadioButton();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.etiSalida = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // etiNombre
            // 
            this.etiNombre.AutoSize = true;
            this.etiNombre.BackColor = System.Drawing.Color.Transparent;
            this.etiNombre.Location = new System.Drawing.Point(12, 20);
            this.etiNombre.Name = "etiNombre";
            this.etiNombre.Size = new System.Drawing.Size(56, 15);
            this.etiNombre.TabIndex = 0;
            this.etiNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(86, 17);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(367, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(485, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(186, 22);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // checkProgramador
            // 
            this.checkProgramador.AutoSize = true;
            this.checkProgramador.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkProgramador.Location = new System.Drawing.Point(12, 58);
            this.checkProgramador.Name = "checkProgramador";
            this.checkProgramador.Size = new System.Drawing.Size(115, 19);
            this.checkProgramador.TabIndex = 3;
            this.checkProgramador.Text = "PROGRAMADOR";
            this.checkProgramador.UseVisualStyleBackColor = true;
            // 
            // radioBtnHombre
            // 
            this.radioBtnHombre.AutoSize = true;
            this.radioBtnHombre.Location = new System.Drawing.Point(94, 44);
            this.radioBtnHombre.Name = "radioBtnHombre";
            this.radioBtnHombre.Size = new System.Drawing.Size(74, 19);
            this.radioBtnHombre.TabIndex = 4;
            this.radioBtnHombre.TabStop = true;
            this.radioBtnHombre.Text = "HOMBRE";
            this.radioBtnHombre.UseVisualStyleBackColor = true;
            // 
            // radioBtnMujer
            // 
            this.radioBtnMujer.AutoSize = true;
            this.radioBtnMujer.Location = new System.Drawing.Point(278, 44);
            this.radioBtnMujer.Name = "radioBtnMujer";
            this.radioBtnMujer.Size = new System.Drawing.Size(61, 19);
            this.radioBtnMujer.TabIndex = 5;
            this.radioBtnMujer.TabStop = true;
            this.radioBtnMujer.Text = "MUJER";
            this.radioBtnMujer.UseVisualStyleBackColor = true;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioBtnMujer);
            this.groupBoxSexo.Controls.Add(this.radioBtnHombre);
            this.groupBoxSexo.Location = new System.Drawing.Point(12, 94);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(449, 105);
            this.groupBoxSexo.TabIndex = 6;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "SEXO";
            // 
            // etiSalida
            // 
            this.etiSalida.AutoSize = true;
            this.etiSalida.Location = new System.Drawing.Point(12, 215);
            this.etiSalida.Name = "etiSalida";
            this.etiSalida.Size = new System.Drawing.Size(46, 15);
            this.etiSalida.TabIndex = 7;
            this.etiSalida.Text = "SALIDA";
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(11, 233);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(450, 138);
            this.txtSalida.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 392);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.etiSalida);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.checkProgramador);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.etiNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox checkProgramador;
        private System.Windows.Forms.RadioButton radioBtnHombre;
        private System.Windows.Forms.RadioButton radioBtnMujer;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.Label etiSalida;
        private System.Windows.Forms.TextBox txtSalida;
    }
}

