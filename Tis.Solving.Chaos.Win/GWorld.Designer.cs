namespace Tis.Solving.Chaos
{
    partial class GWorld
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VBodyCreate = new Tis.Solving.Chaos.GBodyCreate();
            this.GB001 = new System.Windows.Forms.GroupBox();
            this.BClose = new Tis.Controls.GButton();
            this.BAdd = new Tis.Controls.GButton();
            this.Время = new System.Windows.Forms.Timer(this.components);
            this.GB001.SuspendLayout();
            this.SuspendLayout();
            // 
            // VBodyCreate
            // 
            this.VBodyCreate.Location = new System.Drawing.Point(6, 22);
            this.VBodyCreate.MinimumSize = new System.Drawing.Size(265, 116);
            this.VBodyCreate.Name = "VBodyCreate";
            this.VBodyCreate.Size = new System.Drawing.Size(327, 116);
            this.VBodyCreate.TabIndex = 0;
            // 
            // GB001
            // 
            this.GB001.Controls.Add(this.BClose);
            this.GB001.Controls.Add(this.BAdd);
            this.GB001.Controls.Add(this.VBodyCreate);
            this.GB001.Location = new System.Drawing.Point(205, 185);
            this.GB001.Name = "GB001";
            this.GB001.Size = new System.Drawing.Size(339, 183);
            this.GB001.TabIndex = 1;
            this.GB001.TabStop = false;
            this.GB001.Text = "Добавить тело";
            this.GB001.Visible = false;
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.Color.Tomato;
            this.BClose.BackColorAdditional = System.Drawing.Color.Gray;
            this.BClose.BackColorGradientEnabled = false;
            this.BClose.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.BClose.BorderColor = System.Drawing.Color.Tomato;
            this.BClose.BorderColorEnabled = false;
            this.BClose.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.BClose.BorderColorOnHoverEnabled = false;
            this.BClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BClose.ForeColor = System.Drawing.Color.White;
            this.BClose.Location = new System.Drawing.Point(319, 0);
            this.BClose.Name = "BClose";
            this.BClose.RippleColor = System.Drawing.Color.Black;
            this.BClose.RoundingEnable = false;
            this.BClose.Size = new System.Drawing.Size(20, 20);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "X";
            this.BClose.TextHover = null;
            this.BClose.UseDownPressEffectOnClick = false;
            this.BClose.UseRippleEffect = true;
            this.BClose.UseZoomEffectOnHover = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.Color.Tomato;
            this.BAdd.BackColorAdditional = System.Drawing.Color.Gray;
            this.BAdd.BackColorGradientEnabled = false;
            this.BAdd.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.BAdd.BorderColor = System.Drawing.Color.Tomato;
            this.BAdd.BorderColorEnabled = false;
            this.BAdd.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.BAdd.BorderColorOnHoverEnabled = false;
            this.BAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAdd.ForeColor = System.Drawing.Color.White;
            this.BAdd.Location = new System.Drawing.Point(223, 144);
            this.BAdd.Name = "BAdd";
            this.BAdd.RippleColor = System.Drawing.Color.Black;
            this.BAdd.RoundingEnable = true;
            this.BAdd.Size = new System.Drawing.Size(110, 32);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.TextHover = "Добавить";
            this.BAdd.UseDownPressEffectOnClick = false;
            this.BAdd.UseRippleEffect = true;
            this.BAdd.UseZoomEffectOnHover = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Время
            // 
            this.Время.Enabled = true;
            this.Время.Tick += new System.EventHandler(this.Время_Tick);
            // 
            // GWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GB001);
            this.Name = "GWorld";
            this.Size = new System.Drawing.Size(879, 590);
            this.GB001.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GBodyCreate VBodyCreate;
        private GroupBox GB001;
        private Button button1;
        private Controls.GButton BAdd;
        private Controls.GButton BClose;
        private System.Windows.Forms.Timer Время;
    }
}
