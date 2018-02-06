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
               this.mainPanel = new System.Windows.Forms.Panel();
               this.videoSourcePlayer = new Accord.Controls.VideoSourcePlayer();
               this.timer = new System.Windows.Forms.Timer(this.components);
               this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
               this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.ButtonGetImage = new System.Windows.Forms.Button();
               this.ButtonProcess = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.radioButtonVideoFile = new System.Windows.Forms.RadioButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.radioButtonCamera = new System.Windows.Forms.RadioButton();
               this.radioButtonStill = new System.Windows.Forms.RadioButton();
               this.mainMenuStrip.SuspendLayout();
               this.statusStrip.SuspendLayout();
               this.mainPanel.SuspendLayout();
               this.tableLayoutPanel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               this.groupBox1.SuspendLayout();
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
               this.openVideofileusingDirectShowToolStripMenuItem.Click += new System.EventHandler(this.openVideofileusingDirectShowToolStripMenuItem_Click);
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
            this.fpsLabel});
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
               // videoSourcePlayer
               // 
               this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
               this.tableLayoutPanel1.SetColumnSpan(this.videoSourcePlayer, 2);
               this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
               this.videoSourcePlayer.ForeColor = System.Drawing.Color.White;
               this.videoSourcePlayer.KeepAspectRatio = true;
               this.videoSourcePlayer.Location = new System.Drawing.Point(124, 4);
               this.videoSourcePlayer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
               this.videoSourcePlayer.MinimumSize = new System.Drawing.Size(640, 480);
               this.videoSourcePlayer.Name = "videoSourcePlayer";
               this.tableLayoutPanel1.SetRowSpan(this.videoSourcePlayer, 5);
               this.videoSourcePlayer.Size = new System.Drawing.Size(658, 480);
               this.videoSourcePlayer.TabIndex = 0;
               this.videoSourcePlayer.VideoSource = null;
               this.videoSourcePlayer.NewFrameReceived += new Accord.Video.NewFrameEventHandler(this.videoSourcePlayer_NewFrame);
               this.videoSourcePlayer.DoubleClick += new System.EventHandler(this.videoSourcePlayer_Click);
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
               // tableLayoutPanel1
               // 
               this.tableLayoutPanel1.ColumnCount = 3;
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
               this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer, 1, 0);
               this.tableLayoutPanel1.Controls.Add(this.ButtonGetImage, 0, 0);
               this.tableLayoutPanel1.Controls.Add(this.ButtonProcess, 0, 1);
               this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
               this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
               this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
               this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 5);
               this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 5);
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
               this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 706);
               this.tableLayoutPanel1.TabIndex = 1;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Black;
               this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pictureBox1.Location = new System.Drawing.Point(125, 491);
               this.pictureBox1.MinimumSize = new System.Drawing.Size(100, 100);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(325, 212);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.BackColor = System.Drawing.Color.Black;
               this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pictureBox2.Location = new System.Drawing.Point(456, 491);
               this.pictureBox2.MinimumSize = new System.Drawing.Size(100, 100);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(325, 212);
               this.pictureBox2.TabIndex = 2;
               this.pictureBox2.TabStop = false;
               // 
               // ButtonGetImage
               // 
               this.ButtonGetImage.AutoSize = true;
               this.ButtonGetImage.Dock = System.Windows.Forms.DockStyle.Fill;
               this.ButtonGetImage.Location = new System.Drawing.Point(3, 3);
               this.ButtonGetImage.Name = "ButtonGetImage";
               this.ButtonGetImage.Size = new System.Drawing.Size(116, 23);
               this.ButtonGetImage.TabIndex = 3;
               this.ButtonGetImage.Text = "Get Image...";
               this.ButtonGetImage.UseVisualStyleBackColor = true;
               // 
               // ButtonProcess
               // 
               this.ButtonProcess.AutoSize = true;
               this.ButtonProcess.Dock = System.Windows.Forms.DockStyle.Fill;
               this.ButtonProcess.Location = new System.Drawing.Point(3, 32);
               this.ButtonProcess.Name = "ButtonProcess";
               this.ButtonProcess.Size = new System.Drawing.Size(116, 23);
               this.ButtonProcess.TabIndex = 4;
               this.ButtonProcess.Text = "Run Process";
               this.ButtonProcess.UseVisualStyleBackColor = true;
               // 
               // button3
               // 
               this.button3.AutoSize = true;
               this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
               this.button3.Location = new System.Drawing.Point(3, 61);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(116, 23);
               this.button3.TabIndex = 5;
               this.button3.Text = "button3";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Visible = false;
               // 
               // button4
               // 
               this.button4.AutoSize = true;
               this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
               this.button4.Location = new System.Drawing.Point(3, 90);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(116, 23);
               this.button4.TabIndex = 6;
               this.button4.Text = "button4";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Visible = false;
               // 
               // radioButtonVideoFile
               // 
               this.radioButtonVideoFile.AutoSize = true;
               this.radioButtonVideoFile.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonVideoFile.Location = new System.Drawing.Point(3, 57);
               this.radioButtonVideoFile.Name = "radioButtonVideoFile";
               this.radioButtonVideoFile.Size = new System.Drawing.Size(110, 17);
               this.radioButtonVideoFile.TabIndex = 7;
               this.radioButtonVideoFile.TabStop = true;
               this.radioButtonVideoFile.Text = "Video File";
               this.radioButtonVideoFile.UseVisualStyleBackColor = true;
               // 
               // groupBox1
               // 
               this.groupBox1.AutoSize = true;
               this.groupBox1.Controls.Add(this.radioButtonVideoFile);
               this.groupBox1.Controls.Add(this.radioButtonCamera);
               this.groupBox1.Controls.Add(this.radioButtonStill);
               this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.groupBox1.Location = new System.Drawing.Point(3, 119);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(116, 366);
               this.groupBox1.TabIndex = 8;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Image Source";
               // 
               // radioButtonCamera
               // 
               this.radioButtonCamera.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonCamera.Location = new System.Drawing.Point(3, 33);
               this.radioButtonCamera.Name = "radioButtonCamera";
               this.radioButtonCamera.Size = new System.Drawing.Size(110, 24);
               this.radioButtonCamera.TabIndex = 8;
               this.radioButtonCamera.TabStop = true;
               this.radioButtonCamera.Text = "Camera";
               this.radioButtonCamera.UseVisualStyleBackColor = true;
               // 
               // radioButtonStill
               // 
               this.radioButtonStill.AutoSize = true;
               this.radioButtonStill.Checked = true;
               this.radioButtonStill.Dock = System.Windows.Forms.DockStyle.Top;
               this.radioButtonStill.Location = new System.Drawing.Point(3, 16);
               this.radioButtonStill.Name = "radioButtonStill";
               this.radioButtonStill.Size = new System.Drawing.Size(110, 17);
               this.radioButtonStill.TabIndex = 9;
               this.radioButtonStill.TabStop = true;
               this.radioButtonStill.Text = "Still";
               this.radioButtonStill.UseVisualStyleBackColor = true;
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
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
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
          /// The video source player
          /// </summary>
          private Accord.Controls.VideoSourcePlayer videoSourcePlayer;
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
          /// <summary>
          /// The table layout panel1
          /// </summary>
          private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
          /// <summary>
          /// The picture box1
          /// </summary>
          private System.Windows.Forms.PictureBox pictureBox1;
          /// <summary>
          /// The picture box2
          /// </summary>
          private System.Windows.Forms.PictureBox pictureBox2;
          /// <summary>
          /// The button get image
          /// </summary>
          private System.Windows.Forms.Button ButtonGetImage;
          /// <summary>
          /// The button process
          /// </summary>
          private System.Windows.Forms.Button ButtonProcess;
          /// <summary>
          /// The button3
          /// </summary>
          private System.Windows.Forms.Button button3;
          /// <summary>
          /// The button4
          /// </summary>
          private System.Windows.Forms.Button button4;
          /// <summary>
          /// The group box1
          /// </summary>
          private System.Windows.Forms.GroupBox groupBox1;
          /// <summary>
          /// The radio button video file
          /// </summary>
          private System.Windows.Forms.RadioButton radioButtonVideoFile;
          /// <summary>
          /// The radio button camera
          /// </summary>
          private System.Windows.Forms.RadioButton radioButtonCamera;
          /// <summary>
          /// The radio button still
          /// </summary>
          private System.Windows.Forms.RadioButton radioButtonStill;
     }
}

