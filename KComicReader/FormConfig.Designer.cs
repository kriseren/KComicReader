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
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).BeginInit();
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
            this.btnCancelar.Location = new System.Drawing.Point(511, 168);
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
            this.btnAgregar.Location = new System.Drawing.Point(385, 168);
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
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(554, 84);
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
            this.lblDirectorioInstalacion.Location = new System.Drawing.Point(25, 82);
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
            this.tbDirectorioValue.Location = new System.Drawing.Point(260, 84);
            this.tbDirectorioValue.Name = "tbDirectorioValue";
            this.tbDirectorioValue.Size = new System.Drawing.Size(288, 28);
            this.tbDirectorioValue.TabIndex = 30;
            this.tbDirectorioValue.Text = "Pulsa el botón para seleccionar";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 214);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).EndInit();
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
    }
}