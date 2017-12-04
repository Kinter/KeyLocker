namespace KeyLocker
{
    partial class Settings
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelLocktime = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelSecond = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.TextBoxUnlock = new System.Windows.Forms.TextBox();
            this.labelUnlock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("굴림", 9F);
            this.buttonStart.Location = new System.Drawing.Point(12, 179);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 20);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelLocktime
            // 
            this.labelLocktime.AutoSize = true;
            this.labelLocktime.Location = new System.Drawing.Point(22, 20);
            this.labelLocktime.Name = "labelLocktime";
            this.labelLocktime.Size = new System.Drawing.Size(57, 12);
            this.labelLocktime.TabIndex = 3;
            this.labelLocktime.Text = "잠금 시간";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("굴림", 12F);
            this.labelHour.Location = new System.Drawing.Point(71, 47);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(17, 16);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "h";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("굴림", 12F);
            this.labelMinute.Location = new System.Drawing.Point(71, 74);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(21, 16);
            this.labelMinute.TabIndex = 6;
            this.labelMinute.Text = "m";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(22, 69);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("굴림", 12F);
            this.labelSecond.Location = new System.Drawing.Point(71, 101);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(17, 16);
            this.labelSecond.TabIndex = 8;
            this.labelSecond.Text = "s";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(22, 96);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 21);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // TextBoxUnlock
            // 
            this.TextBoxUnlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxUnlock.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TextBoxUnlock.Location = new System.Drawing.Point(125, 133);
            this.TextBoxUnlock.Name = "TextBoxUnlock";
            this.TextBoxUnlock.ReadOnly = true;
            this.TextBoxUnlock.Size = new System.Drawing.Size(107, 21);
            this.TextBoxUnlock.TabIndex = 10;
            // 
            // labelUnlock
            // 
            this.labelUnlock.AutoSize = true;
            this.labelUnlock.Location = new System.Drawing.Point(22, 136);
            this.labelUnlock.Name = "labelUnlock";
            this.labelUnlock.Size = new System.Drawing.Size(97, 12);
            this.labelUnlock.TabIndex = 11;
            this.labelUnlock.Text = "잠금 해제 단축키";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.labelUnlock);
            this.Controls.Add(this.TextBoxUnlock);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelLocktime);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelLocktime;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox TextBoxUnlock;
        private System.Windows.Forms.Label labelUnlock;
    }
}