namespace KComicReader
{
    partial class FormAgregarFavoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarFavoritos));
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblComic = new System.Windows.Forms.Label();
            this.lblComicValue = new System.Windows.Forms.Label();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.lblViñeta = new System.Windows.Forms.Label();
            this.pbVinyeta = new System.Windows.Forms.PictureBox();
            this.lblNumPaginaValue = new System.Windows.Forms.Label();
            this.lblNumPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVinyeta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(108, 89);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(229, 24);
            this.tbTitulo.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 89);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 26);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Classic Comic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(10, 7);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(323, 79);
            this.lblTituloFormulario.TabIndex = 12;
            this.lblTituloFormulario.Text = "AGREGAR VIÑETA A FAVORITOS";
            this.lblTituloFormulario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(249, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
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
            this.btnAgregar.Location = new System.Drawing.Point(155, 471);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 27);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblComic
            // 
            this.lblComic.BackColor = System.Drawing.Color.Transparent;
            this.lblComic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComic.Location = new System.Drawing.Point(14, 124);
            this.lblComic.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblComic.Name = "lblComic";
            this.lblComic.Size = new System.Drawing.Size(88, 26);
            this.lblComic.TabIndex = 18;
            this.lblComic.Text = "Cómic";
            this.lblComic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComicValue
            // 
            this.lblComicValue.BackColor = System.Drawing.Color.Transparent;
            this.lblComicValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComicValue.Location = new System.Drawing.Point(105, 124);
            this.lblComicValue.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblComicValue.Name = "lblComicValue";
            this.lblComicValue.Size = new System.Drawing.Size(228, 26);
            this.lblComicValue.TabIndex = 19;
            this.lblComicValue.Text = "Editorial";
            this.lblComicValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipGeneral
            // 
            this.toolTipGeneral.AutomaticDelay = 700;
            this.toolTipGeneral.IsBalloon = true;
            // 
            // lblViñeta
            // 
            this.lblViñeta.BackColor = System.Drawing.Color.Transparent;
            this.lblViñeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViñeta.Location = new System.Drawing.Point(14, 160);
            this.lblViñeta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.lblViñeta.Name = "lblViñeta";
            this.lblViñeta.Size = new System.Drawing.Size(88, 26);
            this.lblViñeta.TabIndex = 20;
            this.lblViñeta.Text = "Viñeta";
            this.lblViñeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbVinyeta
            // 
            this.pbVinyeta.BackColor = System.Drawing.Color.Transparent;
            this.pbVinyeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVinyeta.Location = new System.Drawing.Point(16, 190);
            this.pbVinyeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVinyeta.Name = "pbVinyeta";
            this.pbVinyeta.Size = new System.Drawing.Size(178, 267);
            this.pbVinyeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVinyeta.TabIndex = 21;
            this.pbVinyeta.TabStop = false;
            // 
            // lblNumPaginaValue
            // 
            this.lblNumPaginaValue.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPaginaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPaginaValue.Location = new System.Drawing.Point(269, 162);
            this.lblNumPaginaValue.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblNumPaginaValue.Name = "lblNumPaginaValue";
            this.lblNumPaginaValue.Size = new System.Drawing.Size(68, 26);
            this.lblNumPaginaValue.TabIndex = 23;
            this.lblNumPaginaValue.Text = "Editorial";
            this.lblNumPaginaValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumPagina
            // 
            this.lblNumPagina.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPagina.Location = new System.Drawing.Point(198, 162);
            this.lblNumPagina.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.lblNumPagina.Name = "lblNumPagina";
            this.lblNumPagina.Size = new System.Drawing.Size(67, 26);
            this.lblNumPagina.TabIndex = 22;
            this.lblNumPagina.Text = "Nº Pag:";
            this.lblNumPagina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAgregarFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(346, 509);
            this.Controls.Add(this.lblNumPaginaValue);
            this.Controls.Add(this.lblNumPagina);
            this.Controls.Add(this.pbVinyeta);
            this.Controls.Add(this.lblViñeta);
            this.Controls.Add(this.lblComicValue);
            this.Controls.Add(this.lblComic);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTituloFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAgregarFavoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar viñeta a favoritos";
            this.Load += new System.EventHandler(this.FormAgregarSerie_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAgregarSerie_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbVinyeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblComic;
        private System.Windows.Forms.Label lblComicValue;
        private System.Windows.Forms.ToolTip toolTipGeneral;
        private System.Windows.Forms.Label lblViñeta;
        private System.Windows.Forms.PictureBox pbVinyeta;
        private System.Windows.Forms.Label lblNumPaginaValue;
        private System.Windows.Forms.Label lblNumPagina;
    }
}