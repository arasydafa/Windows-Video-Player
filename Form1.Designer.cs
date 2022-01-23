
namespace Project_WSKM_Video_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitleVideo = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.fastReverseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.muteButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.fastForwardButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsBox = new System.Windows.Forms.RichTextBox();
            this.trackList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(534, 8);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(158, 32);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleVideo);
            this.panel1.Controls.Add(this.BrowseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 46);
            this.panel1.TabIndex = 2;
            // 
            // TitleVideo
            // 
            this.TitleVideo.AutoSize = true;
            this.TitleVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleVideo.Location = new System.Drawing.Point(614, 9);
            this.TitleVideo.Name = "TitleVideo";
            this.TitleVideo.Size = new System.Drawing.Size(61, 29);
            this.TitleVideo.TabIndex = 0;
            this.TitleVideo.Text = "Title";
            this.TitleVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseButton.Location = new System.Drawing.Point(9, 8);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(158, 32);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.volumeLabel);
            this.panel2.Controls.Add(this.fastReverseButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.durationLabel);
            this.panel2.Controls.Add(this.currentLabel);
            this.panel2.Controls.Add(this.volumeTrackBar);
            this.panel2.Controls.Add(this.muteButton);
            this.panel2.Controls.Add(this.PauseButton);
            this.panel2.Controls.Add(this.StopButton);
            this.panel2.Controls.Add(this.fastForwardButton);
            this.panel2.Controls.Add(this.PlayButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 978);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1902, 55);
            this.panel2.TabIndex = 3;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeLabel.Location = new System.Drawing.Point(1073, 13);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(68, 23);
            this.volumeLabel.TabIndex = 4;
            this.volumeLabel.Text = "Volume";
            // 
            // fastReverseButton
            // 
            this.fastReverseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fastReverseButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastReverseButton.Location = new System.Drawing.Point(12, 8);
            this.fastReverseButton.Name = "fastReverseButton";
            this.fastReverseButton.Size = new System.Drawing.Size(158, 32);
            this.fastReverseButton.TabIndex = 1;
            this.fastReverseButton.Text = "<<<";
            this.fastReverseButton.UseVisualStyleBackColor = true;
            this.fastReverseButton.Click += new System.EventHandler(this.fastReverseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1493, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            // 
            // durationLabel
            // 
            this.durationLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(1505, 13);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(72, 23);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "00:00:00";
            this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(1426, 13);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentLabel.Size = new System.Drawing.Size(72, 23);
            this.currentLabel.TabIndex = 3;
            this.currentLabel.Text = "00:00:00";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.volumeTrackBar.LargeChange = 2;
            this.volumeTrackBar.Location = new System.Drawing.Point(1147, 10);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(272, 56);
            this.volumeTrackBar.TabIndex = 2;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // muteButton
            // 
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteButton.Location = new System.Drawing.Point(882, 8);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(158, 32);
            this.muteButton.TabIndex = 1;
            this.muteButton.Text = "Mute";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Location = new System.Drawing.Point(708, 8);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(158, 32);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(360, 8);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(158, 32);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // fastForwardButton
            // 
            this.fastForwardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fastForwardButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastForwardButton.Location = new System.Drawing.Point(186, 8);
            this.fastForwardButton.Name = "fastForwardButton";
            this.fastForwardButton.Size = new System.Drawing.Size(158, 32);
            this.fastForwardButton.TabIndex = 1;
            this.fastForwardButton.Text = ">>>";
            this.fastForwardButton.UseVisualStyleBackColor = true;
            this.fastForwardButton.Click += new System.EventHandler(this.fastForwardButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(11, 567);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(242, 32);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(11, 518);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(242, 32);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // timerVideo
            // 
            this.timerVideo.Enabled = true;
            this.timerVideo.Interval = 1000;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(3, 0);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(1285, 757);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.mediaPlayer_OpenStateChange);
            this.mediaPlayer.MediaError += new AxWMPLib._WMPOCXEvents_MediaErrorEventHandler(this.mediaPlayer_MediaError);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.detailsBox);
            this.panel4.Controls.Add(this.trackList);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.nextButton);
            this.panel4.Controls.Add(this.clearButton);
            this.panel4.Controls.Add(this.previousButton);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1637, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 932);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label3.Location = new System.Drawing.Point(97, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Details";
            // 
            // detailsBox
            // 
            this.detailsBox.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.detailsBox.Location = new System.Drawing.Point(12, 676);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(242, 242);
            this.detailsBox.TabIndex = 4;
            this.detailsBox.Text = "";
            // 
            // trackList
            // 
            this.trackList.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackList.FormattingEnabled = true;
            this.trackList.HorizontalScrollbar = true;
            this.trackList.ItemHeight = 28;
            this.trackList.Location = new System.Drawing.Point(11, 137);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(242, 312);
            this.trackList.TabIndex = 3;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playlist";
            // 
            // clearButton
            // 
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(11, 469);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(242, 32);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(11, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(242, 36);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.mediaPlayer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1902, 932);
            this.panel3.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Media Player ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label TitleVideo;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Timer timerVideo;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Button fastForwardButton;
        private System.Windows.Forms.Button fastReverseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox detailsBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label4;
    }
}

