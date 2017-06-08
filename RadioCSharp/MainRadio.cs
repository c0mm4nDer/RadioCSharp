using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using RadioCSharp.Properties;
using System.Runtime.InteropServices;
using System.Threading;

namespace RadioCSharp
{
    public partial class MainRadio : Form
    {

        delegate void ShowErrorDelegate(string message);
        delegate void ShowTimeDelegate(long timelong);
        string mPath;
        string mFilename;
        string mFilenameTemp;
        string mFileNameTempemp;
        Vlc.DotNet.Core.VlcMediaPlayer mVlc;
        public MainRadio()
        {
            InitializeComponent();
            mPath = System.Environment.CurrentDirectory;
            mVlc = new Vlc.DotNet.Core.VlcMediaPlayer(new DirectoryInfo(mPath + "\\vlc"));
            mVlc.Buffering += V_Buffering;
            mVlc.TimeChanged += V_TimeChanged;
            mVlc.TitleChanged += V_TitleChanged; 
        }

        private String GetFileName(String hrefLink)
        {

            return Path.GetFileName(Uri.UnescapeDataString(hrefLink).Replace("/", "\\"));
        }

        private void V_TitleChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerTitleChangedEventArgs e)
        {
            mFilename = e.NewTitle; ;
            lblTitle.Invoke(new Action(delegate { lblTitle.Text = "CSRadio " + e.NewTitle; }));
        }

        private void ShowError(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowErrorDelegate(ShowError), message);
            }
            else
            {
                MessageBox.Show(message);
            }

        }




        private void btnMute_Click(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value != 0)
            {
                bunifuSlider1.Value = 0;
                btnMute.Image = Resources.Mute;
            }
            else
            {
                bunifuSlider1.Value = 100;
                btnMute.Image = Resources.up;
            }

            bunifuSlider1_ValueChanged(this, new EventArgs());
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileopen = new OpenFileDialog();
            fileopen.Filter = "(*.pls)| *.pls";
            fileopen.ShowDialog();
            string path = fileopen.FileName;
            // Open the stream and read it back.
            if (string.IsNullOrWhiteSpace(path))
                return;
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                string result = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.StartsWith("File"))
                    {
                        int index = s.IndexOf("=") + 1;
                        result += s.Substring(index) + "\n";
                        listBox1.Items.Add(s.Substring(index));
                    }
                    Console.WriteLine(s);
                }
            }
        }



        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    ColorConverter colorConverter = new ColorConverter();
                    Color color = (Color)colorConverter.ConvertFromString("#476DD6");
                    //Brushes.MediumSpringGreen
                    SolidBrush brush = new SolidBrush(color);


                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
                using (SolidBrush b = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(listBox1.GetItemText(listBox1.Items[e.Index]), e.Font, b, e.Bounds);
                }
                e.DrawFocusRectangle();
            }
            catch { }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value == 0)
                btnMute.Image = Resources.Mute;
            else
                btnMute.Image = Resources.up;

            mVlc.Audio.Volume = bunifuSlider1.Value;
            //vlc.volume = bunifuSlider1.Value;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            StopPlayback();

            Play();

            
        }



        private void ShowTimeState(long totalSeconds)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowTimeDelegate(ShowTimeState), totalSeconds);
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

                //here backslash is must to tell that colon is
                //not the part of format, it just a character that we want in output
                string str = time.ToString(@"hh\:mm\:ss");
                labelBuffered.Text = str;// String.Format("{0:0}s", totalSeconds);
            }


        }



        private void Play()
        {
            try
            {

                mVlc.OnMediaPlayerTitleChanged(GetFileName(listBox1.SelectedItem.ToString()));
                mVlc.SetMedia(listBox1.SelectedItem.ToString());
                recordingPanelVLC1.URL = listBox1.SelectedItem.ToString();
                mVlc.Play();
                //vlc.playlist.add(listBox1.SelectedItem.ToString(), "Display Text", "Options");
                //vlc.playlist.play();

            }
            catch
            {

            }
        }

        private void StopPlayback()
        {
            mVlc.Stop();
            lblTitle.Text = "CSRadio ";
            ResetShowStates();
            //vlc.playlist.stop();
            //vlc.playlist.items.clear();
        }

        private void Pause()
        {
            mVlc.Pause();
            //vlc.playlist.pause();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
            //string[] option = new string[] { "--sout=file/ps:aa.mp3" };
            //mVlc = new Vlc.DotNet.Core.VlcMediaPlayer(new DirectoryInfo(mPath + "\\vlc"), option);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            StopPlayback();
            listBox1.Items.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopPlayback();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count > 0)
                btnPlay_Click(this, new EventArgs());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < (listBox1.Items.Count - 1))
            {


                listBox1.SetSelected(listBox1.SelectedIndex + 1, true);
                btnPlay_Click(this, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {

                listBox1.SetSelected(listBox1.SelectedIndex - 1, true);
                btnPlay_Click(this, new EventArgs());
            }

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            AddUrlDialog dig = new AddUrlDialog();
            dig.ShowDialog();

            if (dig.IsGetNewURL)
            {
                listBox1.Items.Add(dig.URL);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (vlc.playlist.isPlaying)
            //{
            //    TimeSecend++;
            //    //ShowTimeState(TimeSecend);
            //}
            //else
            //{
            //    TimeSecend = 0;
            //    //ShowTimeState(TimeSecend);
            //}

        }

        //private void vlc_MediaPlayerBuffering(object sender, AxAXVLC.DVLCEvents_MediaPlayerBufferingEvent e)
        //{
        //    bunifuCircleProgressbar1.Value = e.cache;
        //}
        private void V_Buffering(object sender, Vlc.DotNet.Core.VlcMediaPlayerBufferingEventArgs e)
        {
            bunifuCircleProgressbar1.Invoke(new Action(() => {
                bunifuCircleProgressbar1.Value = Convert.ToInt32(e.NewCache);
            }));
        }
        //private void vlc_MediaPlayerTimeChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent e)
        //{
        //    ShowTimeState(Convert.ToInt64(e.time / 1000));
        //}

        private void V_TimeChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerTimeChangedEventArgs e)
        {
            ShowTimeState(Convert.ToInt64(e.NewTime / 1000));
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            
            if (lblTitle.Text.Length > 8)
            {
                var s1 = "CSRadio ";
                

                mFilenameTemp += mFilename.Substring(0, 1);
                mFilename = mFilename.Substring(1);
                
                if (mFilename.Length == 0)
                {
                    mFilename = mFilenameTemp;
                    mFilenameTemp = "";
                    timer1.Interval = 5000;
                }
                else
                {
                    timer1.Interval = 500;
                }

                int index = mFilename.Length <= 11 ? mFilename.Length : 11;
                lblTitle.Text = s1 + mFilename.Substring(0, index);


            }

        }

        private void ResetShowStates()
        {
            labelBuffered.Text = "00:00:00";
            bunifuCircleProgressbar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
