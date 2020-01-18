namespace PowerSwitcher
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
            this.powerSaver = new System.Windows.Forms.RadioButton();
            this.balancedPower = new System.Windows.Forms.RadioButton();
            this.highPerformance = new System.Windows.Forms.RadioButton();
            this.balAMD = new System.Windows.Forms.RadioButton();
            this.highAMD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pwrConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powerSaver
            // 
            this.powerSaver.AutoSize = true;
            this.powerSaver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.powerSaver.Cursor = System.Windows.Forms.Cursors.Default;
            this.powerSaver.Location = new System.Drawing.Point(17, 60);
            this.powerSaver.Margin = new System.Windows.Forms.Padding(8);
            this.powerSaver.Name = "powerSaver";
            this.powerSaver.Size = new System.Drawing.Size(183, 35);
            this.powerSaver.TabIndex = 0;
            this.powerSaver.Text = "Power saver";
            this.powerSaver.UseVisualStyleBackColor = false;
            this.powerSaver.AppearanceChanged += new System.EventHandler(this.clickSaver);
            this.powerSaver.CheckedChanged += new System.EventHandler(this.powerSaver_CheckedChanged);
            // 
            // balancedPower
            // 
            this.balancedPower.AutoSize = true;
            this.balancedPower.BackColor = System.Drawing.Color.WhiteSmoke;
            this.balancedPower.ForeColor = System.Drawing.SystemColors.ControlText;
            this.balancedPower.Location = new System.Drawing.Point(251, 60);
            this.balancedPower.Margin = new System.Windows.Forms.Padding(8);
            this.balancedPower.Name = "balancedPower";
            this.balancedPower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.balancedPower.Size = new System.Drawing.Size(145, 35);
            this.balancedPower.TabIndex = 1;
            this.balancedPower.Text = "Balanced";
            this.balancedPower.UseVisualStyleBackColor = false;
            this.balancedPower.CheckedChanged += new System.EventHandler(this.clickBal);
            // 
            // highPerformance
            // 
            this.highPerformance.AutoSize = true;
            this.highPerformance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.highPerformance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.highPerformance.Location = new System.Drawing.Point(440, 60);
            this.highPerformance.Margin = new System.Windows.Forms.Padding(8);
            this.highPerformance.Name = "highPerformance";
            this.highPerformance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.highPerformance.Size = new System.Drawing.Size(247, 35);
            this.highPerformance.TabIndex = 2;
            this.highPerformance.Text = "High performance";
            this.highPerformance.UseVisualStyleBackColor = false;
            this.highPerformance.CheckedChanged += new System.EventHandler(this.clickHigh);
            // 
            // balAMD
            // 
            this.balAMD.AutoSize = true;
            this.balAMD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.balAMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.balAMD.Location = new System.Drawing.Point(96, 117);
            this.balAMD.Margin = new System.Windows.Forms.Padding(8);
            this.balAMD.Name = "balAMD";
            this.balAMD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.balAMD.Size = new System.Drawing.Size(209, 35);
            this.balAMD.TabIndex = 3;
            this.balAMD.Text = "AMD balanced";
            this.balAMD.UseVisualStyleBackColor = false;
            this.balAMD.CheckedChanged += new System.EventHandler(this.clickAMDB);
            // 
            // highAMD
            // 
            this.highAMD.AutoSize = true;
            this.highAMD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.highAMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.highAMD.Location = new System.Drawing.Point(342, 117);
            this.highAMD.Margin = new System.Windows.Forms.Padding(8);
            this.highAMD.Name = "highAMD";
            this.highAMD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.highAMD.Size = new System.Drawing.Size(150, 35);
            this.highAMD.TabIndex = 4;
            this.highAMD.Text = "AMD high";
            this.highAMD.UseVisualStyleBackColor = false;
            this.highAMD.CheckedChanged += new System.EventHandler(this.clickAMDH);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(179, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a powerplan:";
            // 
            // pwrConfig
            // 
            this.pwrConfig.Location = new System.Drawing.Point(17, 10);
            this.pwrConfig.Name = "pwrConfig";
            this.pwrConfig.Size = new System.Drawing.Size(134, 49);
            this.pwrConfig.TabIndex = 6;
            this.pwrConfig.Text = "Config";
            this.pwrConfig.UseVisualStyleBackColor = true;
            this.pwrConfig.Click += new System.EventHandler(this.pwrConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 180);
            this.Controls.Add(this.pwrConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highAMD);
            this.Controls.Add(this.balAMD);
            this.Controls.Add(this.highPerformance);
            this.Controls.Add(this.balancedPower);
            this.Controls.Add(this.powerSaver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "PowerSwitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton powerSaver;
        private System.Windows.Forms.RadioButton balancedPower;
        private System.Windows.Forms.RadioButton highPerformance;
        private System.Windows.Forms.RadioButton balAMD;
        private System.Windows.Forms.RadioButton highAMD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pwrConfig;
    }
}

