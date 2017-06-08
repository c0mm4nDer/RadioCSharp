using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;
using System.Diagnostics;
using NAudio.CoreAudioApi;
using System.ComponentModel.Composition;
using RadioCSharp.Properties;

namespace RadioCSharp
{
    public partial class RecordingPanelVLC : UserControl
    {
        public string URL { get; set; }
        private string outputFilename;
        private readonly string outputFolder;
        bool mIsRecording = false;
        Vlc.DotNet.Core.VlcMediaPlayer mVlc;


        public RecordingPanelVLC()
        {
            InitializeComponent();

            Disposed += OnRecordingPanelDisposed;

            string path = System.Environment.CurrentDirectory;
            mVlc = new Vlc.DotNet.Core.VlcMediaPlayer(new DirectoryInfo(path + "\\vlc"));

            outputFolder = Path.Combine(Path.GetTempPath(), "CSRadio");
            Directory.CreateDirectory(outputFolder);
        }

        private void RecordingPanel_Load(object sender, EventArgs e)
        {

        }


        void OnRecordingPanelDisposed(object sender, EventArgs e)
        {
            StopRecording();
        }



        private void StartRecording(string url)
        {
            outputFilename = String.Format("CSRadio {0:yyy-MM-dd HH-mm-ss}.mp3", DateTime.Now);
            string[] opt = new string[] { ":sout=#transcode{acodec=mp3,ab=128,channels=2}:duplicate{dst=std{access=file,mux=raw,dst=\""+ Path.Combine(outputFolder, outputFilename) + "\"}}" };
            mVlc.SetMedia(url, opt);
            mVlc.Play();

        }
        void StopRecording()
        {
            Debug.WriteLine("StopRecording");
            mVlc.Stop();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (mIsRecording)
            {
                //Must Be Turn Off
                btnRecord.Image = Resources.UnRec;
                StopRecording();
                mIsRecording = false;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(URL))
                {
                    btnRecord.Image = Resources.Rec;
                    StartRecording(URL);
                    mIsRecording = true;
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(outputFolder);
        }
    }
}