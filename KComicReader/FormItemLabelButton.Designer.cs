
namespace KComicReader
{
    partial class FormItemLabelButton
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
            this.lblItem = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(4, 9);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(152, 22);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Etiqueta del item";
            this.lblItem.Click += new System.EventHandler(this.lblItem_Click);
            // 
            // btnItem
            // 
            this.btnItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItem.Location = new System.Drawing.Point(163, 4);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(166, 32);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Botón";
            this.btnItem.UseVisualStyleBackColor = true;
            // 
            // FormItemLabelButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.lblItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormItemLabelButton";
            this.Size = new System.Drawing.Size(332, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnItem;
    }
}
