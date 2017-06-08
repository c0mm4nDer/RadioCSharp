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
    public partial class RecordingPanel : UserControl
    {

        private IWaveIn waveIn;
        private WaveFileWriter writer;
        private string outputFilename;
        private readonly string outputFolder;
        bool mIsRecording = false;


        public RecordingPanel()
        {
            InitializeComponent();

            Disposed += OnRecordingPanelDisposed;

            outputFolder = Path.Combine(Path.GetTempPath(), "CSRadio");
            Directory.CreateDirectory(outputFolder);
        }

        private void RecordingPanel_Load(object sender, EventArgs e)
        {

        }


        void OnRecordingPanelDisposed(object sender, EventArgs e)
        {
            Cleanup();
        }



        private void StartRecording()
        {

            if (waveIn == null)
            {
                CreateWaveInDevice();
            }

            outputFilename = String.Format("CSRadio {0:yyy-MM-dd HH-mm-ss}.wav", DateTime.Now);
            writer = new WaveFileWriter(Path.Combine(outputFolder, outputFilename), waveIn.WaveFormat);
            waveIn.StartRecording();
            //SetControlStates(true);
        }

        private void CreateWaveInDevice()
        {
            // can't set WaveFormat as WASAPI doesn't support SRC
            waveIn = new WasapiLoopbackCapture();
            waveIn.DataAvailable += OnDataAvailable;
            waveIn.RecordingStopped += OnRecordingStopped;
        }

        void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<StoppedEventArgs>(OnRecordingStopped), sender, e);
            }
            else
            {
                FinalizeWaveFile();
                if (e.Exception != null)
                {
                    MessageBox.Show(String.Format("A problem was encountered during recording {0}",
                                                  e.Exception.Message));
                }
                //int newItemIndex = listBoxRecordings.Items.Add(outputFilename);
                //listBoxRecordings.SelectedIndex = newItemIndex;
                //SetControlStates(false);
            }
        }

        private void Cleanup()
        {
            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }
            FinalizeWaveFile();
        }

        private void FinalizeWaveFile()
        {
            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (this.InvokeRequired)
            {
                //Debug.WriteLine("Data Available");
                this.BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                //Debug.WriteLine("Flushing Data Available");
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                //int secondsRecorded = (int)(writer.Length / writer.WaveFormat.ExtraSize);

            }
        }

        void StopRecording()
        {
            Debug.WriteLine("StopRecording");
            if (waveIn != null) waveIn.StopRecording();
        }


        //private void OnButtonPlayClick(object sender, EventArgs e)
        //{
        //    if (listBoxRecordings.SelectedItem != null)
        //    {
        //        Process.Start(Path.Combine(outputFolder, (string)listBoxRecordings.SelectedItem));
        //    }
        //}



        //private void OnButtonDeleteClick(object sender, EventArgs e)
        //{
        //    if (listBoxRecordings.SelectedItem != null)
        //    {
        //        try
        //        {
        //            File.Delete(Path.Combine(outputFolder, (string)listBoxRecordings.SelectedItem));
        //            listBoxRecordings.Items.Remove(listBoxRecordings.SelectedItem);
        //            if (listBoxRecordings.Items.Count > 0)
        //            {
        //                listBoxRecordings.SelectedIndex = 0;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Could not delete recording");
        //        }
        //    }
        //}

        

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
                btnRecord.Image = Resources.Rec;
                StartRecording();
                mIsRecording = true;
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(outputFolder);
        }
    }

    [Export(typeof(INAudioDemoPlugin))]
    public class RecordingPanelPlugin : INAudioDemoPlugin
    {
        public string Name
        {
            get { return "WAV Recording"; }
        }

        public Control CreatePanel()
        {
            return new RecordingPanel();
        }
    }
}