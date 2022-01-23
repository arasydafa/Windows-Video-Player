using System;
using System.Windows.Forms;
using WMPLib;

namespace Project_WSKM_Video_Player
{
    public partial class Form1 : Form
    {

        String[] paths, files;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediaPlayer.uiMode = "none";
            mediaPlayer.Visible = true;

            volumeTrackBar.Value = 50;
            mediaPlayer.settings.volume = volumeTrackBar.Value;
            volumeLabel.Text = Convert.ToString(volumeTrackBar.Value);

            mediaPlayer.settings.mute = false;
            muteButton.Text = "Mute";

            currentLabel.Text = "00:00:00";
            durationLabel.Text = "00:00";

            trackList.Focus();
        }

        private void mediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (e.newState == (int)WMPOpenState.wmposMediaOpen)
            {
                string duration = mediaPlayer.currentMedia.durationString;
                int height = mediaPlayer.currentMedia.imageSourceHeight;
                int width = mediaPlayer.currentMedia.imageSourceWidth;
                string currentPosition = mediaPlayer.Ctlcontrols.currentPositionString;

                currentLabel.Text = currentPosition;
                durationLabel.Text = duration;

                detailsBox.Clear();

                if (height != 0 && width != 0)
                {
                    detailsBox.Text += "Frame Width : " + width.ToString() + Environment.NewLine;
                    detailsBox.Text += "Frame Height : " + height.ToString() + Environment.NewLine;
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select Media";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                mediaPlayer.URL = openFileDialog.FileName;
                TitleVideo.Text = openFileDialog.SafeFileName;

                for (int x = 0; x < files.Length; x++)
                {
                    trackList.Items.Add(files[x]);
                }
                trackList.SelectedIndex = 0;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex < trackList.Items.Count - 1)
            {
                trackList.SelectedIndex = trackList.SelectedIndex + 1;
                mediaPlayer.Ctlcontrols.play();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (trackList.SelectedIndex > 0)
            {
                trackList.SelectedIndex = trackList.SelectedIndex - 1;
                mediaPlayer.Ctlcontrols.play();
            }
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.settings.mute == false)
            {
                mediaPlayer.settings.mute = true;
                muteButton.Text = "Unmute";
            }
            else if (mediaPlayer.settings.mute == true)
            {
                mediaPlayer.settings.mute = false;
                muteButton.Text = "Mute";
            }
        }

        private void fastReverseButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.fastReverse();
        }

        private void fastForwardButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.fastForward();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            durationLabel.Text = "00:00";
            TitleVideo.Text = "Title";
            trackList.Items.Clear();
            detailsBox.Clear();
            mediaPlayer.currentPlaylist.clear();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = volumeTrackBar.Value;
            volumeLabel.Text = Convert.ToString(volumeTrackBar.Value);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            for (int x = trackList.Items.Count - 1; x >= 0; x--)
            {
                if (trackList.Items[x].ToString().ToLower().Contains(searchBox.Text.ToLower()))
                {
                    trackList.SetSelected(x, true);
                }
            }
        }

        private void trackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.URL = paths[trackList.SelectedIndex];
            TitleVideo.Text = openFileDialog.SafeFileName;
            mediaPlayer.Ctlcontrols.play();
        }

        private void timerVideo_Tick(object sender, EventArgs e)
        {
            string currentPosition = mediaPlayer.Ctlcontrols.currentPositionString;

            currentLabel.Text = currentPosition;
        }

        private void mediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X") + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error.");
            }
        }
    }
}