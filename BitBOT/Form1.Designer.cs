namespace BitBOT
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
            this.components = new System.ComponentModel.Container();
            this.RadioSeconds = new MetroFramework.Controls.MetroRadioButton();
            this.RadioMinutes = new MetroFramework.Controls.MetroRadioButton();
            this.SetPoint = new MetroFramework.Controls.MetroLabel();
            this.ArbitraryLocation = new MetroFramework.Controls.MetroLabel();
            this.Time_TextBox = new System.Windows.Forms.TextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.StartButton = new MetroFramework.Controls.MetroLabel();
            this.StopButton = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioSeconds
            // 
            this.RadioSeconds.AutoSize = true;
            this.RadioSeconds.Checked = true;
            this.RadioSeconds.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioSeconds.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.RadioSeconds.Location = new System.Drawing.Point(9, 29);
            this.RadioSeconds.Name = "RadioSeconds";
            this.RadioSeconds.Size = new System.Drawing.Size(73, 19);
            this.RadioSeconds.TabIndex = 1;
            this.RadioSeconds.TabStop = true;
            this.RadioSeconds.Text = "Seconds";
            this.RadioSeconds.UseSelectable = true;
            // 
            // RadioMinutes
            // 
            this.RadioMinutes.AutoSize = true;
            this.RadioMinutes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.RadioMinutes.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.RadioMinutes.Location = new System.Drawing.Point(9, 54);
            this.RadioMinutes.Name = "RadioMinutes";
            this.RadioMinutes.Size = new System.Drawing.Size(70, 19);
            this.RadioMinutes.TabIndex = 2;
            this.RadioMinutes.Text = "Minutes";
            this.RadioMinutes.UseSelectable = true;
            // 
            // SetPoint
            // 
            this.SetPoint.AutoSize = true;
            this.SetPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SetPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetPoint.Location = new System.Drawing.Point(10, 148);
            this.SetPoint.Name = "SetPoint";
            this.SetPoint.Size = new System.Drawing.Size(123, 19);
            this.SetPoint.Style = MetroFramework.MetroColorStyle.Green;
            this.SetPoint.TabIndex = 4;
            this.SetPoint.Text = "Set Cursor Location";
            this.SetPoint.UseCustomBackColor = true;
            this.SetPoint.UseStyleColors = true;
            this.SetPoint.Click += new System.EventHandler(this.SetPoint_Click);
            // 
            // ArbitraryLocation
            // 
            this.ArbitraryLocation.AutoSize = true;
            this.ArbitraryLocation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ArbitraryLocation.Location = new System.Drawing.Point(9, 76);
            this.ArbitraryLocation.Name = "ArbitraryLocation";
            this.ArbitraryLocation.Size = new System.Drawing.Size(77, 19);
            this.ArbitraryLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.ArbitraryLocation.TabIndex = 5;
            this.ArbitraryLocation.Text = "{X=0;Y=0}";
            this.ArbitraryLocation.UseStyleColors = true;
            // 
            // Time_TextBox
            // 
            this.Time_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Time_TextBox.Font = new System.Drawing.Font("DIN", 40.25F);
            this.Time_TextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Time_TextBox.Location = new System.Drawing.Point(33, 61);
            this.Time_TextBox.MaxLength = 2;
            this.Time_TextBox.Multiline = true;
            this.Time_TextBox.Name = "Time_TextBox";
            this.Time_TextBox.Size = new System.Drawing.Size(68, 68);
            this.Time_TextBox.TabIndex = 3;
            this.Time_TextBox.Text = "60";
            this.Time_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time_TextBox.WordWrap = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(9, 144);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(290, 1);
            this.metroProgressBar1.TabIndex = 10;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StartButton.Location = new System.Drawing.Point(12, 14);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(47, 25);
            this.StartButton.Style = MetroFramework.MetroColorStyle.Green;
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start";
            this.StartButton.UseStyleColors = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.AutoSize = true;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StopButton.Location = new System.Drawing.Point(10, 14);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(46, 25);
            this.StopButton.Style = MetroFramework.MetroColorStyle.Red;
            this.StopButton.TabIndex = 13;
            this.StopButton.Text = "Stop";
            this.StopButton.UseStyleColors = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel3.Location = new System.Drawing.Point(10, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "About";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.ArbitraryLocation);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.RadioSeconds);
            this.panel1.Controls.Add(this.RadioMinutes);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 1);
            this.panel1.TabIndex = 18;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel4.Location = new System.Drawing.Point(89, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Close";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(140, 175);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.Time_TextBox);
            this.Controls.Add(this.SetPoint);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton RadioSeconds;
        private MetroFramework.Controls.MetroRadioButton RadioMinutes;
        private MetroFramework.Controls.MetroLabel SetPoint;
        private MetroFramework.Controls.MetroLabel ArbitraryLocation;
        private System.Windows.Forms.TextBox Time_TextBox;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel StartButton;
        private MetroFramework.Controls.MetroLabel StopButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer Timer2;
    }
}

