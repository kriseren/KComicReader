
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblInfoTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelInfo.SuspendLayout();
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
            this.pbBtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbBtnAgregar.Image")));
            this.pbBtnAgregar.Location = new System.Drawing.Point(826, 4);
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
            this.twFolder.Size = new System.Drawing.Size(182, 564);
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
            this.panelRight.Controls.Add(this.panelInfo);
            this.panelRight.Controls.Add(this.lblTitulo);
            this.panelRight.Location = new System.Drawing.Point(1139, 84);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(243, 609);
            this.panelRight.TabIndex = 3;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblInfoTitulo);
            this.panelInfo.Location = new System.Drawing.Point(4, 39);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(233, 564);
            this.panelInfo.TabIndex = 1;
            // 
            // lblInfoTitulo
            // 
            this.lblInfoTitulo.AutoEllipsis = true;
            this.lblInfoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblInfoTitulo.Name = "lblInfoTitulo";
            this.lblInfoTitulo.Size = new System.Drawing.Size(227, 74);
            this.lblInfoTitulo.TabIndex = 0;
            this.lblInfoTitulo.Text = "Aquí se mostrarán la información de tus cómics.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INFORMACIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBtnAgregar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblInfoTitulo;
    }
}

