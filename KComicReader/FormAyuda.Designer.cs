namespace KComicReader
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.lblBienvenidaTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panelLeftApartados = new System.Windows.Forms.Panel();
            this.lbCategorias = new System.Windows.Forms.ListBox();
            this.lblSpecApartados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panelLeftApartados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenidaTitulo
            // 
            this.lblBienvenidaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenidaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidaTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaTitulo.Location = new System.Drawing.Point(10, 7);
            this.lblBienvenidaTitulo.Name = "lblBienvenidaTitulo";
            this.lblBienvenidaTitulo.Size = new System.Drawing.Size(836, 57);
            this.lblBienvenidaTitulo.TabIndex = 41;
            this.lblBienvenidaTitulo.Text = "CENTRO DE AYUDA";
            this.lblBienvenidaTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Controls.Add(this.lblContenido);
            this.panelContenido.Location = new System.Drawing.Point(175, 76);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(672, 413);
            this.panelContenido.TabIndex = 43;
            // 
            // lblContenido
            // 
            this.lblContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(5, 3);
            this.lblContenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(662, 408);
            this.lblContenido.TabIndex = 0;
            this.lblContenido.Text = resources.GetString("lblContenido.Text");
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(758, 499);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 27);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(3, 3);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(152, 155);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 40;
            this.pbImg.TabStop = false;
            // 
            // panelLeftApartados
            // 
            this.panelLeftApartados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeftApartados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelLeftApartados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftApartados.Controls.Add(this.lbCategorias);
            this.panelLeftApartados.Controls.Add(this.lblSpecApartados);
            this.panelLeftApartados.Location = new System.Drawing.Point(10, 246);
            this.panelLeftApartados.Name = "panelLeftApartados";
            this.panelLeftApartados.Size = new System.Drawing.Size(160, 242);
            this.panelLeftApartados.TabIndex = 44;
            // 
            // lbCategorias
            // 
            this.lbCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCategorias.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.FormattingEnabled = true;
            this.lbCategorias.HorizontalExtent = 20;
            this.lbCategorias.HorizontalScrollbar = true;
            this.lbCategorias.ItemHeight = 16;
            this.lbCategorias.Items.AddRange(new object[] {
            "Agregar un nuevo cómic",
            "Ajustes",
            "Atajos de teclado",
            "Editar un cómic",
            "Eliminar un cómic",
            "Leer un cómic"});
            this.lbCategorias.Location = new System.Drawing.Point(3, 32);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(153, 196);
            this.lbCategorias.Sorted = true;
            this.lbCategorias.TabIndex = 4;
            // 
            // lblSpecApartados
            // 
            this.lblSpecApartados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblSpecApartados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpecApartados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecApartados.Location = new System.Drawing.Point(3, 3);
            this.lblSpecApartados.Name = "lblSpecApartados";
            this.lblSpecApartados.Size = new System.Drawing.Size(153, 26);
            this.lblSpecApartados.TabIndex = 0;
            this.lblSpecApartados.Text = "APARTADOS";
            this.lblSpecApartados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Location = new System.Drawing.Point(10, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 164);
            this.panel1.TabIndex = 45;
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeftApartados);
            this.Controls.Add(this.lblBienvenidaTitulo);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAyuda";
            this.Text = "Ayuda de KComicReader";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormAyuda_Paint);
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panelLeftApartados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBienvenidaTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Panel panelLeftApartados;
        private System.Windows.Forms.ListBox lbCategorias;
        private System.Windows.Forms.Label lblSpecApartados;
        private System.Windows.Forms.Panel panel1;
    }
}