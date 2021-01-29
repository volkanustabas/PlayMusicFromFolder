using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NAudio.Wave;

namespace PlayMusicFromFolder
{
    public partial class Form1 : Form
    {
        private AudioFileReader _audioFile;
        private WaveOutEvent _outputDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            lv_fileList.Items.Clear();

            lv_fileList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


            fbd_musicFolder.RootFolder = Environment.SpecialFolder.MyComputer;

            if (fbd_musicFolder.ShowDialog() == DialogResult.OK)
            {
                lbl_fbd_path.Text = fbd_musicFolder.SelectedPath;

                var files = Directory.GetFiles(fbd_musicFolder.SelectedPath)
                    .Where(file => Regex.IsMatch(file, @"^.+\.(wav|mp3)$"));

                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var reader = new Mp3FileReader(file);
                    var duration = reader.TotalTime;

                    var item = new ListViewItem(fileName);
                    item.SubItems.Add(duration.ToString("mm\\:ss"));
                    lv_fileList.Items.Add(item);

                    AutoResizeColumns(lv_fileList);
                }
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (_outputDevice == null)
            {
                _outputDevice = new WaveOutEvent();
                _outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (_audioFile == null)
            {
                _audioFile =
                    new AudioFileReader(fbd_musicFolder.SelectedPath + @"\" + lv_fileList.SelectedItems[0].Text);
                _outputDevice.Init(_audioFile);
            }

            _outputDevice.Play();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            _outputDevice?.Dispose();
            _outputDevice = null;
            _audioFile?.Dispose();
            _audioFile = null;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            _outputDevice?.Stop();
        }

        public static void AutoResizeColumns(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            var cc = lv.Columns;
            for (var i = 0; i < cc.Count; i++)
            {
                var colWidth = TextRenderer.MeasureText(cc[i].Text, lv.Font).Width + 10;
                if (colWidth > cc[i].Width) cc[i].Width = colWidth;
            }
        }

        private void lv_fileList_DoubleClick(object sender, EventArgs e)
        {
            _outputDevice?.Stop();
            _outputDevice?.Dispose();
            _outputDevice = null;
            _audioFile?.Dispose();
            _audioFile = null;

            if (_outputDevice == null)
            {
                _outputDevice = new WaveOutEvent();
                _outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (_audioFile == null)
            {
                _audioFile =
                    new AudioFileReader(fbd_musicFolder.SelectedPath + @"\" + lv_fileList.SelectedItems[0].Text);
                _outputDevice.Init(_audioFile);
            }

            _outputDevice.Play();
        }
    }
}