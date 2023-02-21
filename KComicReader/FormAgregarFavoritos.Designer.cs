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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.Location = new System.Drawing.Point(144, 110);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(300, 28);
            this.tbTitulo.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 110);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Classic Comic Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.Location = new System.Drawing.Point(13, 9);
            this.lblTituloFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(431, 97);
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
            this.btnCancelar.Location = new System.Drawing.Point(332, 580);
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
            this.btnAgregar.Location = new System.Drawing.Point(207, 580);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 33);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblComic
            // 
            this.lblComic.BackColor = System.Drawing.Color.Transparent;
            this.lblComic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComic.Location = new System.Drawing.Point(18, 152);
            this.lblComic.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblComic.Name = "lblComic";
            this.lblComic.Size = new System.Drawing.Size(117, 32);
            this.lblComic.TabIndex = 18;
            this.lblComic.Text = "Cómic";
            this.lblComic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComicValue
            // 
            this.lblComicValue.BackColor = System.Drawing.Color.Transparent;
            this.lblComicValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComicValue.Location = new System.Drawing.Point(140, 152);
            this.lblComicValue.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.lblComicValue.Name = "lblComicValue";
            this.lblComicValue.Size = new System.Drawing.Size(304, 32);
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
            this.lblViñeta.Location = new System.Drawing.Point(18, 197);
            this.lblViñeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.lblViñeta.Name = "lblViñeta";
            this.lblViñeta.Size = new System.Drawing.Size(117, 32);
            this.lblViñeta.TabIndex = 20;
            this.lblViñeta.Text = "Viñeta";
            this.lblViñeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgregarFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 626);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "FormAgregarFavoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar viñeta a favoritos";
            this.Load += new System.EventHandler(this.FormAgregarSerie_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAgregarSerie_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}