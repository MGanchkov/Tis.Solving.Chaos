namespace Tis.Solving.Chaos.WinExe
{
    partial class FFeigenbaum
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
            this.gFeigenbaum1 = new Tis.Solving.Chaos.GFeigenbaum();
            this.SuspendLayout();
            // 
            // gFeigenbaum1
            // 
            this.gFeigenbaum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gFeigenbaum1.Location = new System.Drawing.Point(0, 0);
            this.gFeigenbaum1.Name = "gFeigenbaum1";
            this.gFeigenbaum1.Size = new System.Drawing.Size(800, 450);
            this.gFeigenbaum1.TabIndex = 0;
            // 
            // FFeigenbaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gFeigenbaum1);
            this.Name = "FFeigenbaum";
            this.Text = "FFeigenbaum";
            this.ResumeLayout(false);

        }

        #endregion

        private GFeigenbaum gFeigenbaum1;
    }
}