using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CliWrap;

namespace deneme1
{
    public partial class progressBar1 : Form
    {
        string output;
        private Process proc = new Process();
        public double Progress { get; set; }
        public progressBar1()
        {
            InitializeComponent();
        }

        private void input_lbl_Click(object sender, EventArgs e)
        {

        }

        private void inputSelect_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Source Video";
            ofd.Filter = "Supported Video File(*.avi, *.flv, *.mov, *.mp4)|*.avi; *.flv; *.mov; *.mp4";
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string input = ofd.FileName;
                input1_txtbox.Text = input;
                string temp = Path.GetFileName(input);
                //output = System.IO.Path.Combine(Application.StartupPath + "/saveVideo/" + temp);
                axWindowsMediaPlayer3.URL = input1_txtbox.Text;
                axWindowsMediaPlayer3.Ctlcontrols.play();

            }
        }

        private void starting_btn_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();
            Process proc = new Process();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            StartConvert();
            


        }
        
        private async void StartConvert()
        {
            Process proc = new Process();
            Control.CheckForIllegalCrossThreadCalls = false;
            var cmd = Cli.Wrap("ffmpeg")
                .WithValidation(CommandResultValidation.None)
                .WithArguments(args => args
                    .Add("-i").Add(input1_txtbox.Text)
                    .Add("-i").Add(logoInput_txtbox.Text)
                    .Add("-filter_complex").Add("overlay=0:0")
                    .Add("-codec:a").Add("copy")
                    .Add(output1_txtbox.Text)
                    
                ) | (Console.WriteLine, Console.Error.WriteLine);

            await cmd.ExecuteAsync();

            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.CreateNoWindow = true;
            //proc.Start();
          
           
            StreamReader sr = proc.StandardError;
            while (!sr.EndOfStream)
            {
                getTotalSecondProcessed(sr.ReadLine());
            }


        }
        private void getTotalSecondProcessed(string line)
        {
           
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          

        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Complete...");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker3.WorkerReportsProgress = true;
        }

        private void logoInput_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoSelect_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Title = "Select Logo";
            ofd1.Filter = "Supported Logo File(*.png)|*.png";
            if (ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string input1 = ofd1.FileName;
                logoInput_txtbox.Text = input1;
                string temp1 = Path.GetFileName(input1);
                output = System.IO.Path.Combine(Application.StartupPath + @"C:\C:\c_ffmpeg_video\input_files" + temp1);
                axWindowsMediaPlayer4.URL = logoInput_txtbox.Text;
                axWindowsMediaPlayer4.Ctlcontrols.play();

            }
        }

        private void input1_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void output1_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoInput_lbl_Click(object sender, EventArgs e)
        {

        }

        private void output_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
