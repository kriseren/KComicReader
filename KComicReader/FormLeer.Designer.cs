namespace KComicReader
{
    partial class FormLeer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeer));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.PictureBox();
            this.lblNumPaginas = new System.Windows.Forms.Label();
            this.btnMarcador = new System.Windows.Forms.PictureBox();
            this.btnAnteriorPagina = new System.Windows.Forms.PictureBox();
            this.btnSiguientePagina = new System.Windows.Forms.PictureBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pbPagina = new System.Windows.Forms.PictureBox();
            this.toolTipGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMarcador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguientePagina)).BeginInit();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnZoom);
            this.panelButtons.Controls.Add(this.lblNumPaginas);
            this.panelButtons.Controls.Add(this.btnMarcador);
            this.panelButtons.Controls.Add(this.btnAnteriorPagina);
            this.panelButtons.Controls.Add(this.btnSiguientePagina);
            this.panelButtons.Location = new System.Drawing.Point(12, 716);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(555, 76);
            this.panelButtons.TabIndex = 12;
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
            // lblNumPaginas
            // 
            this.lblNumPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPaginas.Location = new System.Drawing.Point(169, 11);
            this.lblNumPaginas.Name = "lblNumPaginas";
            this.lblNumPaginas.Size = new System.Drawing.Size(217, 54);
            this.lblNumPaginas.TabIndex = 3;
            this.lblNumPaginas.Text = "Página 0 de 13";
            this.lblNumPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMarcador
            // 
            this.btnMarcador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarcador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcador.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcador.Image")));
            this.btnMarcador.Location = new System.Drawing.Point(399, 11);
            this.btnMarcador.Margin = new System.Windows.Forms.Padding(10);
            this.btnMarcador.Name = "btnMarcador";
            this.btnMarcador.Size = new System.Drawing.Size(63, 55);
            this.btnMarcador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMarcador.TabIndex = 2;
            this.btnMarcador.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.btnMarcador, "Haz click para marcar la página.");
            this.btnMarcador.Click += new System.EventHandler(this.BtnMarcador_Click);
            this.btnMarcador.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnMarcador.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnAnteriorPagina
            // 
            this.btnAnteriorPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnteriorPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnteriorPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnAnteriorPagina.Image")));
            this.btnAnteriorPagina.Location = new System.Drawing.Point(10, 10);
            this.btnAnteriorPagina.Margin = new System.Windows.Forms.Padding(10);
            this.btnAnteriorPagina.Name = "btnAnteriorPagina";
            this.btnAnteriorPagina.Size = new System.Drawing.Size(63, 55);
            this.btnAnteriorPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAnteriorPagina.TabIndex = 1;
            this.btnAnteriorPagina.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.btnAnteriorPagina, "Haz click para pasar a la página anterior.");
            this.btnAnteriorPagina.Click += new System.EventHandler(this.BtnAnterior_Click);
            this.btnAnteriorPagina.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnAnteriorPagina.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // btnSiguientePagina
            // 
            this.btnSiguientePagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguientePagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguientePagina.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguientePagina.Image")));
            this.btnSiguientePagina.Location = new System.Drawing.Point(482, 10);
            this.btnSiguientePagina.Margin = new System.Windows.Forms.Padding(10);
            this.btnSiguientePagina.Name = "btnSiguientePagina";
            this.btnSiguientePagina.Size = new System.Drawing.Size(63, 55);
            this.btnSiguientePagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSiguientePagina.TabIndex = 0;
            this.btnSiguientePagina.TabStop = false;
            this.toolTipGeneral.SetToolTip(this.btnSiguientePagina, "Haz click para pasar a la página siguiente.");
            this.btnSiguientePagina.Click += new System.EventHandler(this.BtnSiguiente_Click);
            this.btnSiguientePagina.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.btnSiguientePagina.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
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
            this.panelImage.Size = new System.Drawing.Size(555, 698);
            this.panelImage.TabIndex = 13;
            // 
            // pbPagina
            // 
            this.pbPagina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPagina.BackColor = System.Drawing.Color.Transparent;
            this.pbPagina.Image = ((System.Drawing.Image)(resources.GetObject("pbPagina.Image")));
            this.pbPagina.Location = new System.Drawing.Point(10, 3);
            this.pbPagina.Name = "pbPagina";
            this.pbPagina.Size = new System.Drawing.Size(535, 692);
            this.pbPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPagina.TabIndex = 0;
            this.pbPagina.TabStop = false;
            // 
            // toolTipGeneral
            // 
            this.toolTipGeneral.AutomaticDelay = 700;
            this.toolTipGeneral.IsBalloon = true;
            // 
            // FormLeer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 804);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLeer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLeer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLeer_FormClosed);
            this.Load += new System.EventHandler(this.FormLeer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLeer_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMarcador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnteriorPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguientePagina)).EndInit();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPagina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.PictureBox btnAnteriorPagina;
        private System.Windows.Forms.PictureBox btnSiguientePagina;
        private System.Windows.Forms.PictureBox btnMarcador;
        private System.Windows.Forms.Label lblNumPaginas;
        private System.Windows.Forms.PictureBox btnZoom;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.PictureBox pbPagina;
        private System.Windows.Forms.ToolTip toolTipGeneral;
    }
}