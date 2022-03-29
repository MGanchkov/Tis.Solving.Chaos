namespace Tis.Solving.Chaos
{
    partial class GFeigenbaum
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VProperty = new System.Windows.Forms.GroupBox();
            this.B3D = new System.Windows.Forms.Button();
            this.G2 = new System.Windows.Forms.GroupBox();
            this.Ldρ = new System.Windows.Forms.Label();
            this.LdX0 = new System.Windows.Forms.Label();
            this.dρ = new Tis.Controls.GCustomTrackbar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dX0 = new Tis.Controls.GCustomTrackbar();
            this.G1 = new System.Windows.Forms.GroupBox();
            this.X0 = new Tis.Controls.GCustomTrackbar();
            this.label1 = new System.Windows.Forms.Label();
            this.ρ = new Tis.Controls.GCustomTrackbar();
            this.Lρ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LX0 = new System.Windows.Forms.Label();
            this.GTSwitch001 = new Tis.Controls.GToggleSwitch();
            this.Время = new System.Windows.Forms.Timer(this.components);
            this.VProperty.SuspendLayout();
            this.G2.SuspendLayout();
            this.G1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VProperty
            // 
            this.VProperty.Controls.Add(this.B3D);
            this.VProperty.Controls.Add(this.G2);
            this.VProperty.Controls.Add(this.G1);
            this.VProperty.Controls.Add(this.GTSwitch001);
            this.VProperty.Location = new System.Drawing.Point(241, 3);
            this.VProperty.Name = "VProperty";
            this.VProperty.Size = new System.Drawing.Size(660, 90);
            this.VProperty.TabIndex = 0;
            this.VProperty.TabStop = false;
            // 
            // B3D
            // 
            this.B3D.Location = new System.Drawing.Point(585, 1);
            this.B3D.Name = "B3D";
            this.B3D.Size = new System.Drawing.Size(75, 38);
            this.B3D.TabIndex = 7;
            this.B3D.Text = "3D";
            this.B3D.UseVisualStyleBackColor = true;
            this.B3D.Click += new System.EventHandler(this.B3D_Click);
            // 
            // G2
            // 
            this.G2.Controls.Add(this.Ldρ);
            this.G2.Controls.Add(this.LdX0);
            this.G2.Controls.Add(this.dρ);
            this.G2.Controls.Add(this.label6);
            this.G2.Controls.Add(this.label5);
            this.G2.Controls.Add(this.dX0);
            this.G2.Location = new System.Drawing.Point(330, 22);
            this.G2.Margin = new System.Windows.Forms.Padding(0);
            this.G2.Name = "G2";
            this.G2.Padding = new System.Windows.Forms.Padding(0);
            this.G2.Size = new System.Drawing.Size(330, 68);
            this.G2.TabIndex = 9;
            this.G2.TabStop = false;
            this.G2.Text = "Диапазон";
            // 
            // Ldρ
            // 
            this.Ldρ.AutoSize = true;
            this.Ldρ.Location = new System.Drawing.Point(279, 41);
            this.Ldρ.Name = "Ldρ";
            this.Ldρ.Size = new System.Drawing.Size(22, 15);
            this.Ldρ.TabIndex = 7;
            this.Ldρ.Text = "3,5";
            // 
            // LdX0
            // 
            this.LdX0.AutoSize = true;
            this.LdX0.Location = new System.Drawing.Point(279, 20);
            this.LdX0.Name = "LdX0";
            this.LdX0.Size = new System.Drawing.Size(22, 15);
            this.LdX0.TabIndex = 6;
            this.LdX0.Text = "0,5";
            // 
            // dρ
            // 
            this.dρ.BackColor = System.Drawing.Color.Transparent;
            this.dρ.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.dρ.DefaultValue = 50D;
            this.dρ.LargeChange = 5D;
            this.dρ.Location = new System.Drawing.Point(83, 41);
            this.dρ.Maximum = 500D;
            this.dρ.Minimum = 0D;
            this.dρ.Name = "dρ";
            this.dρ.Size = new System.Drawing.Size(190, 15);
            this.dρ.SmallChange = 1D;
            this.dρ.TabIndex = 4;
            this.dρ.Text = "gCustomTrackbar4";
            this.dρ.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.dρ.Value = 0D;
            this.dρ.ValueChanged += new System.EventHandler(this.dρ_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "delta ρ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delta Start X:";
            // 
            // dX0
            // 
            this.dX0.BackColor = System.Drawing.Color.Transparent;
            this.dX0.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.dX0.DefaultValue = 50D;
            this.dX0.LargeChange = 5D;
            this.dX0.Location = new System.Drawing.Point(83, 20);
            this.dX0.Maximum = 100D;
            this.dX0.Minimum = 0D;
            this.dX0.Name = "dX0";
            this.dX0.Size = new System.Drawing.Size(190, 15);
            this.dX0.SmallChange = 1D;
            this.dX0.TabIndex = 0;
            this.dX0.Text = "gCustomTrackbar3";
            this.dX0.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.dX0.Value = 0D;
            this.dX0.ValueChanged += new System.EventHandler(this.dX0_ValueChanged);
            // 
            // G1
            // 
            this.G1.Controls.Add(this.X0);
            this.G1.Controls.Add(this.label1);
            this.G1.Controls.Add(this.ρ);
            this.G1.Controls.Add(this.Lρ);
            this.G1.Controls.Add(this.label2);
            this.G1.Controls.Add(this.LX0);
            this.G1.Location = new System.Drawing.Point(0, 22);
            this.G1.Margin = new System.Windows.Forms.Padding(0);
            this.G1.Name = "G1";
            this.G1.Padding = new System.Windows.Forms.Padding(0);
            this.G1.Size = new System.Drawing.Size(330, 68);
            this.G1.TabIndex = 8;
            this.G1.TabStop = false;
            this.G1.Text = "Одиночное";
            // 
            // X0
            // 
            this.X0.BackColor = System.Drawing.Color.Transparent;
            this.X0.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.X0.DefaultValue = 50D;
            this.X0.LargeChange = 5D;
            this.X0.Location = new System.Drawing.Point(58, 20);
            this.X0.Maximum = 100D;
            this.X0.Minimum = 0D;
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(229, 15);
            this.X0.SmallChange = 100D;
            this.X0.TabIndex = 0;
            this.X0.Text = "gCustomTrackbar1";
            this.X0.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.X0.Value = 50D;
            this.X0.ValueChanged += new System.EventHandler(this.X0_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start X:";
            // 
            // ρ
            // 
            this.ρ.BackColor = System.Drawing.Color.Transparent;
            this.ρ.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.ρ.DefaultValue = 50D;
            this.ρ.LargeChange = 5D;
            this.ρ.Location = new System.Drawing.Point(58, 41);
            this.ρ.Maximum = 500D;
            this.ρ.Minimum = 0D;
            this.ρ.Name = "ρ";
            this.ρ.Size = new System.Drawing.Size(229, 15);
            this.ρ.SmallChange = 1D;
            this.ρ.TabIndex = 2;
            this.ρ.Text = "gCustomTrackbar2";
            this.ρ.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.ρ.Value = 350D;
            this.ρ.ValueChanged += new System.EventHandler(this.ρ_ValueChanged);
            // 
            // Lρ
            // 
            this.Lρ.AutoSize = true;
            this.Lρ.Location = new System.Drawing.Point(293, 41);
            this.Lρ.Name = "Lρ";
            this.Lρ.Size = new System.Drawing.Size(28, 15);
            this.Lρ.TabIndex = 5;
            this.Lρ.Text = "3,50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ρ:";
            // 
            // LX0
            // 
            this.LX0.AutoSize = true;
            this.LX0.Location = new System.Drawing.Point(293, 20);
            this.LX0.Name = "LX0";
            this.LX0.Size = new System.Drawing.Size(28, 15);
            this.LX0.TabIndex = 4;
            this.LX0.Text = "0,50";
            // 
            // GTSwitch001
            // 
            this.GTSwitch001.BackColor = System.Drawing.Color.White;
            this.GTSwitch001.BackColorNull = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.GTSwitch001.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.GTSwitch001.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.GTSwitch001.Checked = null;
            this.GTSwitch001.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GTSwitch001.Location = new System.Drawing.Point(6, 1);
            this.GTSwitch001.Name = "GTSwitch001";
            this.GTSwitch001.Size = new System.Drawing.Size(244, 15);
            this.GTSwitch001.TabIndex = 8;
            this.GTSwitch001.Text = "Определитесь с параметрами";
            this.GTSwitch001.TextOffChecked = "Множественное построение";
            this.GTSwitch001.TextOnChecked = "Одиночное построение";
            this.GTSwitch001.CheckedChanged += new Tis.Controls.GToggleSwitch.OnCheckedChangedHandler(this.GTSwitch001_CheckedChanged);
            // 
            // Время
            // 
            this.Время.Enabled = true;
            this.Время.Tick += new System.EventHandler(this.Время_Tick);
            // 
            // GFeigenbaum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VProperty);
            this.Name = "GFeigenbaum";
            this.Size = new System.Drawing.Size(1210, 589);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GFeigenbaum_MouseClick);
            this.VProperty.ResumeLayout(false);
            this.G2.ResumeLayout(false);
            this.G2.PerformLayout();
            this.G1.ResumeLayout(false);
            this.G1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox VProperty;
        private Label Lρ;
        private Label LX0;
        private Label label2;
        private Controls.GCustomTrackbar ρ;
        private Label label1;
        private Controls.GCustomTrackbar X0;
        private Button B3D;
        private GroupBox G1;
        private GroupBox G2;
        private Label Ldρ;
        private Label LdX0;
        private Controls.GCustomTrackbar dρ;
        private Label label6;
        private Label label5;
        private Controls.GCustomTrackbar dX0;
        private Controls.GToggleSwitch GTSwitch001;
        private System.Windows.Forms.Timer Время;
    }
}
