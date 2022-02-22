namespace Tis.Solving.Chaos.WinExe
{
    partial class FWorld
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
            this.VWorld = new Tis.Solving.Chaos.GWorld();
            this.SuspendLayout();
            // 
            // VWorld
            // 
            this.VWorld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VWorld.Location = new System.Drawing.Point(0, 0);
            this.VWorld.Name = "VWorld";
            this.VWorld.Size = new System.Drawing.Size(800, 450);
            this.VWorld.TabIndex = 0;
            // 
            // FWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VWorld);
            this.Name = "FWorld";
            this.Text = "FWorld";
            this.ResumeLayout(false);

        }

        #endregion

        private GWorld gWorld1;
        private GWorld VWorld;
    }
}