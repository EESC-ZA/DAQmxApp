using NationalInstruments.DAQmx;
using System.Threading.Tasks;

namespace DAQmxProj
{
    public partial class Form1 : Form
    {
        NationalInstruments.DAQmx.Task? analogInTask;

        private DAQmxChannel? dAQmxChannel;
        private DataReader dataReader;

        public AnalogMultiChannelReader analogInReader;



      //  List<NationalInstruments.DAQmx.Task> DAQmxTasks;
        List<DAQmxChannel> dAQmxChannels;
        public Form1()
        {
            InitializeComponent();

            dAQmxChannels = new List<DAQmxChannel>();

            analogInTask = new NationalInstruments.DAQmx.Task();
            dataReader = new DataReader();
            analogInReader = new AnalogMultiChannelReader(analogInTask.Stream);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void channellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dAQmxChannel = new DAQmxChannel();
           dAQmxChannel.getNewChannelForm().addChannelButton.Click += AddChannelButton_Click;


        }

        private void AddChannelButton_Click(object? sender, EventArgs e)
         {
             if (analogInTask != null)
                try
                {
                    if (dAQmxChannel != null)
                    {
                        switch (dAQmxChannel.getCJCSource())
                        {
                            case 0:    ///cjc channel                    
                                dAQmxChannel.aIChannel = analogInTask.AIChannels.CreateThermocoupleChannel(dAQmxChannel.getPhysicalChannel(),
                                     "", dAQmxChannel.getMinTemperature(), dAQmxChannel.getMaxTemperature(),
                                  dAQmxChannel.getAIThermocoupleType(), AITemperatureUnits.DegreesC, dAQmxChannel.getCJCChannel());
                                break;
                            case 1:    //Constant
                                dAQmxChannel.aIChannel = analogInTask.AIChannels.CreateThermocoupleChannel(dAQmxChannel.getPhysicalChannel(),
                                     "", dAQmxChannel.getMinTemperature(), dAQmxChannel.getMaxTemperature(),
                                  dAQmxChannel.getAIThermocoupleType(), AITemperatureUnits.DegreesC, dAQmxChannel.getTemperatureConstant());
                                break;
                            case 2:     //internal
                                dAQmxChannel.aIChannel = analogInTask.AIChannels.CreateThermocoupleChannel(dAQmxChannel.getPhysicalChannel(),
                                    "", dAQmxChannel.getMinTemperature(), dAQmxChannel.getMaxTemperature(),
                                dAQmxChannel.getAIThermocoupleType(), AITemperatureUnits.DegreesC);
                                break;
                        }
                        dAQmxChannel.aIChannel.AutoZeroMode = AIAutoZeroMode.Once;

                        analogInTask.Timing.ConfigureSampleClock("", dAQmxChannel.getRate(), SampleClockActiveEdge.Rising,
                            SampleQuantityMode.ContinuousSamples, 1);
                        analogInTask.Control(TaskAction.Verify);
                        analogInReader.SynchronizeCallbacks = true;


                        dAQmxChannels.Add(dAQmxChannel);

                       foreach (DAQmxChannel channel in dAQmxChannels)
                        {
                            this.channelFlowLayoutPanel.Controls.Add(channel.channelGroupBox);
                            //MessageBox.Show(Math.Round(dAQmxDataReader.getTemperature(channel.PhysicalChannel), 4).ToString());
                            //channel.show();
                        }
                    }
                }catch(DaqException exception)
                 {
                        MessageBox.Show(exception.Message);
                        analogInTask.Dispose();
                 }
        }

        private void channelReadTimer_Tick(object sender, EventArgs e)
        {
            double [] data = analogInReader.ReadSingleSample();
            int i = 0;
            foreach(DAQmxChannel channel in dAQmxChannels)
            {
                channel.TemperatureValueLabel.Text = Math.Round(data[i],4).ToString();
                channel.PhysicalChannelValueLabel.Text = channel.getChannelName();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //analogInReader.
           channelReadTimer.Start();
        //    foreach (DAQmxChannel channel in dAQmxChannels)
            {
                //MessageBox.Show(Math.Round(dAQmxDataReader.getTemperature(channel.PhysicalChannel), 4).ToString());
       //         channel.show();
            }
        }
    }
}