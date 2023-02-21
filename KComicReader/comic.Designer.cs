
namespace KComicReader
{
    partial class Comic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comic));
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.Image = ((System.Drawing.Image)(resources.GetObject("pbPortada.Image")));
            this.pbPortada.Location = new System.Drawing.Point(8, 4);
            this.pbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(187, 283);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            this.pbPortada.Click += new System.EventHandler(this.Control_Click);
            this.pbPortada.DoubleClick += new System.EventHandler(this.Control_DobleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 290);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblTitulo.Size = new System.Drawing.Size(187, 75);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Click += new System.EventHandler(this.Control_Click);
            this.lblTitulo.DoubleClick += new System.EventHandler(this.Control_DobleClick);
            // 
            // Comic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbPortada);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comic";
            this.Size = new System.Drawing.Size(204, 346);
            this.DoubleClick += new System.EventHandler(this.Control_DobleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label lblTitulo;
    }
}
