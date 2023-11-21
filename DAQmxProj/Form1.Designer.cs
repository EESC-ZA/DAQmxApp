namespace DAQmxProj
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelReadTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.channelFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.channelGroupBox = new System.Windows.Forms.GroupBox();
            this.CJCSourceValue = new System.Windows.Forms.Label();
            this.CJCSourceLabel = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.maximumValueLabel = new System.Windows.Forms.Label();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.ThermocoupleTypeValue = new System.Windows.Forms.Label();
            this.ThermocoupleTypeLabel = new System.Windows.Forms.Label();
            this.PhysicalChannelValueLabel = new System.Windows.Forms.Label();
            this.channelNameLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.TemperatureValueLabel = new System.Windows.Forms.Label();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.channelFlowLayoutPanel.SuspendLayout();
            this.channelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channellToolStripMenuItem,
            this.sessionToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // channellToolStripMenuItem
            // 
            this.channellToolStripMenuItem.Name = "channellToolStripMenuItem";
            this.channellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.channellToolStripMenuItem.Text = "Channel";
            this.channellToolStripMenuItem.Click += new System.EventHandler(this.channellToolStripMenuItem_Click);
            // 
            // channelReadTimer
            // 
            this.channelReadTimer.Interval = 1000;
            this.channelReadTimer.Tick += new System.EventHandler(this.channelReadTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // channelFlowLayoutPanel
            // 
            this.channelFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelFlowLayoutPanel.Controls.Add(this.channelGroupBox);
            this.channelFlowLayoutPanel.ForeColor = System.Drawing.Color.ForestGreen;
            this.channelFlowLayoutPanel.Location = new System.Drawing.Point(159, 52);
            this.channelFlowLayoutPanel.Name = "channelFlowLayoutPanel";
            this.channelFlowLayoutPanel.Size = new System.Drawing.Size(692, 361);
            this.channelFlowLayoutPanel.TabIndex = 3;
            // 
            // channelGroupBox
            // 
            this.channelGroupBox.BackColor = System.Drawing.Color.LightPink;
            this.channelGroupBox.Controls.Add(this.CJCSourceValue);
            this.channelGroupBox.Controls.Add(this.CJCSourceLabel);
            this.channelGroupBox.Controls.Add(this.maxValueLabel);
            this.channelGroupBox.Controls.Add(this.maximumValueLabel);
            this.channelGroupBox.Controls.Add(this.minValueLabel);
            this.channelGroupBox.Controls.Add(this.minimumLabel);
            this.channelGroupBox.Controls.Add(this.ThermocoupleTypeValue);
            this.channelGroupBox.Controls.Add(this.ThermocoupleTypeLabel);
            this.channelGroupBox.Controls.Add(this.PhysicalChannelValueLabel);
            this.channelGroupBox.Controls.Add(this.channelNameLabel);
            this.channelGroupBox.Controls.Add(this.TemperatureLabel);
            this.channelGroupBox.Controls.Add(this.TemperatureValueLabel);
            this.channelGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.channelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.channelGroupBox.Name = "channelGroupBox";
            this.channelGroupBox.Size = new System.Drawing.Size(156, 159);
            this.channelGroupBox.TabIndex = 0;
            this.channelGroupBox.TabStop = false;
            this.channelGroupBox.Text = "groupBox1";
            this.channelGroupBox.Visible = false;
            // 
            // CJCSourceValue
            // 
            this.CJCSourceValue.AutoSize = true;
            this.CJCSourceValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CJCSourceValue.ForeColor = System.Drawing.Color.Black;
            this.CJCSourceValue.Location = new System.Drawing.Point(88, 127);
            this.CJCSourceValue.Name = "CJCSourceValue";
            this.CJCSourceValue.Size = new System.Drawing.Size(16, 15);
            this.CJCSourceValue.TabIndex = 11;
            this.CJCSourceValue.Text = "Q";
            // 
            // CJCSourceLabel
            // 
            this.CJCSourceLabel.AutoSize = true;
            this.CJCSourceLabel.ForeColor = System.Drawing.Color.Black;
            this.CJCSourceLabel.Location = new System.Drawing.Point(9, 127);
            this.CJCSourceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CJCSourceLabel.Name = "CJCSourceLabel";
            this.CJCSourceLabel.Size = new System.Drawing.Size(68, 15);
            this.CJCSourceLabel.TabIndex = 10;
            this.CJCSourceLabel.Text = "CJC source:";
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxValueLabel.ForeColor = System.Drawing.Color.Black;
            this.maxValueLabel.Location = new System.Drawing.Point(88, 106);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(28, 15);
            this.maxValueLabel.TabIndex = 9;
            this.maxValueLabel.Text = "000";
            // 
            // maximumValueLabel
            // 
            this.maximumValueLabel.AutoSize = true;
            this.maximumValueLabel.ForeColor = System.Drawing.Color.Black;
            this.maximumValueLabel.Location = new System.Drawing.Point(9, 106);
            this.maximumValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.maximumValueLabel.Name = "maximumValueLabel";
            this.maximumValueLabel.Size = new System.Drawing.Size(33, 15);
            this.maximumValueLabel.TabIndex = 8;
            this.maximumValueLabel.Text = "Max:";
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minValueLabel.ForeColor = System.Drawing.Color.Black;
            this.minValueLabel.Location = new System.Drawing.Point(88, 85);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(28, 15);
            this.minValueLabel.TabIndex = 7;
            this.minValueLabel.Text = "000";
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.ForeColor = System.Drawing.Color.Black;
            this.minimumLabel.Location = new System.Drawing.Point(9, 85);
            this.minimumLabel.Margin = new System.Windows.Forms.Padding(3);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(31, 15);
            this.minimumLabel.TabIndex = 6;
            this.minimumLabel.Text = "Min:";
            // 
            // ThermocoupleTypeValue
            // 
            this.ThermocoupleTypeValue.AutoSize = true;
            this.ThermocoupleTypeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThermocoupleTypeValue.ForeColor = System.Drawing.Color.Black;
            this.ThermocoupleTypeValue.Location = new System.Drawing.Point(88, 64);
            this.ThermocoupleTypeValue.Name = "ThermocoupleTypeValue";
            this.ThermocoupleTypeValue.Size = new System.Drawing.Size(33, 15);
            this.ThermocoupleTypeValue.TabIndex = 5;
            this.ThermocoupleTypeValue.Text = "Type";
            // 
            // ThermocoupleTypeLabel
            // 
            this.ThermocoupleTypeLabel.AutoSize = true;
            this.ThermocoupleTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.ThermocoupleTypeLabel.Location = new System.Drawing.Point(6, 64);
            this.ThermocoupleTypeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThermocoupleTypeLabel.Name = "ThermocoupleTypeLabel";
            this.ThermocoupleTypeLabel.Size = new System.Drawing.Size(34, 15);
            this.ThermocoupleTypeLabel.TabIndex = 4;
            this.ThermocoupleTypeLabel.Text = "Type:";
            // 
            // PhysicalChannelValueLabel
            // 
            this.PhysicalChannelValueLabel.AutoSize = true;
            this.PhysicalChannelValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhysicalChannelValueLabel.ForeColor = System.Drawing.Color.Black;
            this.PhysicalChannelValueLabel.Location = new System.Drawing.Point(88, 43);
            this.PhysicalChannelValueLabel.Name = "PhysicalChannelValueLabel";
            this.PhysicalChannelValueLabel.Size = new System.Drawing.Size(51, 15);
            this.PhysicalChannelValueLabel.TabIndex = 3;
            this.PhysicalChannelValueLabel.Text = "Channel";
            // 
            // channelNameLabel
            // 
            this.channelNameLabel.AutoSize = true;
            this.channelNameLabel.ForeColor = System.Drawing.Color.Black;
            this.channelNameLabel.Location = new System.Drawing.Point(6, 43);
            this.channelNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.channelNameLabel.Name = "channelNameLabel";
            this.channelNameLabel.Size = new System.Drawing.Size(54, 15);
            this.channelNameLabel.TabIndex = 2;
            this.channelNameLabel.Text = "Channel:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.ForeColor = System.Drawing.Color.Black;
            this.TemperatureLabel.Location = new System.Drawing.Point(6, 22);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(76, 15);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Temperature:";
            // 
            // TemperatureValueLabel
            // 
            this.TemperatureValueLabel.AutoSize = true;
            this.TemperatureValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TemperatureValueLabel.ForeColor = System.Drawing.Color.Black;
            this.TemperatureValueLabel.Location = new System.Drawing.Point(88, 22);
            this.TemperatureValueLabel.Name = "TemperatureValueLabel";
            this.TemperatureValueLabel.Size = new System.Drawing.Size(45, 15);
            this.TemperatureValueLabel.TabIndex = 0;
            this.TemperatureValueLabel.Text = "0.0000";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 448);
            this.Controls.Add(this.channelFlowLayoutPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.channelFlowLayoutPanel.ResumeLayout(false);
            this.channelGroupBox.ResumeLayout(false);
            this.channelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem channellToolStripMenuItem;
        private System.Windows.Forms.Timer channelReadTimer;
        private Button button1;
        private FlowLayoutPanel channelFlowLayoutPanel;
        private GroupBox channelGroupBox;
        private Label ThermocoupleTypeValue;
        private Label ThermocoupleTypeLabel;
        private Label PhysicalChannelValueLabel;
        private Label channelNameLabel;
        private Label TemperatureLabel;
        private Label TemperatureValueLabel;
        private Label maxValueLabel;
        private Label maximumValueLabel;
        private Label minValueLabel;
        private Label minimumLabel;
        private Label CJCSourceValue;
        private Label CJCSourceLabel;
        private ToolStripMenuItem sessionToolStripMenuItem;
    }
}