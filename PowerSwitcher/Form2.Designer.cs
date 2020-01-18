namespace PowerSwitcher
{
    partial class Form2
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
            this.cmdPower = new System.Windows.Forms.Button();
            this.pwrsvrID = new System.Windows.Forms.Label();
            this.balID = new System.Windows.Forms.Label();
            this.highID = new System.Windows.Forms.Label();
            this.amdHID = new System.Windows.Forms.Label();
            this.amdBID = new System.Windows.Forms.Label();
            this.powersavertxt = new System.Windows.Forms.TextBox();
            this.balancedtxt = new System.Windows.Forms.TextBox();
            this.hightxt = new System.Windows.Forms.TextBox();
            this.amdhtxt = new System.Windows.Forms.TextBox();
            this.amdbtxt = new System.Windows.Forms.TextBox();
            this.enterStates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPower
            // 
            this.cmdPower.Location = new System.Drawing.Point(24, 28);
            this.cmdPower.Name = "cmdPower";
            this.cmdPower.Size = new System.Drawing.Size(130, 42);
            this.cmdPower.TabIndex = 0;
            this.cmdPower.Text = "List States";
            this.cmdPower.UseVisualStyleBackColor = true;
            this.cmdPower.Click += new System.EventHandler(this.cmdPower_Click);
            // 
            // pwrsvrID
            // 
            this.pwrsvrID.AutoSize = true;
            this.pwrsvrID.Location = new System.Drawing.Point(24, 94);
            this.pwrsvrID.Name = "pwrsvrID";
            this.pwrsvrID.Size = new System.Drawing.Size(110, 13);
            this.pwrsvrID.TabIndex = 1;
            this.pwrsvrID.Text = "Enter Power Saver ID";
            // 
            // balID
            // 
            this.balID.AutoSize = true;
            this.balID.Location = new System.Drawing.Point(24, 123);
            this.balID.Name = "balID";
            this.balID.Size = new System.Drawing.Size(94, 13);
            this.balID.TabIndex = 2;
            this.balID.Text = "Enter Balanced ID";
            // 
            // highID
            // 
            this.highID.AutoSize = true;
            this.highID.Location = new System.Drawing.Point(24, 153);
            this.highID.Name = "highID";
            this.highID.Size = new System.Drawing.Size(71, 13);
            this.highID.TabIndex = 3;
            this.highID.Text = "Enter High ID";
            // 
            // amdHID
            // 
            this.amdHID.AutoSize = true;
            this.amdHID.Location = new System.Drawing.Point(24, 184);
            this.amdHID.Name = "amdHID";
            this.amdHID.Size = new System.Drawing.Size(98, 13);
            this.amdHID.TabIndex = 4;
            this.amdHID.Text = "Enter AMD High ID";
            // 
            // amdBID
            // 
            this.amdBID.AutoSize = true;
            this.amdBID.Location = new System.Drawing.Point(24, 210);
            this.amdBID.Name = "amdBID";
            this.amdBID.Size = new System.Drawing.Size(121, 13);
            this.amdBID.TabIndex = 5;
            this.amdBID.Text = "Enter AMD Balanced ID";
            // 
            // powersavertxt
            // 
            this.powersavertxt.Location = new System.Drawing.Point(180, 87);
            this.powersavertxt.Name = "powersavertxt";
            this.powersavertxt.Size = new System.Drawing.Size(322, 20);
            this.powersavertxt.TabIndex = 6;
            this.powersavertxt.TextChanged += new System.EventHandler(this.powersavertxt_TextChanged);
            // 
            // balancedtxt
            // 
            this.balancedtxt.Location = new System.Drawing.Point(180, 116);
            this.balancedtxt.Name = "balancedtxt";
            this.balancedtxt.Size = new System.Drawing.Size(322, 20);
            this.balancedtxt.TabIndex = 7;
            this.balancedtxt.TextChanged += new System.EventHandler(this.balancedtxt_TextChanged);
            // 
            // hightxt
            // 
            this.hightxt.Location = new System.Drawing.Point(180, 146);
            this.hightxt.Name = "hightxt";
            this.hightxt.Size = new System.Drawing.Size(322, 20);
            this.hightxt.TabIndex = 8;
            this.hightxt.TextChanged += new System.EventHandler(this.hightxt_TextChanged);
            // 
            // amdhtxt
            // 
            this.amdhtxt.Location = new System.Drawing.Point(180, 177);
            this.amdhtxt.Name = "amdhtxt";
            this.amdhtxt.Size = new System.Drawing.Size(322, 20);
            this.amdhtxt.TabIndex = 9;
            this.amdhtxt.TextChanged += new System.EventHandler(this.amdhtxt_TextChanged);
            // 
            // amdbtxt
            // 
            this.amdbtxt.Location = new System.Drawing.Point(180, 203);
            this.amdbtxt.Name = "amdbtxt";
            this.amdbtxt.Size = new System.Drawing.Size(322, 20);
            this.amdbtxt.TabIndex = 10;
            this.amdbtxt.TextChanged += new System.EventHandler(this.amdbtxt_TextChanged);
            // 
            // enterStates
            // 
            this.enterStates.Location = new System.Drawing.Point(497, 28);
            this.enterStates.Name = "enterStates";
            this.enterStates.Size = new System.Drawing.Size(139, 42);
            this.enterStates.TabIndex = 11;
            this.enterStates.Text = "Enter States";
            this.enterStates.UseVisualStyleBackColor = true;
            this.enterStates.Click += new System.EventHandler(this.enterStates_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 241);
            this.Controls.Add(this.enterStates);
            this.Controls.Add(this.amdbtxt);
            this.Controls.Add(this.amdhtxt);
            this.Controls.Add(this.hightxt);
            this.Controls.Add(this.balancedtxt);
            this.Controls.Add(this.powersavertxt);
            this.Controls.Add(this.amdBID);
            this.Controls.Add(this.amdHID);
            this.Controls.Add(this.highID);
            this.Controls.Add(this.balID);
            this.Controls.Add(this.pwrsvrID);
            this.Controls.Add(this.cmdPower);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPower;
        private System.Windows.Forms.Label pwrsvrID;
        private System.Windows.Forms.Label balID;
        private System.Windows.Forms.Label highID;
        private System.Windows.Forms.Label amdHID;
        private System.Windows.Forms.Label amdBID;
        private System.Windows.Forms.TextBox powersavertxt;
        private System.Windows.Forms.TextBox balancedtxt;
        private System.Windows.Forms.TextBox hightxt;
        private System.Windows.Forms.TextBox amdhtxt;
        private System.Windows.Forms.TextBox amdbtxt;
        private System.Windows.Forms.Button enterStates;
    }
}