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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.PictureBox();
            this.lblDirectorioInstalacion = new System.Windows.Forms.Label();
            this.tbDirectorioValue = new System.Windows.Forms.TextBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblTituloInstalacion = new System.Windows.Forms.Label();
            this.lblTituloTema = new System.Windows.Forms.Label();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.lblTituloExtra = new System.Windows.Forms.Label();
            this.checkBoxMostrarInicio = new System.Windows.Forms.CheckBox();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
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
            this.btnCancelar.Location = new System.Drawing.Point(511, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 33);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(385, 399);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCarpeta.Image")));
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(555, 130);
            this.btnSeleccionarCarpeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(28, 28);
            this.btnSeleccionarCarpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarCarpeta.TabIndex = 29;
            this.btnSeleccionarCarpeta.TabStop = false;
            this.btnSeleccionarCarpeta.Tag = "Agregar Editorial";
            this.toolTipGeneral.SetToolTip(this.btnSeleccionarCarpeta, "Haz click para seleccionar el directorio de instalación.");
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.BtnSeleccionarCarpeta_Click);
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
            this.tbDirectorioValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDirectorioValue.Name = "tbDirectorioValue";
            this.tbDirectorioValue.Size = new System.Drawing.Size(288, 28);
            this.tbDirectorioValue.TabIndex = 30;
            this.tbDirectorioValue.Text = "Pulsa el botón para seleccionar";
            // 
            // lblTema
            // 
            this.lblTema.BackColor = System.Drawing.Color.Transparent;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(25, 231);
            this.lblTema.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(337, 28);
            this.lblTema.TabIndex = 31;
            this.lblTema.Text = "Esquema de colores para la interfaz.";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloInstalacion
            // 
            this.lblTituloInstalacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloInstalacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInstalacion.Location = new System.Drawing.Point(21, 82);
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
            this.lblTituloTema.Location = new System.Drawing.Point(21, 182);
            this.lblTituloTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloTema.Name = "lblTituloTema";
            this.lblTituloTema.Size = new System.Drawing.Size(259, 34);
            this.lblTituloTema.TabIndex = 34;
            this.lblTituloTema.Text = "TEMA";
            this.lblTituloTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTema
            // 
            this.cbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(371, 231);
            this.cbTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(212, 30);
            this.cbTema.TabIndex = 35;
            this.toolTipGeneral.SetToolTip(this.cbTema, "Selecciona el esquema de colores para la interfaz.");
            // 
            // lblTituloExtra
            // 
            this.lblTituloExtra.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloExtra.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloExtra.Location = new System.Drawing.Point(21, 278);
            this.lblTituloExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloExtra.Name = "lblTituloExtra";
            this.lblTituloExtra.Size = new System.Drawing.Size(305, 34);
            this.lblTituloExtra.TabIndex = 37;
            this.lblTituloExtra.Text = "OPCIONES ADICIONALES";
            this.lblTituloExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxMostrarInicio
            // 
            this.checkBoxMostrarInicio.AutoSize = true;
            this.checkBoxMostrarInicio.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMostrarInicio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMostrarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarInicio.Location = new System.Drawing.Point(24, 331);
            this.checkBoxMostrarInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMostrarInicio.Name = "checkBoxMostrarInicio";
            this.checkBoxMostrarInicio.Size = new System.Drawing.Size(377, 28);
            this.checkBoxMostrarInicio.TabIndex = 38;
            this.checkBoxMostrarInicio.Text = "Mostrar la ventana de bienvenida al inicio";
            this.toolTipGeneral.SetToolTip(this.checkBoxMostrarInicio, "Marca la opción para mostrar la ventana de bienvenida al inicio del programa.");
            this.checkBoxMostrarInicio.UseVisualStyleBackColor = false;
            // 
            // toolTipGeneral
            // 
            this.toolTipGeneral.AutomaticDelay = 700;
            this.toolTipGeneral.IsBalloon = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 444);
            this.Controls.Add(this.checkBoxMostrarInicio);
            this.Controls.Add(this.lblTituloExtra);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.lblTituloTema);
            this.Controls.Add(this.lblTituloInstalacion);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.tbDirectorioValue);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.lblDirectorioInstalacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox btnSeleccionarCarpeta;
        private System.Windows.Forms.Label lblDirectorioInstalacion;
        private System.Windows.Forms.TextBox tbDirectorioValue;
        private System.Windows.Forms.Label lblTema;
        public System.Windows.Forms.Label lblTituloInstalacion;
        public System.Windows.Forms.Label lblTituloTema;
        private System.Windows.Forms.ComboBox cbTema;
        public System.Windows.Forms.Label lblTituloExtra;
        private System.Windows.Forms.CheckBox checkBoxMostrarInicio;
        private System.Windows.Forms.ToolTip toolTipGeneral;
    }
}