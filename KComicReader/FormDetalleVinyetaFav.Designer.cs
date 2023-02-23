namespace KComicReader
{
    partial class FormDetalleVinyetaFav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleVinyetaFav));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pbBtnDescargar = new System.Windows.Forms.PictureBox();
            this.btnZoom = new System.Windows.Forms.PictureBox();
            this.lblTituloVinyeta = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbPagina = new System.Windows.Forms.PictureBox();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnDescargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.pbBtnDescargar);
            this.panelButtons.Controls.Add(this.btnZoom);
            this.panelButtons.Controls.Add(this.lblTituloVinyeta);
            this.panelButtons.Location = new System.Drawing.Point(-60, 667);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(555, 76);
            this.panelButtons.TabIndex = 12;
            // 
            // pbBtnDescargar
            // 
            this.pbBtnDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBtnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnDescargar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnDescargar.Image")));
            this.pbBtnDescargar.Location = new System.Drawing.Point(399, 10);
            this.pbBtnDescargar.Margin = new System.Windows.Forms.Padding(10);
            this.pbBtnDescargar.Name = "pbBtnDescargar";
            this.pbBtnDescargar.Size = new System.Drawing.Size(63, 55);
            this.pbBtnDescargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBtnDescargar.TabIndex = 5;
            this.pbBtnDescargar.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.pbBtnDescargar, "Haz click para descargar la viñeta.");
            this.pbBtnDescargar.Click += new System.EventHandler(this.pbBtnDescargar_Click);
            this.pbBtnDescargar.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.pbBtnDescargar.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnZoom
            // 
            this.btnZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.Location = new System.Drawing.Point(93, 10);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(10);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(63, 55);
            this.btnZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnZoom.TabIndex = 4;
            this.btnZoom.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.btnZoom, "Haz click para hacer zoom ajustado al ancho de la ventana..");
            this.btnZoom.Click += new System.EventHandler(this.Zoom_Click);
            this.btnZoom.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnZoom.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // lblTituloVinyeta
            // 
            this.lblTituloVinyeta.Font = new System.Drawing.Font("Classic Comic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVinyeta.Location = new System.Drawing.Point(169, 11);
            this.lblTituloVinyeta.Name = "lblTituloVinyeta";
            this.lblTituloVinyeta.Size = new System.Drawing.Size(217, 54);
            this.lblTituloVinyeta.TabIndex = 3;
            this.lblTituloVinyeta.Text = "Página 0 de 13";
            this.lblTituloVinyeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.AutoScroll = true;
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.Controls.Add(this.pbPagina);
            this.panelImage.Location = new System.Drawing.Point(12, 12);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(411, 649);
            this.panelImage.TabIndex = 13;
            // 
            // pbPagina
            // 
            this.pbPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPagina.BackColor = System.Drawing.Color.Transparent;
            this.pbPagina.Image = ((System.Drawing.Image)(resources.GetObject("pbPagina.Image")));
            this.pbPagina.Location = new System.Drawing.Point(7, 5);
            this.pbPagina.Name = "pbPagina";
            this.pbPagina.Size = new System.Drawing.Size(401, 641);
            this.pbPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPagina.TabIndex = 0;
            this.pbPagina.TabStop = false;
            // 
            // toolTipGeneral
            // 
            this.toolTipGeneral.AutomaticDelay = 700;
            this.toolTipGeneral.IsBalloon = true;
            // 
            // FormDetalleVinyetaFav
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 755);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDetalleVinyetaFav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vista detalle de la viñeta favorita";
            this.Load += new System.EventHandler(this.FormLeer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLeer_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnDescargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label lblTituloVinyeta;
        private System.Windows.Forms.PictureBox btnZoom;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbPagina;
        private System.Windows.Forms.ToolTip toolTipGeneral;
        private System.Windows.Forms.PictureBox pbBtnDescargar;
    }
}