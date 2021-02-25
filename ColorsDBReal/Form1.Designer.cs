namespace ColorsDBReal
{
    partial class Form1
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
            this.listColors = new System.Windows.Forms.Label();
            this.listcolor = new System.Windows.Forms.ListBox();
            this.listShades = new System.Windows.Forms.ListBox();
            this.Shades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listColors
            // 
            this.listColors.AutoSize = true;
            this.listColors.Location = new System.Drawing.Point(159, 55);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(36, 13);
            this.listColors.TabIndex = 0;
            this.listColors.Text = "Colors";
            // 
            // listcolor
            // 
            this.listcolor.FormattingEnabled = true;
            this.listcolor.Location = new System.Drawing.Point(122, 139);
            this.listcolor.Name = "listcolor";
            this.listcolor.Size = new System.Drawing.Size(129, 95);
            this.listcolor.TabIndex = 1;
            this.listcolor.SelectedIndexChanged += new System.EventHandler(this.listcolor_SelectedIndexChanged);
            // 
            // listShades
            // 
            this.listShades.FormattingEnabled = true;
            this.listShades.Location = new System.Drawing.Point(465, 137);
            this.listShades.Name = "listShades";
            this.listShades.Size = new System.Drawing.Size(139, 95);
            this.listShades.TabIndex = 2;
            // 
            // Shades
            // 
            this.Shades.AutoSize = true;
            this.Shades.Location = new System.Drawing.Point(501, 63);
            this.Shades.Name = "Shades";
            this.Shades.Size = new System.Drawing.Size(43, 13);
            this.Shades.TabIndex = 3;
            this.Shades.Text = "Shades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 907);
            this.Controls.Add(this.Shades);
            this.Controls.Add(this.listShades);
            this.Controls.Add(this.listcolor);
            this.Controls.Add(this.listColors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listColors;
        private System.Windows.Forms.ListBox listcolor;
        private System.Windows.Forms.ListBox listShades;
        private System.Windows.Forms.Label Shades;
    }
}

