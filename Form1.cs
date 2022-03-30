namespace ScaleBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cbxScale_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var client = new ScaleBot.Shared.PitchClient.ApiClient("http://localhost:8000");

            var recordingStatus = client.Start();
            if (recordingStatus != null)
            {
                MessageBox.Show("Recording scale");
            }
            else
            {
                MessageBox.Show("Start: error occured");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var client = new ScaleBot.Shared.PitchClient.ApiClient("http://localhost:8000");

            var stopResult = client.Stop();
            if (stopResult != null)
            {
                if (stopResult.Scale == "doesn't match")
                {
                    MessageBox.Show("Scale: " + stopResult.Scale);
                }
                else
                {
                    MessageBox.Show("PercentAccuracy: " + stopResult.PercentAccuracy);
                }
            }
            else
            {
                MessageBox.Show("Stop: error occured");
            }
        }
    }
}