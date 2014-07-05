namespace View
{
    partial class W8MultiTool_MainView
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Clock_label = new System.Windows.Forms.Label();
            this.Cpu_label = new System.Windows.Forms.Label();
            this.CpuCount_label = new System.Windows.Forms.Label();
            this.CpuRate_panel = new System.Windows.Forms.Panel();
            this.Another_label = new System.Windows.Forms.Label();
            this.AnotherCount_label = new System.Windows.Forms.Label();
            this.HddCount_label = new System.Windows.Forms.Label();
            this.Hdd_label = new System.Windows.Forms.Label();
            this.Ram_label = new System.Windows.Forms.Label();
            this.RamCount_label = new System.Windows.Forms.Label();
            this.Another_panel = new System.Windows.Forms.Panel();
            this.HddRate_panel = new System.Windows.Forms.Panel();
            this.RamRate_panel = new System.Windows.Forms.Panel();
            this.Video_Panel = new System.Windows.Forms.Panel();
            this.Max_PicBox = new System.Windows.Forms.PictureBox();
            this.Exit_PicBox = new System.Windows.Forms.PictureBox();
            this.timer_W8 = new System.Windows.Forms.Timer(this.components);
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TitleBar.Controls.Add(this.Exit_PicBox);
            this.TitleBar.Controls.Add(this.Max_PicBox);
            this.TitleBar.Controls.Add(this.Clock_label);
            this.TitleBar.Location = new System.Drawing.Point(-1, -1);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(252, 30);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Clock_label
            // 
            this.Clock_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_label.AutoSize = true;
            this.Clock_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_label.Location = new System.Drawing.Point(3, 4);
            this.Clock_label.Name = "Clock_label";
            this.Clock_label.Size = new System.Drawing.Size(113, 24);
            this.Clock_label.TabIndex = 1;
            this.Clock_label.Text = "CLOCK TIME";
            // 
            // Cpu_label
            // 
            this.Cpu_label.AutoSize = true;
            this.Cpu_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpu_label.Location = new System.Drawing.Point(2, 33);
            this.Cpu_label.Name = "Cpu_label";
            this.Cpu_label.Size = new System.Drawing.Size(94, 24);
            this.Cpu_label.TabIndex = 5;
            this.Cpu_label.Text = "CPU RATE";
            // 
            // CpuCount_label
            // 
            this.CpuCount_label.AutoSize = true;
            this.CpuCount_label.Location = new System.Drawing.Point(12, 61);
            this.CpuCount_label.Name = "CpuCount_label";
            this.CpuCount_label.Size = new System.Drawing.Size(31, 17);
            this.CpuCount_label.TabIndex = 8;
            this.CpuCount_label.Text = "cpu";
            // 
            // CpuRate_panel
            // 
            this.CpuRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpuRate_panel.Location = new System.Drawing.Point(98, 33);
            this.CpuRate_panel.Name = "CpuRate_panel";
            this.CpuRate_panel.Size = new System.Drawing.Size(149, 49);
            this.CpuRate_panel.TabIndex = 13;
            // 
            // Another_label
            // 
            this.Another_label.AutoSize = true;
            this.Another_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Another_label.Location = new System.Drawing.Point(8, 213);
            this.Another_label.Name = "Another_label";
            this.Another_label.Size = new System.Drawing.Size(91, 24);
            this.Another_label.TabIndex = 20;
            this.Another_label.Text = "ANOTHER";
            // 
            // AnotherCount_label
            // 
            this.AnotherCount_label.AutoSize = true;
            this.AnotherCount_label.Location = new System.Drawing.Point(15, 246);
            this.AnotherCount_label.Name = "AnotherCount_label";
            this.AnotherCount_label.Size = new System.Drawing.Size(58, 17);
            this.AnotherCount_label.TabIndex = 21;
            this.AnotherCount_label.Text = "Another";
            // 
            // HddCount_label
            // 
            this.HddCount_label.AutoSize = true;
            this.HddCount_label.Location = new System.Drawing.Point(9, 183);
            this.HddCount_label.Name = "HddCount_label";
            this.HddCount_label.Size = new System.Drawing.Size(32, 17);
            this.HddCount_label.TabIndex = 19;
            this.HddCount_label.Text = "hdd";
            // 
            // Hdd_label
            // 
            this.Hdd_label.AutoSize = true;
            this.Hdd_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hdd_label.Location = new System.Drawing.Point(4, 149);
            this.Hdd_label.Name = "Hdd_label";
            this.Hdd_label.Size = new System.Drawing.Size(95, 24);
            this.Hdd_label.TabIndex = 17;
            this.Hdd_label.Text = "HDD RATE";
            // 
            // Ram_label
            // 
            this.Ram_label.AutoSize = true;
            this.Ram_label.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ram_label.Location = new System.Drawing.Point(3, 90);
            this.Ram_label.Name = "Ram_label";
            this.Ram_label.Size = new System.Drawing.Size(96, 24);
            this.Ram_label.TabIndex = 16;
            this.Ram_label.Text = "RAM RATE";
            // 
            // RamCount_label
            // 
            this.RamCount_label.AutoSize = true;
            this.RamCount_label.Location = new System.Drawing.Point(11, 120);
            this.RamCount_label.Name = "RamCount_label";
            this.RamCount_label.Size = new System.Drawing.Size(32, 17);
            this.RamCount_label.TabIndex = 18;
            this.RamCount_label.Text = "ram";
            // 
            // Another_panel
            // 
            this.Another_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Another_panel.Location = new System.Drawing.Point(99, 213);
            this.Another_panel.Name = "Another_panel";
            this.Another_panel.Size = new System.Drawing.Size(149, 57);
            this.Another_panel.TabIndex = 24;
            // 
            // HddRate_panel
            // 
            this.HddRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HddRate_panel.Location = new System.Drawing.Point(99, 149);
            this.HddRate_panel.Name = "HddRate_panel";
            this.HddRate_panel.Size = new System.Drawing.Size(149, 57);
            this.HddRate_panel.TabIndex = 22;
            // 
            // RamRate_panel
            // 
            this.RamRate_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RamRate_panel.Location = new System.Drawing.Point(99, 88);
            this.RamRate_panel.Name = "RamRate_panel";
            this.RamRate_panel.Size = new System.Drawing.Size(149, 55);
            this.RamRate_panel.TabIndex = 23;
            // 
            // Video_Panel
            // 
            this.Video_Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Video_Panel.Location = new System.Drawing.Point(-1, 272);
            this.Video_Panel.Name = "Video_Panel";
            this.Video_Panel.Size = new System.Drawing.Size(251, 158);
            this.Video_Panel.TabIndex = 15;
            // 
            // Max_PicBox
            // 
            this.Max_PicBox.BackColor = System.Drawing.Color.Gray;
            this.Max_PicBox.BackgroundImage = global::View.Properties.Resources.maximize;
            this.Max_PicBox.Location = new System.Drawing.Point(189, 0);
            this.Max_PicBox.Name = "Max_PicBox";
            this.Max_PicBox.Size = new System.Drawing.Size(30, 30);
            this.Max_PicBox.TabIndex = 9;
            this.Max_PicBox.TabStop = false;
            this.Max_PicBox.Click += new System.EventHandler(this.Max_PicBox_Click);
            this.Max_PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Max_PicBox_MouseDown);
            this.Max_PicBox.MouseEnter += new System.EventHandler(this.Max_PicBox_MouseEnter);
            this.Max_PicBox.MouseLeave += new System.EventHandler(this.Max_PicBox_MouseLeave);
            // 
            // Exit_PicBox
            // 
            this.Exit_PicBox.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_PicBox.BackgroundImage = global::View.Properties.Resources.exit;
            this.Exit_PicBox.Location = new System.Drawing.Point(220, 0);
            this.Exit_PicBox.Name = "Exit_PicBox";
            this.Exit_PicBox.Size = new System.Drawing.Size(30, 30);
            this.Exit_PicBox.TabIndex = 10;
            this.Exit_PicBox.TabStop = false;
            this.Exit_PicBox.Click += new System.EventHandler(this.Exit_PicBox_Click);
            this.Exit_PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_PicBox_MouseDown);
            this.Exit_PicBox.MouseEnter += new System.EventHandler(this.Exit_PicBox_MouseEnter);
            this.Exit_PicBox.MouseLeave += new System.EventHandler(this.Exit_PicBox_MouseLeave);
            // 
            // timer_W8
            // 
            this.timer_W8.Tick += new System.EventHandler(this.timer_W8_Tick);
            // 
            // W8MultiTool_MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(250, 430);
            this.Controls.Add(this.Another_label);
            this.Controls.Add(this.AnotherCount_label);
            this.Controls.Add(this.HddCount_label);
            this.Controls.Add(this.Hdd_label);
            this.Controls.Add(this.Ram_label);
            this.Controls.Add(this.RamCount_label);
            this.Controls.Add(this.Another_panel);
            this.Controls.Add(this.HddRate_panel);
            this.Controls.Add(this.RamRate_panel);
            this.Controls.Add(this.Video_Panel);
            this.Controls.Add(this.CpuRate_panel);
            this.Controls.Add(this.CpuCount_label);
            this.Controls.Add(this.Cpu_label);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "W8MultiTool_MainView";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox Exit_PicBox;
        private System.Windows.Forms.PictureBox Max_PicBox;
        private System.Windows.Forms.Label Clock_label;
        private System.Windows.Forms.Label Cpu_label;
        private System.Windows.Forms.Label CpuCount_label;
        private System.Windows.Forms.Panel CpuRate_panel;
        private System.Windows.Forms.Label Another_label;
        private System.Windows.Forms.Label AnotherCount_label;
        private System.Windows.Forms.Label HddCount_label;
        private System.Windows.Forms.Label Hdd_label;
        private System.Windows.Forms.Label Ram_label;
        private System.Windows.Forms.Label RamCount_label;
        private System.Windows.Forms.Panel Another_panel;
        private System.Windows.Forms.Panel HddRate_panel;
        private System.Windows.Forms.Panel RamRate_panel;
        private System.Windows.Forms.Panel Video_Panel;
        private System.Windows.Forms.Timer timer_W8;
    }
}

