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
            Label lblQuality;
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            url = new Label();
            txtURL = new TextBox();
            btnDownload = new Button();
            lblPath = new Label();
            txtPath = new TextBox();
            btnBrowse = new Button();
            rdVideo = new RadioButton();
            rdAudio = new RadioButton();
            cmbQuality = new ComboBox();
            cmbFormat = new ComboBox();
            lblFormat = new Label();
            cmbAudioFormat = new ComboBox();
            cmbAudioQuality = new ComboBox();
            label2 = new Label();
            lblTitle = new Label();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            thumbnailPicBox = new PictureBox();
            lblSubtitle = new Label();
            cobSubtitle = new ComboBox();
            btnReset = new Button();
            status = new Label();
            label3 = new Label();
            lblSpeed = new Label();
            label4 = new Label();
            lblQuality = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)thumbnailPicBox).BeginInit();
            SuspendLayout();
            // 
            // lblQuality
            // 
            lblQuality.AutoSize = true;
            lblQuality.Location = new Point(446, 129);
            lblQuality.Name = "lblQuality";
            lblQuality.Size = new Size(160, 30);
            lblQuality.TabIndex = 8;
            lblQuality.Text = "Select Quality :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(446, 185);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 8;
            label1.Text = "Select Quality :";
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
            btnDownload.Location = new Point(985, 469);
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
            // cmbQuality
            // 
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Location = new Point(612, 126);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(152, 38);
            cmbQuality.TabIndex = 7;
            // 
            // cmbFormat
            // 
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Location = new Point(273, 126);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(152, 38);
            cmbFormat.TabIndex = 7;
            // 
            // lblFormat
            // 
            lblFormat.AutoSize = true;
            lblFormat.Location = new Point(108, 129);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new Size(159, 30);
            lblFormat.TabIndex = 9;
            lblFormat.Text = "Select Format :";
            // 
            // cmbAudioFormat
            // 
            cmbAudioFormat.FormattingEnabled = true;
            cmbAudioFormat.Location = new Point(612, 182);
            cmbAudioFormat.Name = "cmbAudioFormat";
            cmbAudioFormat.Size = new Size(152, 38);
            cmbAudioFormat.TabIndex = 7;
            // 
            // cmbAudioQuality
            // 
            cmbAudioQuality.FormattingEnabled = true;
            cmbAudioQuality.Location = new Point(273, 182);
            cmbAudioQuality.Name = "cmbAudioQuality";
            cmbAudioQuality.Size = new Size(152, 38);
            cmbAudioQuality.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 185);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 9;
            label2.Text = "Select Format :";
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
            thumbnailPicBox.Location = new Point(911, 335);
            thumbnailPicBox.Name = "thumbnailPicBox";
            thumbnailPicBox.Size = new Size(200, 120);
            thumbnailPicBox.TabIndex = 13;
            thumbnailPicBox.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(770, 129);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(185, 30);
            lblSubtitle.TabIndex = 14;
            lblSubtitle.Text = "Select Language :";
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
            status.Location = new Point(12, 480);
            status.Name = "status";
            status.Size = new Size(73, 30);
            status.TabIndex = 15;
            status.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(770, 185);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 16;
            label3.Text = "Download Speed :";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 244);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 17;
            label4.Text = "Title :";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1123, 547);
            Controls.Add(label4);
            Controls.Add(lblSpeed);
            Controls.Add(label3);
            Controls.Add(status);
            Controls.Add(lblSubtitle);
            Controls.Add(thumbnailPicBox);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFormat);
            Controls.Add(cmbAudioQuality);
            Controls.Add(lblQuality);
            Controls.Add(cmbAudioFormat);
            Controls.Add(cmbFormat);
            Controls.Add(cobSubtitle);
            Controls.Add(cmbQuality);
            Controls.Add(rdAudio);
            Controls.Add(rdVideo);
            Controls.Add(txtPath);
            Controls.Add(lblPath);
            Controls.Add(btnReset);
            Controls.Add(btnBrowse);
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
        private ComboBox cmbQuality;
        private ComboBox cmbFormat;
        private Label lblFormat;
        private ComboBox cmbAudioFormat;
        private ComboBox cmbAudioQuality;
        private Label label2;
        private Label lblTitle;
        private ProgressBar progressBar;
        private Label lblProgress;
        private PictureBox thumbnailPicBox;
        private Label lblSubtitle;
        private ComboBox cobSubtitle;
        private Button btnReset;
        private Label status;
        private Label label3;
        private Label lblSpeed;
        private Label label4;
    }
}
