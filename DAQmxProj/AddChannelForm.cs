using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQmxProj
{
    public partial class NewChannelForm : Form
    {
        NewChannelForm newChannelForm;
        string[] AIchannels;
        public NewChannelForm( )
        {
            InitializeComponent();
            cjcSourceComboBox.SelectedIndex = 2;
            thermocoupleTypeComboBox.SelectedIndex = 2;
            physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;
            else
            {
                MessageBox.Show("physical Channels found\n");
            }

        }
        private void cjcSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cjcSourceComboBox.SelectedIndex)
            {
                case 0: // Channel
                    cjcChannelComboBox.Enabled = true;
                    cjcValueNumeric.Enabled = false;
                    break;
                case 1: // Constant 
                    cjcChannelComboBox.Enabled = false;
                    cjcValueNumeric.Enabled = true;
                    break;
                case 2: // Internal
                    cjcChannelComboBox.Enabled = false;
                    cjcValueNumeric.Enabled = false;
                    break;
            }
        }

    }
}
