
namespace KComicReader
{
    partial class FormAgregarComic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarComic));
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.tbGuionista = new System.Windows.Forms.TextBox();
            this.lblGuionista = new System.Windows.Forms.Label();
            this.tbDibujante = new System.Windows.Forms.TextBox();
            this.lblDibujante = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.nbNumero = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarEditorial = new System.Windows.Forms.PictureBox();
            this.btnAgregarSerie = new System.Windows.Forms.PictureBox();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarSerie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Classic Comic Medium", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(11, 9);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(587, 58);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "AGREGAR UN NUEVO CÓMIC";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.Color.Transparent;
            this.pbPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbPortada.Image")));
            this.pbPortada.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPortada.InitialImage")));
            this.pbPortada.Location = new System.Drawing.Point(410, 68);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(189, 317);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortada.TabIndex = 5;
            this.pbPortada.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.pbPortada, "Haz doble click para seleccionar el archivo CBR del cómic.");
            this.pbPortada.DoubleClick += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(416, 414);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 27);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivo.Location = new System.Drawing.Point(110, 361);
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(185, 26);
            this.btnArchivo.TabIndex = 9;
            this.btnArchivo.Text = "Seleccionar archivo";
            this.toolTipGeneral.SetToolTip(this.btnArchivo, "Selecciona el archivo CBR del cómic.");
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.DockChanged += new System.EventHandler(this.BtnArchivo_Click);
            this.btnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(16, 359);
            this.lblArchivo.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(88, 26);
            this.lblArchivo.TabIndex = 9;
            this.lblArchivo.Tag = "Required";
            this.lblArchivo.Text = "Archivo";
            this.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 77);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 26);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Tag = "Required";
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(110, 77);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(213, 24);
            this.tbTitulo.TabIndex = 1;
            this.toolTipGeneral.SetToolTip(this.tbTitulo, "Escribe aquí el título del cómic.");
            // 
            // lblEditorial
            // 
            this.lblEditorial.BackColor = System.Drawing.Color.Transparent;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(16, 111);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(88, 26);
            this.lblEditorial.TabIndex = 13;
            this.lblEditorial.Tag = "Required";
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbGuionista
            // 
            this.tbGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuionista.Location = new System.Drawing.Point(110, 187);
            this.tbGuionista.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.tbGuionista.Name = "tbGuionista";
            this.tbGuionista.Size = new System.Drawing.Size(212, 24);
            this.tbGuionista.TabIndex = 4;
            this.toolTipGeneral.SetToolTip(this.tbGuionista, "Escribe aquí el/la guionista del cómic.");
            // 
            // lblGuionista
            // 
            this.lblGuionista.BackColor = System.Drawing.Color.Transparent;
            this.lblGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuionista.Location = new System.Drawing.Point(16, 185);
            this.lblGuionista.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblGuionista.Name = "lblGuionista";
            this.lblGuionista.Size = new System.Drawing.Size(88, 26);
            this.lblGuionista.TabIndex = 15;
            this.lblGuionista.Text = "Guionista";
            this.lblGuionista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDibujante
            // 
            this.tbDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDibujante.Location = new System.Drawing.Point(110, 221);
            this.tbDibujante.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.tbDibujante.Name = "tbDibujante";
            this.tbDibujante.Size = new System.Drawing.Size(212, 24);
            this.tbDibujante.TabIndex = 5;
            this.toolTipGeneral.SetToolTip(this.tbDibujante, "Escribe aquí el/la dibujante del cómic.");
            // 
            // lblDibujante
            // 
            this.lblDibujante.BackColor = System.Drawing.Color.Transparent;
            this.lblDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDibujante.Location = new System.Drawing.Point(16, 218);
            this.lblDibujante.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblDibujante.Name = "lblDibujante";
            this.lblDibujante.Size = new System.Drawing.Size(88, 26);
            this.lblDibujante.TabIndex = 17;
            this.lblDibujante.Text = "Dibujante";
            this.lblDibujante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(511, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbEditorial
            // 
            this.cbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Location = new System.Drawing.Point(110, 111);
            this.cbEditorial.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.cbEditorial.MaxDropDownItems = 20;
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(212, 25);
            this.cbEditorial.TabIndex = 2;
            this.toolTipGeneral.SetToolTip(this.cbEditorial, "Selecciona la editorial del cómic.");
            this.cbEditorial.SelectionChangeCommitted += new System.EventHandler(this.CbEditorial_SelectionChangeCommitted);
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(16, 255);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 26);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(110, 255);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.cbCategoria.MaxDropDownItems = 20;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(212, 25);
            this.cbCategoria.TabIndex = 6;
            this.toolTipGeneral.SetToolTip(this.cbCategoria, "Selecciona la categoría del cómic.");
            // 
            // cbIdioma
            // 
            this.cbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(110, 291);
            this.cbIdioma.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.cbIdioma.MaxDropDownItems = 20;
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(212, 25);
            this.cbIdioma.TabIndex = 7;
            this.toolTipGeneral.SetToolTip(this.cbIdioma, "Selecciona el idioma del cómic.");
            // 
            // lblIdioma
            // 
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(16, 291);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(88, 26);
            this.lblIdioma.TabIndex = 21;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Location = new System.Drawing.Point(110, 149);
            this.cbSerie.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.cbSerie.MaxDropDownItems = 20;
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(212, 25);
            this.cbSerie.TabIndex = 3;
            this.toolTipGeneral.SetToolTip(this.cbSerie, "Selecciona la serie del cómic asociada a la editorial.");
            // 
            // lblSerie
            // 
            this.lblSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(16, 149);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(88, 26);
            this.lblSerie.TabIndex = 23;
            this.lblSerie.Tag = "Required";
            this.lblSerie.Text = "Serie";
            this.lblSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(16, 324);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(88, 26);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Número";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nbNumero
            // 
            this.nbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbNumero.Location = new System.Drawing.Point(110, 327);
            this.nbNumero.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.nbNumero.Name = "nbNumero";
            this.nbNumero.Size = new System.Drawing.Size(60, 24);
            this.nbNumero.TabIndex = 8;
            this.toolTipGeneral.SetToolTip(this.nbNumero, "Define el número o tomo de la serie.");
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEditorial.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEditorial.Image")));
            this.btnAgregarEditorial.Location = new System.Drawing.Point(326, 111);
            this.btnAgregarEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Padding = new System.Windows.Forms.Padding(2);
            this.btnAgregarEditorial.Size = new System.Drawing.Size(22, 24);
            this.btnAgregarEditorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarEditorial.TabIndex = 26;
            this.btnAgregarEditorial.TabStop = false;
            this.btnAgregarEditorial.Tag = "Agregar Editorial";
            this.toolTipGeneral.SetToolTip(this.btnAgregarEditorial, "Haz click para agregar una nueva editorial.");
            this.btnAgregarEditorial.Click += new System.EventHandler(this.BtnAgregarEditorial_Click);
            this.btnAgregarEditorial.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnAgregarEditorial.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnAgregarSerie
            // 
            this.btnAgregarSerie.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSerie.Enabled = false;
            this.btnAgregarSerie.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarSerie.Image")));
            this.btnAgregarSerie.Location = new System.Drawing.Point(326, 149);
            this.btnAgregarSerie.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarSerie.Name = "btnAgregarSerie";
            this.btnAgregarSerie.Padding = new System.Windows.Forms.Padding(2);
            this.btnAgregarSerie.Size = new System.Drawing.Size(22, 24);
            this.btnAgregarSerie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarSerie.TabIndex = 27;
            this.btnAgregarSerie.TabStop = false;
            this.btnAgregarSerie.Tag = "Agregar Editorial";
            this.toolTipGeneral.SetToolTip(this.btnAgregarSerie, "Haz click para agregar una nueva serie.");
            this.btnAgregarSerie.Visible = false;
            this.btnAgregarSerie.Click += new System.EventHandler(this.BtnAgregarSerie_Click);
            this.btnAgregarSerie.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnAgregarSerie.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // toolTipGeneral
            // 
            this.toolTipGeneral.AutomaticDelay = 700;
            this.toolTipGeneral.IsBalloon = true;
            // 
            // FormAgregarComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 451);
            this.Controls.Add(this.btnAgregarSerie);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.nbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cbSerie);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbEditorial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbDibujante);
            this.Controls.Add(this.lblDibujante);
            this.Controls.Add(this.tbGuionista);
            this.Controls.Add(this.lblGuionista);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbPortada);
            this.Controls.Add(this.lblTituloFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgregarComic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar un nuevo cómic";
            this.Load += new System.EventHandler(this.FormAgregarComic_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAgregarComic_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarSerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox tbGuionista;
        private System.Windows.Forms.Label lblGuionista;
        private System.Windows.Forms.TextBox tbDibujante;
        private System.Windows.Forms.Label lblDibujante;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Label lblIdioma;
        public System.Windows.Forms.Label lblTituloFormulario;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.NumericUpDown nbNumero;
        private System.Windows.Forms.PictureBox btnAgregarEditorial;
        private System.Windows.Forms.PictureBox btnAgregarSerie;
        private System.Windows.Forms.ToolTip toolTipGeneral;
    }
}