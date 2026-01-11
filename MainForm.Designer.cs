namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DateLabel = new Label();
            TimeLabel = new Label();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(0, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(400, 55);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "2026/01/01 星期二";
            DateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            TimeLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeLabel.Location = new Point(0, 55);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(400, 55);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "00:00:00";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateTimer
            // 
            UpdateTimer.Enabled = true;
            UpdateTimer.Interval = 200;
            UpdateTimer.Tick += UpdateTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 110);
            Controls.Add(TimeLabel);
            Controls.Add(DateLabel);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "Timer";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Label DateLabel;
        private Label TimeLabel;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}
