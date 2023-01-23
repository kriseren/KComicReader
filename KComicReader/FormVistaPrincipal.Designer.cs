
namespace KComicReader
{
    partial class FormVistaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrincipal));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pbBtnAgregar = new System.Windows.Forms.PictureBox();
            this.fwpComics = new System.Windows.Forms.FlowLayoutPanel();
            this.twFolder = new System.Windows.Forms.TreeView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblPanelTopTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelRightVacia = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelRightInfo = new System.Windows.Forms.Panel();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.lblInfoGuionista = new System.Windows.Forms.Label();
            this.lblInfoGuionistaValue = new System.Windows.Forms.Label();
            this.lblInfoDibujanteValue = new System.Windows.Forms.Label();
            this.lblInfoDibujante = new System.Windows.Forms.Label();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblInfoTituloValue = new System.Windows.Forms.Label();
            this.lblInfoEditorialValue = new System.Windows.Forms.Label();
            this.lblInfoEditorial = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelRightVacia.SuspendLayout();
            this.panelRightInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Location = new System.Drawing.Point(16, 15);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1366, 52);
            this.panelTop.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.pbBtnAgregar);
            this.panelCenter.Controls.Add(this.fwpComics);
            this.panelCenter.Location = new System.Drawing.Point(227, 84);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(894, 609);
            this.panelCenter.TabIndex = 1;
            // 
            // pbBtnAgregar
            // 
            this.pbBtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnAgregar.Image")));
            this.pbBtnAgregar.Location = new System.Drawing.Point(827, 4);
            this.pbBtnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBtnAgregar.Name = "pbBtnAgregar";
            this.pbBtnAgregar.Size = new System.Drawing.Size(60, 60);
            this.pbBtnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnAgregar.TabIndex = 1;
            this.pbBtnAgregar.TabStop = false;
            this.pbBtnAgregar.Click += new System.EventHandler(this.pbBtnAgregar_Click);
            // 
            // fwpComics
            // 
            this.fwpComics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fwpComics.AutoScroll = true;
            this.fwpComics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fwpComics.BackColor = System.Drawing.Color.White;
            this.fwpComics.Location = new System.Drawing.Point(4, 4);
            this.fwpComics.Margin = new System.Windows.Forms.Padding(4);
            this.fwpComics.Name = "fwpComics";
            this.fwpComics.Size = new System.Drawing.Size(815, 599);
            this.fwpComics.TabIndex = 0;
            // 
            // twFolder
            // 
            this.twFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.twFolder.Location = new System.Drawing.Point(4, 38);
            this.twFolder.Margin = new System.Windows.Forms.Padding(4);
            this.twFolder.Name = "twFolder";
            this.twFolder.Size = new System.Drawing.Size(183, 564);
            this.twFolder.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblPanelTopTitle);
            this.panelLeft.Controls.Add(this.twFolder);
            this.panelLeft.Location = new System.Drawing.Point(16, 84);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(193, 609);
            this.panelLeft.TabIndex = 1;
            // 
            // lblPanelTopTitle
            // 
            this.lblPanelTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblPanelTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTopTitle.Location = new System.Drawing.Point(5, 4);
            this.lblPanelTopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanelTopTitle.Name = "lblPanelTopTitle";
            this.lblPanelTopTitle.Size = new System.Drawing.Size(181, 31);
            this.lblPanelTopTitle.TabIndex = 0;
            this.lblPanelTopTitle.Text = "MIS SERIES";
            this.lblPanelTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panelRightInfo);
            this.panelRight.Controls.Add(this.lblTitulo);
            this.panelRight.Controls.Add(this.panelRightVacia);
            this.panelRight.Location = new System.Drawing.Point(1139, 84);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(243, 609);
            this.panelRight.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INFORMACIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRightVacia
            // 
            this.panelRightVacia.Controls.Add(this.lblInfo);
            this.panelRightVacia.Location = new System.Drawing.Point(4, 38);
            this.panelRightVacia.Name = "panelRightVacia";
            this.panelRightVacia.Size = new System.Drawing.Size(243, 570);
            this.panelRightVacia.TabIndex = 11;
            this.panelRightVacia.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(227, 186);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Aquí se mostrará la información de los cómics que selecciones.\r\n";
            // 
            // panelRightInfo
            // 
            this.panelRightInfo.Controls.Add(this.btnLeer);
            this.panelRightInfo.Controls.Add(this.lblAcciones);
            this.panelRightInfo.Controls.Add(this.lblInfoGuionista);
            this.panelRightInfo.Controls.Add(this.lblInfoGuionistaValue);
            this.panelRightInfo.Controls.Add(this.lblInfoDibujanteValue);
            this.panelRightInfo.Controls.Add(this.lblInfoDibujante);
            this.panelRightInfo.Controls.Add(this.lblInfoTitulo);
            this.panelRightInfo.Controls.Add(this.lblInfoTituloValue);
            this.panelRightInfo.Controls.Add(this.lblInfoEditorialValue);
            this.panelRightInfo.Controls.Add(this.lblInfoEditorial);
            this.panelRightInfo.Location = new System.Drawing.Point(-1, 38);
            this.panelRightInfo.Name = "panelRightInfo";
            this.panelRightInfo.Size = new System.Drawing.Size(243, 563);
            this.panelRightInfo.TabIndex = 1;
            // 
            // lblAcciones
            // 
            this.lblAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.Location = new System.Drawing.Point(5, 303);
            this.lblAcciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(233, 31);
            this.lblAcciones.TabIndex = 19;
            this.lblAcciones.Text = "ACCIONES";
            this.lblAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoGuionista
            // 
            this.lblInfoGuionista.AutoEllipsis = true;
            this.lblInfoGuionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoGuionista.Location = new System.Drawing.Point(-3, 158);
            this.lblInfoGuionista.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfoGuionista.Name = "lblInfoGuionista";
            this.lblInfoGuionista.Size = new System.Drawing.Size(235, 27);
            this.lblInfoGuionista.TabIndex = 18;
            this.lblInfoGuionista.Text = "[GUIONISTA]";
            this.lblInfoGuionista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoGuionistaValue
            // 
            this.lblInfoGuionistaValue.AutoEllipsis = true;
            this.lblInfoGuionistaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoGuionistaValue.Location = new System.Drawing.Point(-3, 190);
            this.lblInfoGuionistaValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblInfoGuionistaValue.Name = "lblInfoGuionistaValue";
            this.lblInfoGuionistaValue.Size = new System.Drawing.Size(235, 27);
            this.lblInfoGuionistaValue.TabIndex = 17;
            this.lblInfoGuionistaValue.Text = "El viejo Logan";
            this.lblInfoGuionistaValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoDibujanteValue
            // 
            this.lblInfoDibujanteValue.AutoEllipsis = true;
            this.lblInfoDibujanteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDibujanteValue.Location = new System.Drawing.Point(-3, 264);
            this.lblInfoDibujanteValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblInfoDibujanteValue.Name = "lblInfoDibujanteValue";
            this.lblInfoDibujanteValue.Size = new System.Drawing.Size(235, 27);
            this.lblInfoDibujanteValue.TabIndex = 16;
            this.lblInfoDibujanteValue.Text = "Marvel Cómics";
            this.lblInfoDibujanteValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoDibujante
            // 
            this.lblInfoDibujante.AutoEllipsis = true;
            this.lblInfoDibujante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDibujante.Location = new System.Drawing.Point(-3, 232);
            this.lblInfoDibujante.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfoDibujante.Name = "lblInfoDibujante";
            this.lblInfoDibujante.Size = new System.Drawing.Size(235, 27);
            this.lblInfoDibujante.TabIndex = 15;
            this.lblInfoDibujante.Text = "[DIBUJANTE]";
            this.lblInfoDibujante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoTitulo
            // 
            this.lblInfoTitulo.AutoEllipsis = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitulo.Location = new System.Drawing.Point(-2, 10);
            this.lblInfoTitulo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(235, 27);
            this.lblInfoTitulo.TabIndex = 14;
            this.lblInfoTitulo.Text = "[TÍTULO]";
            this.lblInfoTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoTituloValue
            // 
            this.lblInfoTituloValue.AutoEllipsis = true;
            this.lblInfoTituloValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTituloValue.Location = new System.Drawing.Point(-3, 42);
            this.lblInfoTituloValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblInfoTituloValue.Name = "lblInfoTituloValue";
            this.lblInfoTituloValue.Size = new System.Drawing.Size(235, 27);
            this.lblInfoTituloValue.TabIndex = 13;
            this.lblInfoTituloValue.Text = "El viejo Logan";
            this.lblInfoTituloValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoEditorialValue
            // 
            this.lblInfoEditorialValue.AutoEllipsis = true;
            this.lblInfoEditorialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEditorialValue.Location = new System.Drawing.Point(-3, 116);
            this.lblInfoEditorialValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblInfoEditorialValue.Name = "lblInfoEditorialValue";
            this.lblInfoEditorialValue.Size = new System.Drawing.Size(235, 27);
            this.lblInfoEditorialValue.TabIndex = 12;
            this.lblInfoEditorialValue.Text = "Marvel Cómics";
            this.lblInfoEditorialValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInfoEditorial
            // 
            this.lblInfoEditorial.AutoEllipsis = true;
            this.lblInfoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEditorial.Location = new System.Drawing.Point(-2, 84);
            this.lblInfoEditorial.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblInfoEditorial.Name = "lblInfoEditorial";
            this.lblInfoEditorial.Size = new System.Drawing.Size(235, 27);
            this.lblInfoEditorial.TabIndex = 11;
            this.lblInfoEditorial.Text = "[EDITORIAL]";
            this.lblInfoEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(5, 346);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(233, 35);
            this.btnLeer.TabIndex = 20;
            this.btnLeer.Text = "Leer cómic";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // FormVistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1399, 708);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVistaPrincipal";
            this.Text = "KComicReader";
            this.Load += new System.EventHandler(this.FormVistaPrincipal_Load);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRightVacia.ResumeLayout(false);
            this.panelRightInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TreeView twFolder;
        private System.Windows.Forms.FlowLayoutPanel fwpComics;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblPanelTopTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbBtnAgregar;
        private System.Windows.Forms.Panel panelRightVacia;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelRightInfo;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Label lblInfoGuionista;
        private System.Windows.Forms.Label lblInfoGuionistaValue;
        private System.Windows.Forms.Label lblInfoDibujanteValue;
        private System.Windows.Forms.Label lblInfoDibujante;
        private System.Windows.Forms.Label lblInfoTitulo;
        private System.Windows.Forms.Label lblInfoTituloValue;
        private System.Windows.Forms.Label lblInfoEditorialValue;
        private System.Windows.Forms.Label lblInfoEditorial;
        private System.Windows.Forms.Button btnLeer;
    }
}

