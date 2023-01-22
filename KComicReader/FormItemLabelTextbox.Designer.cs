
namespace KComicReader
{
    partial class FormItemLabelTextbox
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
            this.tbItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(4, 9);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(149, 24);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Etiqueta del item";
            // 
            // tbItem
            // 
            this.tbItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItem.Location = new System.Drawing.Point(164, 5);
            this.tbItem.Margin = new System.Windows.Forms.Padding(4);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(161, 28);
            this.tbItem.TabIndex = 1;
            // 
            // FormItemLabelTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.lblItem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormItemLabelTextbox";
            this.Size = new System.Drawing.Size(332, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox tbItem;
    }
}
