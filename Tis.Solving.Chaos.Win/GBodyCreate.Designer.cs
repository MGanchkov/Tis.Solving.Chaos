namespace Tis.Solving.Chaos
{
    partial class GBodyCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VRadius = new System.Windows.Forms.TextBox();
            this.Vm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Vq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VLocation = new Tis.Controls.GVector3D();
            this.VSpeed = new Tis.Controls.GVector3D();
            this.TLP001 = new System.Windows.Forms.TableLayoutPanel();
            this.TLP001.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Радиус:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VRadius
            // 
            this.VRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VRadius.Location = new System.Drawing.Point(68, 61);
            this.VRadius.Name = "VRadius";
            this.VRadius.Size = new System.Drawing.Size(61, 23);
            this.VRadius.TabIndex = 5;
            this.VRadius.TextChanged += new System.EventHandler(this.VDouble_TextChanged);
            // 
            // Vm
            // 
            this.Vm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vm.Location = new System.Drawing.Point(68, 90);
            this.Vm.Name = "Vm";
            this.Vm.Size = new System.Drawing.Size(61, 23);
            this.Vm.TabIndex = 7;
            this.Vm.TextChanged += new System.EventHandler(this.VDouble_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Масса:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Vq
            // 
            this.Vq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vq.Location = new System.Drawing.Point(200, 90);
            this.Vq.Name = "Vq";
            this.Vq.Size = new System.Drawing.Size(62, 23);
            this.Vq.TabIndex = 9;
            this.Vq.TextChanged += new System.EventHandler(this.VDouble_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(135, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Заряд:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VLocation
            // 
            this.VLocation.CanWrite = false;
            this.TLP001.SetColumnSpan(this.VLocation, 3);
            this.VLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VLocation.Location = new System.Drawing.Point(68, 3);
            this.VLocation.MaximumSize = new System.Drawing.Size(0, 23);
            this.VLocation.MinimumSize = new System.Drawing.Size(195, 23);
            this.VLocation.Name = "VLocation";
            this.VLocation.Size = new System.Drawing.Size(195, 23);
            this.VLocation.TabIndex = 12;
            // 
            // VSpeed
            // 
            this.VSpeed.CanWrite = false;
            this.TLP001.SetColumnSpan(this.VSpeed, 3);
            this.VSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSpeed.Location = new System.Drawing.Point(68, 32);
            this.VSpeed.MaximumSize = new System.Drawing.Size(0, 23);
            this.VSpeed.MinimumSize = new System.Drawing.Size(195, 23);
            this.VSpeed.Name = "VSpeed";
            this.VSpeed.Size = new System.Drawing.Size(195, 23);
            this.VSpeed.TabIndex = 13;
            // 
            // TLP001
            // 
            this.TLP001.ColumnCount = 4;
            this.TLP001.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TLP001.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP001.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TLP001.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP001.Controls.Add(this.label1, 0, 1);
            this.TLP001.Controls.Add(this.label5, 2, 4);
            this.TLP001.Controls.Add(this.Vq, 3, 4);
            this.TLP001.Controls.Add(this.VSpeed, 1, 2);
            this.TLP001.Controls.Add(this.VLocation, 1, 1);
            this.TLP001.Controls.Add(this.Vm, 1, 4);
            this.TLP001.Controls.Add(this.label2, 0, 2);
            this.TLP001.Controls.Add(this.label4, 0, 4);
            this.TLP001.Controls.Add(this.label3, 0, 3);
            this.TLP001.Controls.Add(this.VRadius, 1, 3);
            this.TLP001.Location = new System.Drawing.Point(58, 45);
            this.TLP001.MinimumSize = new System.Drawing.Size(265, 116);
            this.TLP001.Name = "TLP001";
            this.TLP001.RowCount = 6;
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLP001.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP001.Size = new System.Drawing.Size(265, 116);
            this.TLP001.TabIndex = 14;
            // 
            // GBodyCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP001);
            this.Name = "GBodyCreate";
            this.Size = new System.Drawing.Size(449, 229);
            this.TLP001.ResumeLayout(false);
            this.TLP001.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox VRadius;
        private TextBox Vm;
        private Label label4;
        private TextBox Vq;
        private Label label5;
        private Controls.GVector3D VLocation;
        private Controls.GVector3D VSpeed;
        private TableLayoutPanel TLP001;
    }
}
