namespace Video_Downloader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label setQulityVideo;
            Label setQualityAudio;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            url = new Label();
            txtURL = new TextBox();
            btnDownload = new Button();
            lblPath = new Label();
            txtPath = new TextBox();
            btnBrowse = new Button();
            rdVideo = new RadioButton();
            rdAudio = new RadioButton();
            cmbQualityVideo = new ComboBox();
            cmbFormatVideo = new ComboBox();
            setFormatVideo = new Label();
            cmbAudioFormat = new ComboBox();
            cmbAudioQuality = new ComboBox();
            setFormatAudio = new Label();
            lblTitle = new Label();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            thumbnailPicBox = new PictureBox();
            setSubtitle = new Label();
            cobSubtitle = new ComboBox();
            btnReset = new Button();
            status = new Label();
            downloadSpeed = new Label();
            lblSpeed = new Label();
            setTitle = new Label();
            btnPause = new Button();
            btnResume = new Button();
            btnCancel = new Button();
            setQulityVideo = new Label();
            setQualityAudio = new Label();
            ((System.ComponentModel.ISupportInitialize)thumbnailPicBox).BeginInit();
            SuspendLayout();
            // 
            // setQulityVideo
            // 
            setQulityVideo.AutoSize = true;
            setQulityVideo.Location = new Point(446, 129);
            setQulityVideo.Name = "setQulityVideo";
            setQulityVideo.Size = new Size(160, 30);
            setQulityVideo.TabIndex = 8;
            setQulityVideo.Text = "Select Quality :";
            // 
            // setQualityAudio
            // 
            setQualityAudio.AutoSize = true;
            setQualityAudio.Location = new Point(446, 185);
            setQualityAudio.Name = "setQualityAudio";
            setQualityAudio.Size = new Size(160, 30);
            setQualityAudio.TabIndex = 8;
            setQualityAudio.Text = "Select Quality :";
            // 
            // url
            // 
            url.AutoSize = true;
            url.Location = new Point(12, 27);
            url.Name = "url";
            url.Size = new Size(128, 30);
            url.TabIndex = 0;
            url.Text = "Video URL :";
            // 
            // txtURL
            // 
            txtURL.BorderStyle = BorderStyle.FixedSingle;
            txtURL.Location = new Point(146, 22);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(833, 35);
            txtURL.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(985, 335);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(126, 38);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(12, 75);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(176, 30);
            lblPath.TabIndex = 3;
            lblPath.Text = "Download Path :";
            // 
            // txtPath
            // 
            txtPath.BorderStyle = BorderStyle.FixedSingle;
            txtPath.Location = new Point(194, 73);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(785, 35);
            txtPath.TabIndex = 4;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(1001, 73);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(110, 35);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // rdVideo
            // 
            rdVideo.AutoSize = true;
            rdVideo.Location = new Point(14, 127);
            rdVideo.Name = "rdVideo";
            rdVideo.Size = new Size(88, 34);
            rdVideo.TabIndex = 5;
            rdVideo.TabStop = true;
            rdVideo.Text = "Video";
            rdVideo.UseVisualStyleBackColor = true;
            // 
            // rdAudio
            // 
            rdAudio.AutoSize = true;
            rdAudio.Location = new Point(14, 181);
            rdAudio.Name = "rdAudio";
            rdAudio.Size = new Size(91, 34);
            rdAudio.TabIndex = 6;
            rdAudio.TabStop = true;
            rdAudio.Text = "Audio";
            rdAudio.UseVisualStyleBackColor = true;
            // 
            // cmbQualityVideo
            // 
            cmbQualityVideo.FormattingEnabled = true;
            cmbQualityVideo.Location = new Point(612, 126);
            cmbQualityVideo.Name = "cmbQualityVideo";
            cmbQualityVideo.Size = new Size(152, 38);
            cmbQualityVideo.TabIndex = 7;
            // 
            // cmbFormatVideo
            // 
            cmbFormatVideo.FormattingEnabled = true;
            cmbFormatVideo.Location = new Point(273, 126);
            cmbFormatVideo.Name = "cmbFormatVideo";
            cmbFormatVideo.Size = new Size(152, 38);
            cmbFormatVideo.TabIndex = 7;
            // 
            // setFormatVideo
            // 
            setFormatVideo.AutoSize = true;
            setFormatVideo.Location = new Point(108, 129);
            setFormatVideo.Name = "setFormatVideo";
            setFormatVideo.Size = new Size(159, 30);
            setFormatVideo.TabIndex = 9;
            setFormatVideo.Text = "Select Format :";
            // 
            // cmbAudioFormat
            // 
            cmbAudioFormat.FormattingEnabled = true;
            cmbAudioFormat.Location = new Point(273, 185);
            cmbAudioFormat.Name = "cmbAudioFormat";
            cmbAudioFormat.Size = new Size(152, 38);
            cmbAudioFormat.TabIndex = 7;
            // 
            // cmbAudioQuality
            // 
            cmbAudioQuality.FormattingEnabled = true;
            cmbAudioQuality.Location = new Point(612, 185);
            cmbAudioQuality.Name = "cmbAudioQuality";
            cmbAudioQuality.Size = new Size(152, 38);
            cmbAudioQuality.TabIndex = 7;
            // 
            // setFormatAudio
            // 
            setFormatAudio.AutoSize = true;
            setFormatAudio.Location = new Point(108, 185);
            setFormatAudio.Name = "setFormatAudio";
            setFormatAudio.Size = new Size(159, 30);
            setFormatAudio.TabIndex = 9;
            setFormatAudio.Text = "Select Format :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(88, 244);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 30);
            lblTitle.TabIndex = 10;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 292);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(1099, 23);
            progressBar.TabIndex = 11;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(12, 335);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(0, 30);
            lblProgress.TabIndex = 12;
            // 
            // thumbnailPicBox
            // 
            thumbnailPicBox.Location = new Point(770, 335);
            thumbnailPicBox.Name = "thumbnailPicBox";
            thumbnailPicBox.Size = new Size(200, 120);
            thumbnailPicBox.TabIndex = 13;
            thumbnailPicBox.TabStop = false;
            // 
            // setSubtitle
            // 
            setSubtitle.AutoSize = true;
            setSubtitle.Location = new Point(770, 129);
            setSubtitle.Name = "setSubtitle";
            setSubtitle.Size = new Size(185, 30);
            setSubtitle.TabIndex = 14;
            setSubtitle.Text = "Select Language :";
            // 
            // cobSubtitle
            // 
            cobSubtitle.FormattingEnabled = true;
            cobSubtitle.Location = new Point(961, 127);
            cobSubtitle.Name = "cobSubtitle";
            cobSubtitle.Size = new Size(152, 38);
            cobSubtitle.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1001, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(12, 475);
            status.Name = "status";
            status.Size = new Size(73, 30);
            status.TabIndex = 15;
            status.Text = "Status";
            // 
            // downloadSpeed
            // 
            downloadSpeed.AutoSize = true;
            downloadSpeed.Location = new Point(770, 185);
            downloadSpeed.Name = "downloadSpeed";
            downloadSpeed.Size = new Size(192, 30);
            downloadSpeed.TabIndex = 16;
            downloadSpeed.Text = "Download Speed :";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(961, 185);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(98, 30);
            lblSpeed.TabIndex = 16;
            lblSpeed.Text = "00 Mbps";
            // 
            // setTitle
            // 
            setTitle.AutoSize = true;
            setTitle.Location = new Point(14, 244);
            setTitle.Name = "setTitle";
            setTitle.Size = new Size(68, 30);
            setTitle.TabIndex = 17;
            setTitle.Text = "Title :";
            // 
            // btnPause
            // 
            btnPause.FlatStyle = FlatStyle.System;
            btnPause.Location = new Point(985, 379);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(126, 38);
            btnPause.TabIndex = 2;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // btnResume
            // 
            btnResume.Location = new Point(985, 423);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(126, 38);
            btnResume.TabIndex = 2;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(987, 467);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 515);
            Controls.Add(setTitle);
            Controls.Add(lblSpeed);
            Controls.Add(downloadSpeed);
            Controls.Add(status);
            Controls.Add(setSubtitle);
            Controls.Add(thumbnailPicBox);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(lblTitle);
            Controls.Add(setFormatAudio);
            Controls.Add(setQualityAudio);
            Controls.Add(setFormatVideo);
            Controls.Add(cmbAudioQuality);
            Controls.Add(setQulityVideo);
            Controls.Add(cmbAudioFormat);
            Controls.Add(cmbFormatVideo);
            Controls.Add(cobSubtitle);
            Controls.Add(cmbQualityVideo);
            Controls.Add(rdAudio);
            Controls.Add(rdVideo);
            Controls.Add(txtPath);
            Controls.Add(lblPath);
            Controls.Add(btnReset);
            Controls.Add(btnBrowse);
            Controls.Add(btnCancel);
            Controls.Add(btnResume);
            Controls.Add(btnPause);
            Controls.Add(btnDownload);
            Controls.Add(txtURL);
            Controls.Add(url);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "Video Downloader";
            ((System.ComponentModel.ISupportInitialize)thumbnailPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label url;
        private TextBox txtURL;
        private Button btnDownload;
        private Label lblPath;
        private TextBox txtPath;
        private Button btnBrowse;
        private RadioButton rdVideo;
        private RadioButton rdAudio;
        private ComboBox cmbQualityVideo;
        private ComboBox cmbFormatVideo;
        private Label setFormatVideo;
        private ComboBox cmbAudioFormat;
        private ComboBox cmbAudioQuality;
        private Label setFormatAudio;
        private Label lblTitle;
        private ProgressBar progressBar;
        private Label lblProgress;
        private PictureBox thumbnailPicBox;
        private Label setSubtitle;
        private ComboBox cobSubtitle;
        private Button btnReset;
        private Label status;
        private Label downloadSpeed;
        private Label lblSpeed;
        private Label setTitle;
        private Button btnPause;
        private Button btnResume;
        private Button btnCancel;
    }
}
