namespace KComicReader
{
    partial class FormFavoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFavoritos));
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.dtgVinyetas = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVinyetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            resources.ApplyResources(this.lblTituloFormulario, "lblTituloFormulario");
            this.lblTituloFormulario.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            // 
            // dtgVinyetas
            // 
            resources.ApplyResources(this.dtgVinyetas, "dtgVinyetas");
            this.dtgVinyetas.AllowUserToAddRows = false;
            this.dtgVinyetas.AllowUserToOrderColumns = true;
            this.dtgVinyetas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgVinyetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVinyetas.Name = "dtgVinyetas";
            this.dtgVinyetas.ReadOnly = true;
            this.dtgVinyetas.RowTemplate.Height = 80;
            this.dtgVinyetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgVinyetas_CellContentClick);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormFavoritos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtgVinyetas);
            this.Controls.Add(this.lblTituloFormulario);
            this.Name = "FormFavoritos";
            this.Load += new System.EventHandler(this.FormFavoritos_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormFavoritos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVinyetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.DataGridView dtgVinyetas;
        private System.Windows.Forms.Button btnCerrar;
    }
}