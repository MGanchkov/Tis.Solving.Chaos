namespace Tis.Solving.Chaos
{
    partial class GBigLorenz
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
            this.VProperty = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VBZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VBY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.VBX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Vσ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VAZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VAY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VAX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BRun = new System.Windows.Forms.Button();
            this.Vρ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Vβ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VProperty.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VProperty
            // 
            this.VProperty.Controls.Add(this.groupBox2);
            this.VProperty.Controls.Add(this.Vσ);
            this.VProperty.Controls.Add(this.groupBox1);
            this.VProperty.Controls.Add(this.BRun);
            this.VProperty.Controls.Add(this.Vρ);
            this.VProperty.Controls.Add(this.label3);
            this.VProperty.Controls.Add(this.Vβ);
            this.VProperty.Controls.Add(this.label2);
            this.VProperty.Controls.Add(this.label1);
            this.VProperty.Location = new System.Drawing.Point(3, 3);
            this.VProperty.Name = "VProperty";
            this.VProperty.Size = new System.Drawing.Size(433, 165);
            this.VProperty.TabIndex = 8;
            this.VProperty.TabStop = false;
            this.VProperty.Text = "Параметры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VBZ);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.VBY);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.VBX);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(290, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 106);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Two";
            // 
            // VBZ
            // 
            this.VBZ.Location = new System.Drawing.Point(29, 75);
            this.VBZ.Name = "VBZ";
            this.VBZ.Size = new System.Drawing.Size(100, 23);
            this.VBZ.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Z:";
            // 
            // VBY
            // 
            this.VBY.Location = new System.Drawing.Point(29, 46);
            this.VBY.Name = "VBY";
            this.VBY.Size = new System.Drawing.Size(100, 23);
            this.VBY.TabIndex = 3;
            this.VBY.Text = "1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Y:";
            // 
            // VBX
            // 
            this.VBX.Location = new System.Drawing.Point(29, 17);
            this.VBX.Name = "VBX";
            this.VBX.Size = new System.Drawing.Size(100, 23);
            this.VBX.TabIndex = 1;
            this.VBX.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "X:";
            // 
            // Vσ
            // 
            this.Vσ.Location = new System.Drawing.Point(36, 39);
            this.Vσ.Name = "Vσ";
            this.Vσ.Size = new System.Drawing.Size(106, 23);
            this.Vσ.TabIndex = 0;
            this.Vσ.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VAZ);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.VAY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VAX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(148, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "One";
            // 
            // VAZ
            // 
            this.VAZ.Location = new System.Drawing.Point(29, 75);
            this.VAZ.Name = "VAZ";
            this.VAZ.Size = new System.Drawing.Size(100, 23);
            this.VAZ.TabIndex = 5;
            this.VAZ.Text = "1.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Z:";
            // 
            // VAY
            // 
            this.VAY.Location = new System.Drawing.Point(29, 46);
            this.VAY.Name = "VAY";
            this.VAY.Size = new System.Drawing.Size(100, 23);
            this.VAY.TabIndex = 3;
            this.VAY.Text = "1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y:";
            // 
            // VAX
            // 
            this.VAX.Location = new System.Drawing.Point(29, 17);
            this.VAX.Name = "VAX";
            this.VAX.Size = new System.Drawing.Size(100, 23);
            this.VAX.TabIndex = 1;
            this.VAX.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "X:";
            // 
            // BRun
            // 
            this.BRun.Location = new System.Drawing.Point(6, 134);
            this.BRun.Name = "BRun";
            this.BRun.Size = new System.Drawing.Size(419, 23);
            this.BRun.TabIndex = 6;
            this.BRun.Text = "Начать";
            this.BRun.UseVisualStyleBackColor = true;
            this.BRun.Click += new System.EventHandler(this.BRun_Click);
            // 
            // Vρ
            // 
            this.Vρ.Location = new System.Drawing.Point(36, 68);
            this.Vρ.Name = "Vρ";
            this.Vρ.Size = new System.Drawing.Size(106, 23);
            this.Vρ.TabIndex = 1;
            this.Vρ.Text = "28";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "β:";
            // 
            // Vβ
            // 
            this.Vβ.Location = new System.Drawing.Point(36, 97);
            this.Vβ.Name = "Vβ";
            this.Vβ.Size = new System.Drawing.Size(106, 23);
            this.Vβ.TabIndex = 2;
            this.Vβ.Text = "2,6666666666666666666666666666667";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ρ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "σ:";
            // 
            // GLorenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VProperty);
            this.Name = "GLorenz";
            this.Size = new System.Drawing.Size(800, 600);
            this.VProperty.ResumeLayout(false);
            this.VProperty.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox VProperty;
        private GroupBox groupBox2;
        private TextBox VBZ;
        private Label label7;
        private TextBox VBY;
        private Label label8;
        private TextBox VBX;
        private Label label9;
        private TextBox Vσ;
        private GroupBox groupBox1;
        private TextBox VAZ;
        private Label label6;
        private TextBox VAY;
        private Label label5;
        private TextBox VAX;
        private Label label4;
        private Button BRun;
        private TextBox Vρ;
        private Label label3;
        private TextBox Vβ;
        private Label label2;
        private Label label1;
    }
}
