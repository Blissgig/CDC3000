namespace CDC_3000
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFont = new System.Windows.Forms.Button();
            this.cmdBackgroundColor = new System.Windows.Forms.Button();
            this.cmdForecolor = new System.Windows.Forms.Button();
            this.udHours = new System.Windows.Forms.NumericUpDown();
            this.udMinutes = new System.Windows.Forms.NumericUpDown();
            this.udSeconds = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndMessage = new System.Windows.Forms.TextBox();
            this.lblEndMessage = new System.Windows.Forms.Label();
            this.chkFullScreen = new System.Windows.Forms.CheckBox();
            this.chkAnimate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(425, 198);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(122, 41);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdStart.Location = new System.Drawing.Point(281, 198);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(122, 41);
            this.cmdStart.TabIndex = 2;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // cmdFont
            // 
            this.cmdFont.Location = new System.Drawing.Point(421, 26);
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(126, 40);
            this.cmdFont.TabIndex = 4;
            this.cmdFont.Text = "Font";
            this.cmdFont.UseVisualStyleBackColor = true;
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // cmdBackgroundColor
            // 
            this.cmdBackgroundColor.Location = new System.Drawing.Point(425, 133);
            this.cmdBackgroundColor.Name = "cmdBackgroundColor";
            this.cmdBackgroundColor.Size = new System.Drawing.Size(122, 40);
            this.cmdBackgroundColor.TabIndex = 5;
            this.cmdBackgroundColor.Text = "Background Color";
            this.cmdBackgroundColor.UseVisualStyleBackColor = true;
            this.cmdBackgroundColor.Click += new System.EventHandler(this.cmdBackgroundColor_Click);
            // 
            // cmdForecolor
            // 
            this.cmdForecolor.Location = new System.Drawing.Point(425, 79);
            this.cmdForecolor.Name = "cmdForecolor";
            this.cmdForecolor.Size = new System.Drawing.Size(122, 40);
            this.cmdForecolor.TabIndex = 6;
            this.cmdForecolor.Text = "Foreground Color";
            this.cmdForecolor.UseVisualStyleBackColor = true;
            this.cmdForecolor.Click += new System.EventHandler(this.cmdForecolor_Click);
            // 
            // udHours
            // 
            this.udHours.Location = new System.Drawing.Point(12, 27);
            this.udHours.Name = "udHours";
            this.udHours.Size = new System.Drawing.Size(120, 20);
            this.udHours.TabIndex = 7;
            this.udHours.ValueChanged += new System.EventHandler(this.udHours_ValueChanged);
            // 
            // udMinutes
            // 
            this.udMinutes.Location = new System.Drawing.Point(12, 79);
            this.udMinutes.Name = "udMinutes";
            this.udMinutes.Size = new System.Drawing.Size(120, 20);
            this.udMinutes.TabIndex = 8;
            this.udMinutes.ValueChanged += new System.EventHandler(this.udMinutes_ValueChanged);
            // 
            // udSeconds
            // 
            this.udSeconds.Location = new System.Drawing.Point(12, 133);
            this.udSeconds.Name = "udSeconds";
            this.udSeconds.Size = new System.Drawing.Size(120, 20);
            this.udSeconds.TabIndex = 9;
            this.udSeconds.ValueChanged += new System.EventHandler(this.udSeconds_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seconds";
            // 
            // txtEndMessage
            // 
            this.txtEndMessage.Location = new System.Drawing.Point(174, 26);
            this.txtEndMessage.Name = "txtEndMessage";
            this.txtEndMessage.Size = new System.Drawing.Size(229, 20);
            this.txtEndMessage.TabIndex = 12;
            this.txtEndMessage.TextChanged += new System.EventHandler(this.txtEndMessage_TextChanged);
            // 
            // lblEndMessage
            // 
            this.lblEndMessage.AutoSize = true;
            this.lblEndMessage.Location = new System.Drawing.Point(171, 9);
            this.lblEndMessage.Name = "lblEndMessage";
            this.lblEndMessage.Size = new System.Drawing.Size(151, 13);
            this.lblEndMessage.TabIndex = 13;
            this.lblEndMessage.Text = "Message at end of countdown";
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.AutoSize = true;
            this.chkFullScreen.Location = new System.Drawing.Point(174, 79);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.Size = new System.Drawing.Size(79, 17);
            this.chkFullScreen.TabIndex = 14;
            this.chkFullScreen.Text = "Full Screen";
            this.chkFullScreen.UseVisualStyleBackColor = true;
            this.chkFullScreen.CheckedChanged += new System.EventHandler(this.chkFullScreen_CheckedChanged);
            // 
            // chkAnimate
            // 
            this.chkAnimate.AutoSize = true;
            this.chkAnimate.Location = new System.Drawing.Point(174, 133);
            this.chkAnimate.Name = "chkAnimate";
            this.chkAnimate.Size = new System.Drawing.Size(109, 17);
            this.chkAnimate.TabIndex = 15;
            this.chkAnimate.Text = "Animate Seconds";
            this.chkAnimate.UseVisualStyleBackColor = true;
            this.chkAnimate.CheckedChanged += new System.EventHandler(this.chkAnimate_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 254);
            this.Controls.Add(this.chkAnimate);
            this.Controls.Add(this.chkFullScreen);
            this.Controls.Add(this.lblEndMessage);
            this.Controls.Add(this.txtEndMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udSeconds);
            this.Controls.Add(this.udMinutes);
            this.Controls.Add(this.udHours);
            this.Controls.Add(this.cmdForecolor);
            this.Controls.Add(this.cmdBackgroundColor);
            this.Controls.Add(this.cmdFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFont;
        private System.Windows.Forms.Button cmdBackgroundColor;
        private System.Windows.Forms.Button cmdForecolor;
        private System.Windows.Forms.NumericUpDown udHours;
        private System.Windows.Forms.NumericUpDown udMinutes;
        private System.Windows.Forms.NumericUpDown udSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndMessage;
        private System.Windows.Forms.Label lblEndMessage;
        private System.Windows.Forms.CheckBox chkFullScreen;
        private System.Windows.Forms.CheckBox chkAnimate;
    }
}