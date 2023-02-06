
namespace KComicReader
{
    partial class FormBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenida));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblBienvenidaTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelPag1 = new System.Windows.Forms.Panel();
            this.lblContenido = new System.Windows.Forms.Label();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.checkBoxMostrarInicio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelPag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(16, 100);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(364, 392);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblBienvenidaTitulo
            // 
            this.lblBienvenidaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidaTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaTitulo.Location = new System.Drawing.Point(16, 15);
            this.lblBienvenidaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenidaTitulo.Name = "lblBienvenidaTitulo";
            this.lblBienvenidaTitulo.Size = new System.Drawing.Size(1027, 70);
            this.lblBienvenidaTitulo.TabIndex = 1;
            this.lblBienvenidaTitulo.Text = "¡Bienvenidx a KComicReader!";
            this.lblBienvenidaTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(926, 517);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(117, 33);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelPag1
            // 
            this.panelPag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPag1.Controls.Add(this.pbWelcome);
            this.panelPag1.Controls.Add(this.lblContenido);
            this.panelPag1.Location = new System.Drawing.Point(387, 100);
            this.panelPag1.Name = "panelPag1";
            this.panelPag1.Size = new System.Drawing.Size(656, 392);
            this.panelPag1.TabIndex = 15;
            // 
            // lblContenido
            // 
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(4, 4);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(647, 183);
            this.lblContenido.TabIndex = 0;
            this.lblContenido.Text = resources.GetString("lblContenido.Text");
            // 
            // pbWelcome
            // 
            this.pbWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pbWelcome.Image")));
            this.pbWelcome.Location = new System.Drawing.Point(9, 202);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(219, 180);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcome.TabIndex = 1;
            this.pbWelcome.TabStop = false;
            // 
            // checkBoxMostrarInicio
            // 
            this.checkBoxMostrarInicio.AutoSize = true;
            this.checkBoxMostrarInicio.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMostrarInicio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMostrarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarInicio.Location = new System.Drawing.Point(16, 517);
            this.checkBoxMostrarInicio.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.checkBoxMostrarInicio.Name = "checkBoxMostrarInicio";
            this.checkBoxMostrarInicio.Size = new System.Drawing.Size(377, 28);
            this.checkBoxMostrarInicio.TabIndex = 39;
            this.checkBoxMostrarInicio.Text = "Mostrar la ventana de bienvenida al inicio";
            this.checkBoxMostrarInicio.UseVisualStyleBackColor = false;
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 563);
            this.Controls.Add(this.checkBoxMostrarInicio);
            this.Controls.Add(this.lblBienvenidaTitulo);
            this.Controls.Add(this.panelPag1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida a KComicReader";
            this.Load += new System.EventHandler(this.FormBienvenida_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBienvenida_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelPag1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblBienvenidaTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelPag1;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.PictureBox pbWelcome;
        private System.Windows.Forms.CheckBox checkBoxMostrarInicio;
    }
}