
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(15, 11);
            this.lblTituloFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(643, 71);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "AGREGAR UN NUEVO CÓMIC";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.Color.Transparent;
            this.pbPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbPortada.Image")));
            this.pbPortada.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPortada.InitialImage")));
            this.pbPortada.Location = new System.Drawing.Point(468, 95);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(190, 287);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortada.TabIndex = 5;
            this.pbPortada.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(419, 410);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivo.Location = new System.Drawing.Point(147, 352);
            this.btnArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(247, 32);
            this.btnArchivo.TabIndex = 6;
            this.btnArchivo.Text = "Seleccionar archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.DockChanged += new System.EventHandler(this.btnArchivo_Click);
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // lblArchivo
            // 
            this.lblArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.Location = new System.Drawing.Point(21, 350);
            this.lblArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(117, 32);
            this.lblArchivo.TabIndex = 9;
            this.lblArchivo.Text = "Archivo";
            this.lblArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 95);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 32);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(147, 95);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(247, 28);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.TextChanged += new System.EventHandler(this.tbTitulo_TextChanged);
            // 
            // lblEditorial
            // 
            this.lblEditorial.BackColor = System.Drawing.Color.Transparent;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(21, 135);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(117, 32);
            this.lblEditorial.TabIndex = 13;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbGuionista
            // 
            this.tbGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuionista.Location = new System.Drawing.Point(147, 177);
            this.tbGuionista.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.tbGuionista.Name = "tbGuionista";
            this.tbGuionista.Size = new System.Drawing.Size(247, 28);
            this.tbGuionista.TabIndex = 3;
            // 
            // lblGuionista
            // 
            this.lblGuionista.BackColor = System.Drawing.Color.Transparent;
            this.lblGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuionista.Location = new System.Drawing.Point(21, 175);
            this.lblGuionista.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblGuionista.Name = "lblGuionista";
            this.lblGuionista.Size = new System.Drawing.Size(117, 32);
            this.lblGuionista.TabIndex = 15;
            this.lblGuionista.Text = "Guionista";
            this.lblGuionista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDibujante
            // 
            this.tbDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDibujante.Location = new System.Drawing.Point(147, 219);
            this.tbDibujante.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.tbDibujante.Name = "tbDibujante";
            this.tbDibujante.Size = new System.Drawing.Size(247, 28);
            this.tbDibujante.TabIndex = 4;
            // 
            // lblDibujante
            // 
            this.lblDibujante.BackColor = System.Drawing.Color.Transparent;
            this.lblDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDibujante.Location = new System.Drawing.Point(21, 215);
            this.lblDibujante.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblDibujante.Name = "lblDibujante";
            this.lblDibujante.Size = new System.Drawing.Size(117, 32);
            this.lblDibujante.TabIndex = 17;
            this.lblDibujante.Text = "Dibujante";
            this.lblDibujante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(544, 410);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbEditorial
            // 
            this.cbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Items.AddRange(new object[] {
            "Marvel Comics",
            "Detective Comics (DC)",
            "IDW Publishing",
            "Image Comics",
            "Dark Horse Comics",
            "Boom",
            "Norma Editorial"});
            this.cbEditorial.Location = new System.Drawing.Point(147, 135);
            this.cbEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(247, 30);
            this.cbEditorial.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 257);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(117, 32);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Sin asignar",
            "Superhéroes",
            "Manga",
            "Novela gráfica",
            "Humor",
            "Otros"});
            this.cbCategoria.Location = new System.Drawing.Point(147, 257);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(247, 30);
            this.cbCategoria.TabIndex = 5;
            this.cbCategoria.Text = "Sin asignar";
            // 
            // cbIdioma
            // 
            this.cbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "Afrikáans",
            "Árabe",
            "Bengalí",
            "Bielorruso",
            "Birmano",
            "Chino mandarín",
            "Coreano",
            "Croata",
            "Danes",
            "Español",
            "Estonio",
            "Feroés",
            "Finlandés",
            "Francés",
            "Griego",
            "Hindi",
            "Holandés",
            "Húngaro",
            "Indonesio",
            "Inglés",
            "Italiano",
            "Japonés",
            "Latvio",
            "Lituania",
            "Macedonio",
            "Malayo",
            "Noruego",
            "Polaco",
            "Portugués",
            "Ruso",
            "Sueco",
            "Tamil",
            "Turco",
            "Ucraniano",
            "Urdu",
            "Vietnamita",
            "Xhosa",
            "Yidis",
            "Zulú"});
            this.cbIdioma.Location = new System.Drawing.Point(147, 305);
            this.cbIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(247, 30);
            this.cbIdioma.TabIndex = 20;
            // 
            // lblIdioma
            // 
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(21, 305);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(117, 32);
            this.lblIdioma.TabIndex = 21;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAgregarComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 456);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAgregarComic";
            this.Text = "Agregar un nuevo cómic";
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Button btnAgregar;
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
    }
}