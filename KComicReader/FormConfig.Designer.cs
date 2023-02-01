namespace KComicReader
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.PictureBox();
            this.lblDirectorioInstalacion = new System.Windows.Forms.Label();
            this.tbDirectorioValue = new System.Windows.Forms.TextBox();
            this.lblColorFondo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloInstalacion = new System.Windows.Forms.Label();
            this.lblTituloTema = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbBtnColor1 = new System.Windows.Forms.PictureBox();
            this.pbBtnColor2 = new System.Windows.Forms.PictureBox();
            this.lblColorSeleccionado1 = new System.Windows.Forms.Label();
            this.lblColorSeleccionado2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnColor2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(13, 9);
            this.lblTituloFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(571, 71);
            this.lblTituloFormulario.TabIndex = 12;
            this.lblTituloFormulario.Text = "CONFIGURACIÓN";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(511, 369);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 33);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(385, 369);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 33);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCarpeta.Image")));
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(554, 130);
            this.btnSeleccionarCarpeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(28, 28);
            this.btnSeleccionarCarpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarCarpeta.TabIndex = 29;
            this.btnSeleccionarCarpeta.TabStop = false;
            this.btnSeleccionarCarpeta.Tag = "Agregar Editorial";
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            this.btnSeleccionarCarpeta.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnSeleccionarCarpeta.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // lblDirectorioInstalacion
            // 
            this.lblDirectorioInstalacion.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorioInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorioInstalacion.Location = new System.Drawing.Point(25, 128);
            this.lblDirectorioInstalacion.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblDirectorioInstalacion.Name = "lblDirectorioInstalacion";
            this.lblDirectorioInstalacion.Size = new System.Drawing.Size(229, 32);
            this.lblDirectorioInstalacion.TabIndex = 28;
            this.lblDirectorioInstalacion.Text = "Directorio de instalación:";
            this.lblDirectorioInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDirectorioValue
            // 
            this.tbDirectorioValue.Enabled = false;
            this.tbDirectorioValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirectorioValue.Location = new System.Drawing.Point(260, 130);
            this.tbDirectorioValue.Name = "tbDirectorioValue";
            this.tbDirectorioValue.Size = new System.Drawing.Size(288, 28);
            this.tbDirectorioValue.TabIndex = 30;
            this.tbDirectorioValue.Text = "Pulsa el botón para seleccionar";
            // 
            // lblColorFondo1
            // 
            this.lblColorFondo1.BackColor = System.Drawing.Color.Transparent;
            this.lblColorFondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorFondo1.Location = new System.Drawing.Point(25, 232);
            this.lblColorFondo1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblColorFondo1.Name = "lblColorFondo1";
            this.lblColorFondo1.Size = new System.Drawing.Size(296, 28);
            this.lblColorFondo1.TabIndex = 31;
            this.lblColorFondo1.Text = "Color de fondo para degradado 1:";
            this.lblColorFondo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Color de fondo para degradado 2:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloInstalacion
            // 
            this.lblTituloInstalacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloInstalacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInstalacion.Location = new System.Drawing.Point(22, 82);
            this.lblTituloInstalacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloInstalacion.Name = "lblTituloInstalacion";
            this.lblTituloInstalacion.Size = new System.Drawing.Size(259, 34);
            this.lblTituloInstalacion.TabIndex = 33;
            this.lblTituloInstalacion.Text = "INSTALACIÓN";
            this.lblTituloInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloTema
            // 
            this.lblTituloTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloTema.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTema.Location = new System.Drawing.Point(22, 182);
            this.lblTituloTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloTema.Name = "lblTituloTema";
            this.lblTituloTema.Size = new System.Drawing.Size(259, 34);
            this.lblTituloTema.TabIndex = 34;
            this.lblTituloTema.Text = "TEMA";
            this.lblTituloTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbBtnColor1
            // 
            this.pbBtnColor1.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnColor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnColor1.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnColor1.Image")));
            this.pbBtnColor1.Location = new System.Drawing.Point(327, 232);
            this.pbBtnColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBtnColor1.Name = "pbBtnColor1";
            this.pbBtnColor1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBtnColor1.Size = new System.Drawing.Size(28, 28);
            this.pbBtnColor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnColor1.TabIndex = 35;
            this.pbBtnColor1.TabStop = false;
            this.pbBtnColor1.Tag = "Agregar Editorial";
            this.pbBtnColor1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbBtnColor2
            // 
            this.pbBtnColor2.BackColor = System.Drawing.Color.Transparent;
            this.pbBtnColor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnColor2.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnColor2.Image")));
            this.pbBtnColor2.Location = new System.Drawing.Point(327, 278);
            this.pbBtnColor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBtnColor2.Name = "pbBtnColor2";
            this.pbBtnColor2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBtnColor2.Size = new System.Drawing.Size(28, 28);
            this.pbBtnColor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnColor2.TabIndex = 36;
            this.pbBtnColor2.TabStop = false;
            this.pbBtnColor2.Tag = "Agregar Editorial";
            this.pbBtnColor2.Click += new System.EventHandler(this.pbBtnColor2_Click);
            // 
            // lblColorSeleccionado1
            // 
            this.lblColorSeleccionado1.BackColor = System.Drawing.Color.Transparent;
            this.lblColorSeleccionado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSeleccionado1.Location = new System.Drawing.Point(361, 232);
            this.lblColorSeleccionado1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblColorSeleccionado1.Name = "lblColorSeleccionado1";
            this.lblColorSeleccionado1.Size = new System.Drawing.Size(187, 32);
            this.lblColorSeleccionado1.TabIndex = 37;
            this.lblColorSeleccionado1.Text = "Color seleccionado";
            this.lblColorSeleccionado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColorSeleccionado2
            // 
            this.lblColorSeleccionado2.BackColor = System.Drawing.Color.Transparent;
            this.lblColorSeleccionado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorSeleccionado2.Location = new System.Drawing.Point(361, 274);
            this.lblColorSeleccionado2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblColorSeleccionado2.Name = "lblColorSeleccionado2";
            this.lblColorSeleccionado2.Size = new System.Drawing.Size(187, 32);
            this.lblColorSeleccionado2.TabIndex = 38;
            this.lblColorSeleccionado2.Text = "Color seleccionado";
            this.lblColorSeleccionado2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 415);
            this.Controls.Add(this.lblColorSeleccionado2);
            this.Controls.Add(this.lblColorSeleccionado1);
            this.Controls.Add(this.pbBtnColor2);
            this.Controls.Add(this.pbBtnColor1);
            this.Controls.Add(this.lblTituloTema);
            this.Controls.Add(this.lblTituloInstalacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColorFondo1);
            this.Controls.Add(this.tbDirectorioValue);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.lblDirectorioInstalacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTituloFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración de KComicReader";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormConfig_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnColor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblDirectorioInstalacion;
        private System.Windows.Forms.TextBox tbDirectorioValue;
        private System.Windows.Forms.Label lblColorFondo1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTituloInstalacion;
        public System.Windows.Forms.Label lblTituloTema;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbBtnColor1;
        private System.Windows.Forms.PictureBox pbBtnColor2;
        private System.Windows.Forms.Label lblColorSeleccionado1;
        private System.Windows.Forms.Label lblColorSeleccionado2;
    }
}