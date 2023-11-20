using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DAQmxProj
{

    internal class DAQmxChannel 
    {
        private string[] _channels;
        private NewChannelForm ?NewChannelForm;
        private string PhysicalChannel;
        private string channelName;
        private string CJCChannel;
        private int CJCSource;
        private double MaximumTemp;
        private double MinimumTemp;
        private AIThermocoupleType thermocoupleType;
        private AIAutoZeroMode autoZeroMode;

        private double Rate;
        private double CJCValue;
        private string ThermocoupleType;

        public AIChannel aIChannel;


        public GroupBox channelGroupBox;

        public int getCJCSource()
        {
            return CJCSource;
        }

        public string getChannelName()
        {
            return channelName;
        }

        public string getPhysicalChannel()
        {
            return PhysicalChannel;
        }
        public NewChannelForm? getNewChannelForm()
        {
                if(NewChannelForm != null)
                return NewChannelForm;
            return null;
        }

        public double getMinTemperature()
        {
            return MinimumTemp;
        }

        public double getMaxTemperature()
        {
            return MaximumTemp;
        }

        public AIThermocoupleType getAIThermocoupleType()
        {
            return thermocoupleType;
        }

        public string getCJCChannel()
        {
            return CJCChannel;
        }

        public double getTemperatureConstant()
        {
            return CJCValue;
        }

        public double getRate()
        {
            return Rate;
        }

        public DAQmxChannel() {
            channelGroupBox = new GroupBox();
            initializeComponents();       
             NewChannelForm = new NewChannelForm();
             NewChannelForm.addChannelButton.Click += AddChannelButton_Click;
             NewChannelForm.Show();
             NewChannelForm.physicalChannelComboBox.SelectedIndex = 0;
            _channels = DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External);
        }

        public void show()
        {
           channelGroupBox.Show();
        }

        private void AddChannelButton_Click(object? sender, EventArgs e)
        {
            if (NewChannelForm != null)
            {
                PhysicalChannel = NewChannelForm.physicalChannelComboBox.Text;
                Rate = (double)NewChannelForm.rateNumeric.Value;
                MinimumTemp = (double)NewChannelForm.minimumValueNumeric.Value;
                MaximumTemp = (double)NewChannelForm.maximumValueNumeric.Value;
                CJCValue = (double)NewChannelForm.cjcValueNumeric.Value;
                CJCChannel = NewChannelForm.cjcChannelComboBox.Text;
                channelName = NewChannelForm.channelNameTextBox.Text;
                CJCSource = NewChannelForm.cjcSourceComboBox.SelectedIndex;

                PhysicalChannelValueLabel.Text = channelName;
                channelGroupBox.Text = PhysicalChannel;
                ThermocoupleTypeValueLabel.Text = ThermocoupleType;
                TemperatureValueLabel.Text = CJCValue.ToString();
                ThermocoupleTypeValueLabel.Text = NewChannelForm.thermocoupleTypeComboBox.Text;

                switch (NewChannelForm.thermocoupleTypeComboBox.SelectedIndex)
                {
                    case 0:
                        thermocoupleType = AIThermocoupleType.B;
                        break;
                    case 1:
                        thermocoupleType = AIThermocoupleType.E;
                        break;
                    case 2:
                        thermocoupleType = AIThermocoupleType.J;
                        break;
                    case 3:
                        thermocoupleType = AIThermocoupleType.K;
                        break;
                    case 4:
                        thermocoupleType = AIThermocoupleType.N;
                        break;
                    case 5:
                        thermocoupleType = AIThermocoupleType.R;
                        break;
                    case 6:
                        thermocoupleType = AIThermocoupleType.S;
                        break;
                    case 7:
                    default:
                        thermocoupleType = AIThermocoupleType.T;
                        break;
                }

                autoZeroMode = AIAutoZeroMode.None;
                /*
                if (scxiModuleCheckBox.Checked)
                {
                    switch (autoZeroModeComboBox.SelectedIndex)
                    {
                        case 0:
                            autoZeroMode = AIAutoZeroMode.None;
                            break;
                        case 1:
                        default:
                            autoZeroMode = AIAutoZeroMode.Once;
                            break;
                    }

                }*/
                NewChannelForm.Close();
            }       
        }
        private void initializeComponents()
        {
            this.channelGroupBox = new System.Windows.Forms.GroupBox();
            this.ThermocoupleTypeLabel = new System.Windows.Forms.Label();
            this.PhysicalChannelValueLabel = new System.Windows.Forms.Label();
            this.channelNameLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.TemperatureValueLabel = new System.Windows.Forms.Label();
            this.TemperatureValueLabel = new System.Windows.Forms.Label();
            this.ThermocoupleTypeValueLabel = new System.Windows.Forms.Label();

            // 
            // channelGroupBox
            // 
            this.channelGroupBox.BackColor = System.Drawing.Color.Bisque;
            this.channelGroupBox.Controls.Add(this.ThermocoupleTypeValueLabel);
            this.channelGroupBox.Controls.Add(this.ThermocoupleTypeLabel);
            this.channelGroupBox.Controls.Add(this.PhysicalChannelValueLabel);
            this.channelGroupBox.Controls.Add(this.channelNameLabel);
            this.channelGroupBox.Controls.Add(this.TemperatureLabel);
            this.channelGroupBox.Controls.Add(this.TemperatureValueLabel);
            this.channelGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.channelGroupBox.Location = new System.Drawing.Point(3, 3);
            this.channelGroupBox.Name = "channelGroupBox";
            this.channelGroupBox.Size = new System.Drawing.Size(170, 87);
            this.channelGroupBox.TabIndex = 0;
            this.channelGroupBox.TabStop = false;
            this.channelGroupBox.Text = "Physical channel";
            // 
            // ThermocoupleTypeValue
            // 
            this.ThermocoupleTypeValueLabel.AutoSize = true;
            this.ThermocoupleTypeValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThermocoupleTypeValueLabel.ForeColor = System.Drawing.Color.Black;
            this.ThermocoupleTypeValueLabel.Location = new System.Drawing.Point(88, 64);
            this.ThermocoupleTypeValueLabel.Name = "ThermocoupleTypeValue";
            this.ThermocoupleTypeValueLabel.Size = new System.Drawing.Size(33, 15);
            this.ThermocoupleTypeValueLabel.TabIndex = 5;
            this.ThermocoupleTypeValueLabel.Text = "Type";
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
        }



        public Label TemperatureValueLabel;
        public Label ThermocoupleTypeValueLabel;
        private Label ThermocoupleTypeLabel;
        public Label PhysicalChannelValueLabel;
        private Label TemperatureLabel;
        private Label channelNameLabel;
    }
}
