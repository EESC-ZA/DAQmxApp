namespace DAQmxProj
{
    partial class NewChannelForm
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
            this.channelPrarametersGroupBox = new System.Windows.Forms.GroupBox();
            this.channelNameTextBox = new System.Windows.Forms.TextBox();
            this.channelNameLabel = new System.Windows.Forms.Label();
            this.minimumValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.maximumValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.physicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.timingParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            this.rateLabel = new System.Windows.Forms.Label();
            this.thermocoupleParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.thermocoupleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.thermocoupleTypeLabel = new System.Windows.Forms.Label();
            this.coldJunctionParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.cjcChannelComboBox = new System.Windows.Forms.ComboBox();
            this.cjcValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.cjcValueLabel = new System.Windows.Forms.Label();
            this.cjcChannelLabel = new System.Windows.Forms.Label();
            this.cjcSourceComboBox = new System.Windows.Forms.ComboBox();
            this.cjcSourceLabel = new System.Windows.Forms.Label();
            this.addChannelButton = new System.Windows.Forms.Button();
            this.channelPrarametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumValueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumValueNumeric)).BeginInit();
            this.timingParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
            this.thermocoupleParametersGroupBox.SuspendLayout();
            this.coldJunctionParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cjcValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // channelPrarametersGroupBox
            // 
            this.channelPrarametersGroupBox.Controls.Add(this.channelNameTextBox);
            this.channelPrarametersGroupBox.Controls.Add(this.channelNameLabel);
            this.channelPrarametersGroupBox.Controls.Add(this.minimumValueNumeric);
            this.channelPrarametersGroupBox.Controls.Add(this.minimumLabel);
            this.channelPrarametersGroupBox.Controls.Add(this.maximumValueNumeric);
            this.channelPrarametersGroupBox.Controls.Add(this.maximumLabel);
            this.channelPrarametersGroupBox.Controls.Add(this.physicalChannelComboBox);
            this.channelPrarametersGroupBox.Controls.Add(this.physicalChannelLabel);
            this.channelPrarametersGroupBox.Location = new System.Drawing.Point(12, 12);
            this.channelPrarametersGroupBox.Name = "channelPrarametersGroupBox";
            this.channelPrarametersGroupBox.Size = new System.Drawing.Size(292, 155);
            this.channelPrarametersGroupBox.TabIndex = 0;
            this.channelPrarametersGroupBox.TabStop = false;
            this.channelPrarametersGroupBox.Text = "Channel Parameters";
            // 
            // channelNameTextBox
            // 
            this.channelNameTextBox.Location = new System.Drawing.Point(139, 120);
            this.channelNameTextBox.Name = "channelNameTextBox";
            this.channelNameTextBox.PlaceholderText = "Friendly channel name";
            this.channelNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.channelNameTextBox.TabIndex = 7;
            // 
            // channelNameLabel
            // 
            this.channelNameLabel.AutoSize = true;
            this.channelNameLabel.Location = new System.Drawing.Point(18, 123);
            this.channelNameLabel.Name = "channelNameLabel";
            this.channelNameLabel.Size = new System.Drawing.Size(89, 15);
            this.channelNameLabel.TabIndex = 6;
            this.channelNameLabel.Text = "Channel Name:";
            // 
            // minimumValueNumeric
            // 
            this.minimumValueNumeric.Location = new System.Drawing.Point(140, 85);
            this.minimumValueNumeric.Name = "minimumValueNumeric";
            this.minimumValueNumeric.Size = new System.Drawing.Size(146, 23);
            this.minimumValueNumeric.TabIndex = 5;
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(18, 87);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(105, 15);
            this.minimumLabel.TabIndex = 4;
            this.minimumLabel.Text = "Minimum (deg C):";
            // 
            // maximumValueNumeric
            // 
            this.maximumValueNumeric.Location = new System.Drawing.Point(140, 51);
            this.maximumValueNumeric.Name = "maximumValueNumeric";
            this.maximumValueNumeric.Size = new System.Drawing.Size(146, 23);
            this.maximumValueNumeric.TabIndex = 3;
            this.maximumValueNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(18, 54);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(107, 15);
            this.maximumLabel.TabIndex = 2;
            this.maximumLabel.Text = "Maximum (deg C):";
            // 
            // physicalChannelComboBox
            // 
            this.physicalChannelComboBox.FormattingEnabled = true;
            this.physicalChannelComboBox.Location = new System.Drawing.Point(139, 22);
            this.physicalChannelComboBox.Name = "physicalChannelComboBox";
            this.physicalChannelComboBox.Size = new System.Drawing.Size(147, 23);
            this.physicalChannelComboBox.TabIndex = 1;
            this.physicalChannelComboBox.Text = "Select channel";
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.AutoSize = true;
            this.physicalChannelLabel.Location = new System.Drawing.Point(18, 25);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(100, 15);
            this.physicalChannelLabel.TabIndex = 0;
            this.physicalChannelLabel.Text = "Physical Channel:";
            // 
            // timingParametersGroupBox
            // 
            this.timingParametersGroupBox.Controls.Add(this.rateNumeric);
            this.timingParametersGroupBox.Controls.Add(this.rateLabel);
            this.timingParametersGroupBox.Location = new System.Drawing.Point(12, 173);
            this.timingParametersGroupBox.Name = "timingParametersGroupBox";
            this.timingParametersGroupBox.Size = new System.Drawing.Size(292, 57);
            this.timingParametersGroupBox.TabIndex = 1;
            this.timingParametersGroupBox.TabStop = false;
            this.timingParametersGroupBox.Text = "Timing Parameters";
            // 
            // rateNumeric
            // 
            this.rateNumeric.Location = new System.Drawing.Point(139, 26);
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(147, 23);
            this.rateNumeric.TabIndex = 6;
            this.rateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(18, 28);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(58, 15);
            this.rateLabel.TabIndex = 0;
            this.rateLabel.Text = "Rate (Hz):";
            // 
            // thermocoupleParametersGroupBox
            // 
            this.thermocoupleParametersGroupBox.Controls.Add(this.thermocoupleTypeComboBox);
            this.thermocoupleParametersGroupBox.Controls.Add(this.thermocoupleTypeLabel);
            this.thermocoupleParametersGroupBox.Location = new System.Drawing.Point(12, 236);
            this.thermocoupleParametersGroupBox.Name = "thermocoupleParametersGroupBox";
            this.thermocoupleParametersGroupBox.Size = new System.Drawing.Size(292, 58);
            this.thermocoupleParametersGroupBox.TabIndex = 2;
            this.thermocoupleParametersGroupBox.TabStop = false;
            this.thermocoupleParametersGroupBox.Text = "Thermocouple Parameters";
            // 
            // thermocoupleTypeComboBox
            // 
            this.thermocoupleTypeComboBox.FormattingEnabled = true;
            this.thermocoupleTypeComboBox.Items.AddRange(new object[] {
            "B",
            "E",
            "J",
            "K",
            "N",
            "R",
            "S",
            "T"});
            this.thermocoupleTypeComboBox.Location = new System.Drawing.Point(138, 25);
            this.thermocoupleTypeComboBox.Name = "thermocoupleTypeComboBox";
            this.thermocoupleTypeComboBox.Size = new System.Drawing.Size(148, 23);
            this.thermocoupleTypeComboBox.TabIndex = 6;
            // 
            // thermocoupleTypeLabel
            // 
            this.thermocoupleTypeLabel.AutoSize = true;
            this.thermocoupleTypeLabel.Location = new System.Drawing.Point(6, 28);
            this.thermocoupleTypeLabel.Name = "thermocoupleTypeLabel";
            this.thermocoupleTypeLabel.Size = new System.Drawing.Size(114, 15);
            this.thermocoupleTypeLabel.TabIndex = 0;
            this.thermocoupleTypeLabel.Text = "Thermocouple Type:";
            // 
            // coldJunctionParametersGroupBox
            // 
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcChannelComboBox);
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcValueNumeric);
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcValueLabel);
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcChannelLabel);
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcSourceComboBox);
            this.coldJunctionParametersGroupBox.Controls.Add(this.cjcSourceLabel);
            this.coldJunctionParametersGroupBox.Location = new System.Drawing.Point(12, 300);
            this.coldJunctionParametersGroupBox.Name = "coldJunctionParametersGroupBox";
            this.coldJunctionParametersGroupBox.Size = new System.Drawing.Size(292, 120);
            this.coldJunctionParametersGroupBox.TabIndex = 3;
            this.coldJunctionParametersGroupBox.TabStop = false;
            this.coldJunctionParametersGroupBox.Text = "Cold Junction Parameters";
            // 
            // cjcChannelComboBox
            // 
            this.cjcChannelComboBox.FormattingEnabled = true;
            this.cjcChannelComboBox.Location = new System.Drawing.Point(138, 57);
            this.cjcChannelComboBox.Name = "cjcChannelComboBox";
            this.cjcChannelComboBox.Size = new System.Drawing.Size(148, 23);
            this.cjcChannelComboBox.TabIndex = 8;
            // 
            // cjcValueNumeric
            // 
            this.cjcValueNumeric.Location = new System.Drawing.Point(139, 88);
            this.cjcValueNumeric.Name = "cjcValueNumeric";
            this.cjcValueNumeric.Size = new System.Drawing.Size(147, 23);
            this.cjcValueNumeric.TabIndex = 7;
            this.cjcValueNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cjcValueLabel
            // 
            this.cjcValueLabel.AutoSize = true;
            this.cjcValueLabel.Location = new System.Drawing.Point(21, 90);
            this.cjcValueLabel.Name = "cjcValueLabel";
            this.cjcValueLabel.Size = new System.Drawing.Size(103, 15);
            this.cjcValueLabel.TabIndex = 4;
            this.cjcValueLabel.Text = "CJC Value (deg C):";
            // 
            // cjcChannelLabel
            // 
            this.cjcChannelLabel.AutoSize = true;
            this.cjcChannelLabel.Location = new System.Drawing.Point(18, 60);
            this.cjcChannelLabel.Name = "cjcChannelLabel";
            this.cjcChannelLabel.Size = new System.Drawing.Size(77, 15);
            this.cjcChannelLabel.TabIndex = 2;
            this.cjcChannelLabel.Text = "CJC Channel:";
            // 
            // cjcSourceComboBox
            // 
            this.cjcSourceComboBox.FormattingEnabled = true;
            this.cjcSourceComboBox.Items.AddRange(new object[] {
            "Channel",
            "Constant Value",
            "Internal"});
            this.cjcSourceComboBox.Location = new System.Drawing.Point(138, 26);
            this.cjcSourceComboBox.Name = "cjcSourceComboBox";
            this.cjcSourceComboBox.Size = new System.Drawing.Size(148, 23);
            this.cjcSourceComboBox.TabIndex = 1;
            this.cjcSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.cjcSourceComboBox_SelectedIndexChanged);
            // 
            // cjcSourceLabel
            // 
            this.cjcSourceLabel.AutoSize = true;
            this.cjcSourceLabel.Location = new System.Drawing.Point(18, 29);
            this.cjcSourceLabel.Name = "cjcSourceLabel";
            this.cjcSourceLabel.Size = new System.Drawing.Size(69, 15);
            this.cjcSourceLabel.TabIndex = 0;
            this.cjcSourceLabel.Text = "CJC Source:";
            // 
            // addChannelButton
            // 
            this.addChannelButton.Location = new System.Drawing.Point(115, 426);
            this.addChannelButton.Name = "addChannelButton";
            this.addChannelButton.Size = new System.Drawing.Size(98, 23);
            this.addChannelButton.TabIndex = 4;
            this.addChannelButton.Text = "Add Channel";
            this.addChannelButton.UseVisualStyleBackColor = true;
            // 
            // NewChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 461);
            this.Controls.Add(this.addChannelButton);
            this.Controls.Add(this.coldJunctionParametersGroupBox);
            this.Controls.Add(this.thermocoupleParametersGroupBox);
            this.Controls.Add(this.timingParametersGroupBox);
            this.Controls.Add(this.channelPrarametersGroupBox);
            this.Name = "NewChannelForm";
            this.Text = "New Channel";
            this.channelPrarametersGroupBox.ResumeLayout(false);
            this.channelPrarametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumValueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumValueNumeric)).EndInit();
            this.timingParametersGroupBox.ResumeLayout(false);
            this.timingParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            this.thermocoupleParametersGroupBox.ResumeLayout(false);
            this.thermocoupleParametersGroupBox.PerformLayout();
            this.coldJunctionParametersGroupBox.ResumeLayout(false);
            this.coldJunctionParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cjcValueNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox channelPrarametersGroupBox;
        public NumericUpDown minimumValueNumeric;
        private Label minimumLabel;
        public NumericUpDown maximumValueNumeric;
        private Label maximumLabel;
        public ComboBox physicalChannelComboBox;
        private Label physicalChannelLabel;
        private GroupBox timingParametersGroupBox;
        public NumericUpDown rateNumeric;
        private Label rateLabel;
        private GroupBox thermocoupleParametersGroupBox;
        public ComboBox thermocoupleTypeComboBox;
        private Label thermocoupleTypeLabel;
        private GroupBox coldJunctionParametersGroupBox;
        public NumericUpDown cjcValueNumeric;
        private Label cjcValueLabel;
        private Label cjcChannelLabel;
        public ComboBox cjcSourceComboBox;
        private Label cjcSourceLabel;
        public Button addChannelButton;
        public ComboBox cjcChannelComboBox;
        public TextBox channelNameTextBox;
        private Label channelNameLabel;
    }
}