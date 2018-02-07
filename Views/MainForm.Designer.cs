// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-06-2018
// ***********************************************************************
// <copyright file="MainForm.Designer.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ComputerVisionVideoPlayer
{
     /// <summary>
     /// Class MainForm.
     /// </summary>
     /// <seealso cref="System.Windows.Forms.Form" />
     partial class MainForm
    {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent( )
        {
               this.components = new System.ComponentModel.Container();
               this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.localVideoCaptureDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openVideofileusingDirectShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.openMJPEGURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.capture1stDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.statusStrip = new System.Windows.Forms.StatusStrip();
               this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
               this.FileNameLabel = new System.Windows.Forms.ToolStripStatusLabel();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.ButtonGetImage = new System.Windows.Forms.Button();
               this.ButtonProcess = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.radioButtonVideoFile = new System.Windows.Forms.RadioButton();
               this.radioButtonCamera = new System.Windows.Forms.RadioButton();
               this.radioButtonStill = new System.Windows.Forms.RadioButton();
               this.pictureBox1 = new Accord.Controls.PictureBox();
               this.pictureBox2 = new Accord.Controls.PictureBox();
               this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
               this.pictureBoxStatic = new Accord.Controls.PictureBox();
               this.timer = new System.Windows.Forms.Timer(this.components);
               this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
               this.mainMenuStrip.SuspendLayout();
               this.statusStrip.SuspendLayout();
               this.mainPanel.SuspendLayout();
               this.tableLayoutPanel1.SuspendLayout();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatic)).BeginInit();
               this.SuspendLayout();
               // 
               // mainMenuStrip
               // 
               this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
               this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
               this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
               this.mainMenuStrip.Name = "mainMenuStrip";
               this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
               this.mainMenuStrip.TabIndex = 0;
               this.mainMenuStrip.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localVideoCaptureDeviceToolStripMenuItem,
            this.openVideofileusingDirectShowToolStripMenuItem,
            this.openJPEGURLToolStripMenuItem,
            this.openMJPEGURLToolStripMenuItem,
            this.capture1stDisplayToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "&File";
               // 
               // localVideoCaptureDeviceToolStripMenuItem
               // 
               this.localVideoCaptureDeviceToolStripMenuItem.Name = "localVideoCaptureDeviceToolStripMenuItem";
               this.localVideoCaptureDeviceToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.localVideoCaptureDeviceToolStripMenuItem.Text = "Local &Video Capture Device";
               this.localVideoCaptureDeviceToolStripMenuItem.Click += new System.EventHandler(this.localVideoCaptureDeviceToolStripMenuItem_Click);
               // 
               // openVideofileusingDirectShowToolStripMenuItem
               // 
               this.openVideofileusingDirectShowToolStripMenuItem.Name = "openVideofileusingDirectShowToolStripMenuItem";
               this.openVideofileusingDirectShowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.openVideofileusingDirectShowToolStripMenuItem.Text = "Open video &file (using DirectShow)";
               this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideoFileUsingDirectShowToolStripMenuItem_Click);
               // 
               // openJPEGURLToolStripMenuItem
               // 
               this.openJPEGURLToolStripMenuItem.Name = "openJPEGURLToolStripMenuItem";
               this.openJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.openJPEGURLToolStripMenuItem.Text = "Open JPEG &URL";
               this.openJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openJPEGURLToolStripMenuItem_Click);
               // 
               // openMJPEGURLToolStripMenuItem
               // 
               this.openMJPEGURLToolStripMenuItem.Name = "openMJPEGURLToolStripMenuItem";
               this.openMJPEGURLToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.openMJPEGURLToolStripMenuItem.Text = "Open &MJPEG URL";
               this.openMJPEGURLToolStripMenuItem.Click += new System.EventHandler(this.openMJPEGURLToolStripMenuItem_Click);
               // 
               // capture1stDisplayToolStripMenuItem
               // 
               this.capture1stDisplayToolStripMenuItem.Name = "capture1stDisplayToolStripMenuItem";
               this.capture1stDisplayToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.capture1stDisplayToolStripMenuItem.Text = "Capture 1st display";
               this.capture1stDisplayToolStripMenuItem.Click += new System.EventHandler(this.capture1stDisplayToolStripMenuItem_Click);
               // 
               // toolStripMenuItem1
               // 
               this.toolStripMenuItem1.Name = "toolStripMenuItem1";
               this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
               this.exitToolStripMenuItem.Text = "E&xit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
               // 
               // statusStrip
               // 
               this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
               this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsLabel,
            this.FileNameLabel});
               this.statusStrip.Location = new System.Drawing.Point(0, 730);
               this.statusStrip.Name = "statusStrip";
               this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
               this.statusStrip.Size = new System.Drawing.Size(784, 22);
               this.statusStrip.TabIndex = 1;
               this.statusStrip.Text = "statusStrip1";
               // 
               // fpsLabel
               // 
               this.fpsLabel.Name = "fpsLabel";
               this.fpsLabel.Size = new System.Drawing.Size(768, 17);
               this.fpsLabel.Spring = true;
               this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
               // 
               // FileNameLabel
               // 
               this.FileNameLabel.Name = "FileNameLabel";
               this.FileNameLabel.Size = new System.Drawing.Size(0, 17);
               // 
               // mainPanel
               // 
               this.mainPanel.Controls.Add(this.tableLayoutPanel1);
               this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
               this.mainPanel.Location = new System.Drawing.Point(0, 24);
               this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(784, 706);
               this.mainPanel.TabIndex = 2;
               // 
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.ColumnCount = 3;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.Controls.Add(this.ButtonGetImage, 0, 2);
               this.tableLayoutPanel1.Controls.Add(this.ButtonProcess, 0, 1);
               this.tableLayoutPanel1.Controls.Add(this.button3, 0, 3);
               this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
               this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
               this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 5);
               this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 5);
               this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer, 1, 0);
               this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
               this.tableLayoutPanel1.Name = "tableLayoutPanel1";
               this.tableLayoutPanel1.RowCount = 6;
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
               this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 706);
               this.tableLayoutPanel1.TabIndex = 1;
               // 
               // ButtonGetImage
               // 
               this.ButtonGetImage.AutoSize = true;
               this.ButtonGetImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ButtonGetImage.Dock = System.Windows.Forms.DockStyle.Fill;
               this.ButtonGetImage.Location = new System.Drawing.Point(3, 115);
               this.ButtonGetImage.Name = "ButtonGetImage";
               this.ButtonGetImage.Size = new System.Drawing.Size(100, 23);
               this.ButtonGetImage.TabIndex = 3;
               this.ButtonGetImage.Text = "Get Image...";
               this.ButtonGetImage.UseVisualStyleBackColor = true;
               this.ButtonGetImage.Visible = false;
               this.ButtonGetImage.Click += new System.EventHandler(this.ButtonGetImage_Click);
               // 
               // ButtonProcess
               // 
               this.ButtonProcess.AutoSize = true;
               this.ButtonProcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.ButtonProcess.Dock = System.Windows.Forms.DockStyle.Fill;
               this.ButtonProcess.Location = new System.Drawing.Point(3, 86);
               this.ButtonProcess.Name = "ButtonProcess";
               this.ButtonProcess.Size = new System.Drawing.Size(100, 23);
               this.ButtonProcess.TabIndex = 4;
               this.ButtonProcess.Text = "Run Process";
               this.ButtonProcess.UseVisualStyleBackColor = true;
               // 
               // button3
               // 
               this.button3.AutoSize = true;
               this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
               this.button3.Location = new System.Drawing.Point(3, 144);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(100, 23);
               this.button3.TabIndex = 5;
               this.button3.Text = "button3";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Visible = false;
               // 
               // button4
               // 
               this.button4.AutoSize = true;
               this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
               this.button4.Location = new System.Drawing.Point(3, 173);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(100, 312);
               this.button4.TabIndex = 6;
               this.button4.Text = "button4";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Visible = false;
               // 
               // groupBox1
               // 
               this.groupBox1.AutoSize = true;
               this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
               this.groupBox1.Controls.Add(this.radioButtonVideoFile);
               this.groupBox1.Controls.Add(this.radioButtonCamera);
               this.groupBox1.Controls.Add(this.radioButtonStill);
               this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.groupBox1.Location = new System.Drawing.Point(3, 3);
               this.groupBox1.MinimumSize = new System.Drawing.Size(100, 0);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(100, 77);
               this.groupBox1.TabIndex = 8;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Image Source";
               // 
               // radioButtonVideoFile
               // 
               this.radioButtonVideoFile.AutoSize = true;
               this.radioButtonVideoFile.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonVideoFile.Location = new System.Drawing.Point(3, 57);
               this.radioButtonVideoFile.Name = "radioButtonVideoFile";
               this.radioButtonVideoFile.Size = new System.Drawing.Size(94, 17);
               this.radioButtonVideoFile.TabIndex = 7;
               this.radioButtonVideoFile.TabStop = true;
               this.radioButtonVideoFile.Text = "Video File";
               this.radioButtonVideoFile.UseVisualStyleBackColor = true;
               this.radioButtonVideoFile.Click += new System.EventHandler(this.radioButtonImageSource_Click);
               // 
               // radioButtonCamera
               // 
               this.radioButtonCamera.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonCamera.Location = new System.Drawing.Point(3, 33);
               this.radioButtonCamera.Name = "radioButtonCamera";
               this.radioButtonCamera.Size = new System.Drawing.Size(94, 24);
               this.radioButtonCamera.TabIndex = 8;
               this.radioButtonCamera.TabStop = true;
               this.radioButtonCamera.Text = "Camera";
               this.radioButtonCamera.UseVisualStyleBackColor = true;
               this.radioButtonCamera.Click += new System.EventHandler(this.radioButtonImageSource_Click);
               // 
               // radioButtonStill
               // 
               this.radioButtonStill.AutoSize = true;
               this.radioButtonStill.Checked = true;
               this.radioButtonStill.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonStill.Location = new System.Drawing.Point(3, 16);
               this.radioButtonStill.Name = "radioButtonStill";
               this.radioButtonStill.Size = new System.Drawing.Size(94, 17);
               this.radioButtonStill.TabIndex = 9;
               this.radioButtonStill.TabStop = true;
               this.radioButtonStill.Text = "Still";
               this.radioButtonStill.UseVisualStyleBackColor = true;
               this.radioButtonStill.Click += new System.EventHandler(this.radioButtonImageSource_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Black;
               this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pictureBox1.Image = null;
               this.pictureBox1.Location = new System.Drawing.Point(109, 491);
               this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(333, 212);
               this.pictureBox1.TabIndex = 9;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Visible = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.Black;
               this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pictureBox2.Image = null;
               this.pictureBox2.Location = new System.Drawing.Point(448, 491);
               this.pictureBox2.MinimumSize = new System.Drawing.Size(100, 100);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(333, 212);
               this.pictureBox2.TabIndex = 10;
               this.pictureBox2.TabStop = false;
               this.pictureBox2.Visible = false;
               // 
               // videoSourcePlayer
               // 
               this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.tableLayoutPanel1.SetColumnSpan(this.videoSourcePlayer, 2);
               this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
               this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
               this.videoSourcePlayer.KeepAspectRatio = true;
               this.videoSourcePlayer.Location = new System.Drawing.Point(108, 4);
               this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
               this.videoSourcePlayer.MinimumSize = new System.Drawing.Size(640, 480);
               this.videoSourcePlayer.Name = "videoSourcePlayer";
               this.tableLayoutPanel1.SetRowSpan(this.videoSourcePlayer, 5);
               this.videoSourcePlayer.Size = new System.Drawing.Size(674, 480);
               this.videoSourcePlayer.TabIndex = 0;
               this.videoSourcePlayer.VideoSource = null;
               this.videoSourcePlayer.NewFrameReceived += new Accord.Video.NewFrameEventHandler(this.videoSourcePlayer_NewFrame);
               this.videoSourcePlayer.DoubleClick += new System.EventHandler(this.videoSourcePlayer_Click);
               // 
               // pictureBoxStatic
               // 
               this.pictureBoxStatic.Enabled = false;
               this.pictureBoxStatic.Image = null;
               this.pictureBoxStatic.Location = new System.Drawing.Point(3, 491);
               this.pictureBoxStatic.Name = "pictureBoxStatic";
               this.pictureBoxStatic.Size = new System.Drawing.Size(50, 50);
               this.pictureBoxStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBoxStatic.TabIndex = 11;
               this.pictureBoxStatic.TabStop = false;
               this.pictureBoxStatic.UseWaitCursor = true;
               this.pictureBoxStatic.Visible = false;
               // 
               // timer
               // 
               this.timer.Interval = 1000;
               this.timer.Tick += new System.EventHandler(this.timer_Tick);
               // 
               // openFileDialog
               // 
               this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
               this.openFileDialog.Title = "Opem movie";
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(784, 752);
               this.Controls.Add(this.mainPanel);
               this.Controls.Add(this.statusStrip);
               this.Controls.Add(this.mainMenuStrip);
               this.MainMenuStrip = this.mainMenuStrip;
               this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
               this.Name = "MainForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Simple Player";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
               this.mainMenuStrip.ResumeLayout(false);
               this.mainMenuStrip.PerformLayout();
               this.statusStrip.ResumeLayout(false);
               this.statusStrip.PerformLayout();
               this.mainPanel.ResumeLayout(false);
               this.tableLayoutPanel1.ResumeLayout(false);
               this.tableLayoutPanel1.PerformLayout();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatic)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

          #endregion

          /// <summary>
          /// The main menu strip
          /// </summary>
          private System.Windows.Forms.MenuStrip mainMenuStrip;
          /// <summary>
          /// The file tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          /// <summary>
          /// The status strip
          /// </summary>
          private System.Windows.Forms.StatusStrip statusStrip;
          /// <summary>
          /// The main panel
          /// </summary>
          private System.Windows.Forms.Panel mainPanel;
          /// <summary>
          /// The exit tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
          /// <summary>
          /// The local video capture device tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem localVideoCaptureDeviceToolStripMenuItem;
          /// <summary>
          /// The tool strip menu item1
          /// </summary>
          private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
          /// <summary>
          /// The timer
          /// </summary>
          private System.Windows.Forms.Timer timer;
          /// <summary>
          /// The FPS label
          /// </summary>
          private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
          /// <summary>
          /// The open videofileusing direct show tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem openVideofileusingDirectShowToolStripMenuItem;
          /// <summary>
          /// The open file dialog
          /// </summary>
          private System.Windows.Forms.OpenFileDialog openFileDialog;
          /// <summary>
          /// The open jpegurl tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem openJPEGURLToolStripMenuItem;
          /// <summary>
          /// The open mjpegurl tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem openMJPEGURLToolStripMenuItem;
          /// <summary>
          /// The capture1st display tool strip menu item
          /// </summary>
          private System.Windows.Forms.ToolStripMenuItem capture1stDisplayToolStripMenuItem;
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          private Accord.Controls.VideoSourcePlayer videoSourcePlayer;
          private System.Windows.Forms.Button ButtonGetImage;
          private System.Windows.Forms.Button ButtonProcess;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.RadioButton radioButtonVideoFile;
          private System.Windows.Forms.RadioButton radioButtonCamera;
          private System.Windows.Forms.RadioButton radioButtonStill;
          private Accord.Controls.PictureBox pictureBox1;
          private Accord.Controls.PictureBox pictureBox2;
          private Accord.Controls.PictureBox pictureBoxStatic;
          private System.Windows.Forms.ToolStripStatusLabel FileNameLabel;
     }
}

