namespace Tis.Solving.Chaos.WinExe
{
    partial class FLorenz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VLorenz = new Tis.Solving.Chaos.GLorenz();
            this.SuspendLayout();
            // 
            // VLorenz
            // 
            this.VLorenz.Location = new System.Drawing.Point(0, 0);
            this.VLorenz.Margin = new System.Windows.Forms.Padding(0);
            this.VLorenz.Name = "VLorenz";
            this.VLorenz.Size = new System.Drawing.Size(800, 600);
            this.VLorenz.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.VLorenz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private GLorenz VLorenz;
    }
}