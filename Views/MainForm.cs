// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-06-2018
// ***********************************************************************
// <copyright file="MainForm.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ComputerVisionVideoPlayer
{
     using System;
     using System.Diagnostics;
     using System.Drawing;
     using System.Windows.Forms;
     using Accord.Video;
     using Accord.Video.DirectShow;
     using Accord.Video.FFMPEG;

     /// <summary>
     /// Class MainForm.
     /// </summary>
     /// <seealso cref="System.Windows.Forms.Form" />
     public partial class MainForm : Form
     {
          #region Private Fields

          /// <summary>
          /// The video source
          /// </summary>
          private IVideoSource _videoSource = null;

          /// <summary>
          /// The stop watch
          /// </summary>
          private Stopwatch stopWatch = null;

          #endregion Private Fields

          #region Public Constructors

          // Class constructor
          /// <summary>
          /// Initializes a new instance of the <see cref="MainForm"/> class.
          /// </summary>
          public MainForm()
          {
               InitializeComponent();
          }

          #endregion Public Constructors

          #region Public Properties

          /// <summary>
          /// Gets or sets the video source.
          /// </summary>
          /// <value>The video source.</value>
          public IVideoSource VideoSource { get => this._videoSource; set => this._videoSource = value; }

          #endregion Public Properties

          #region Private Methods

          // Capture 1st display in the system
          /// <summary>
          /// Handles the Click event of the capture1stDisplayToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void capture1stDisplayToolStripMenuItem_Click(object sender, EventArgs e)
          {
               OpenVideoSource(new ScreenCaptureStream(Screen.AllScreens[0].Bounds, 100));
          }

          // Close video source if it is running
          /// <summary>
          /// Closes the current video source.
          /// </summary>
          private void CloseCurrentVideoSource()
          {
               if (videoSourcePlayer.VideoSource != null)
               {
                    videoSourcePlayer.SignalToStop();
                    videoSourcePlayer.VideoSource = null;
               }
          }

          private void EnablePictureBoxStatic()
          {
               this.tableLayoutPanel1.Controls.Add(this.pictureBoxStatic, 1, 0);
               this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxStatic, 2);
               this.tableLayoutPanel1.SetRowSpan(this.pictureBoxStatic, 5);
               this.pictureBoxStatic.MinimumSize = new Size(640, 480);
               pictureBoxStatic.Visible = true;
               pictureBoxStatic.Enabled = true;
               videoSourcePlayer.Visible = false;
               videoSourcePlayer.Enabled = false;
          }

          private void EnableVideoSourcePlayer()
          {
               pictureBoxStatic.Visible = false;
               pictureBoxStatic.Enabled = false;
               videoSourcePlayer.Visible = true;
               videoSourcePlayer.Enabled = true;
          }

          // "Exit" menu item clicked
          /// <summary>
          /// Handles the Click event of the exitToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void exitToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          // Open local video capture device
          /// <summary>
          /// Handles the Click event of the localVideoCaptureDeviceToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void localVideoCaptureDeviceToolStripMenuItem_Click(object sender, EventArgs e)
          {
               OpenVideoDeviceSource();
          }

          /// <summary>
          /// Handles the FormClosing event of the MainForm control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
          private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
          {
               CloseCurrentVideoSource();
          }

          private void OpenImageFileSource()
          {
               openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.bmp;*.png|All files|*.*";
               openFileDialog.FileName = string.Empty;
               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    FileNameLabel.Text = openFileDialog.FileName;
                    Bitmap MyImage = new Bitmap(openFileDialog.FileName);
                    pictureBoxStatic.Image = MyImage;
               }
          }

          // Open JPEG URL
          /// <summary>
          /// Handles the Click event of the openJPEGURLToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void openJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
          {
               URLForm form = new URLForm();

               form.Description = "Enter URL of an updating JPEG from a web camera:";
               form.URLs = new string[]
               {
                "http://195.243.185.195/axis-cgi/jpg/image.cgi?camera=1",
               };

               if (form.ShowDialog(this) == DialogResult.OK)
               {
                    // create video source
                    _videoSource = new JPEGStream(form.URL);

                    // open it
                    OpenVideoSource(_videoSource);
               }
          }

          // Open MJPEG URL
          /// <summary>
          /// Handles the Click event of the openMJPEGURLToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void openMJPEGURLToolStripMenuItem_Click(object sender, EventArgs e)
          {
               URLForm form = new URLForm();

               form.Description = "Enter URL of an MJPEG video stream:";
               form.URLs = new string[]
               {
                "http://webcam.st-malo.com/axis-cgi/mjpg/video.cgi?resolution=352x288",
                "http://88.53.197.250/axis-cgi/mjpg/video.cgi?resolution=320x240",
               };

               if (form.ShowDialog(this) == DialogResult.OK)
               {
                    // create video source
                    _videoSource = new MJPEGStream(form.URL);

                    // open it
                    OpenVideoSource(_videoSource);
               }
          }

          private void OpenVideoDeviceSource()
          {
               VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

               if (form.ShowDialog(this) == DialogResult.OK)
               {
                    // create video source
                    _videoSource = form.VideoDevice;

                    // open it
                    OpenVideoSource(_videoSource);
               }
          }

          private void OpenVideoFileSource()
          {
               openFileDialog.Filter = "Video files|*.mp4|All files|*.*";
               openFileDialog.FileName = string.Empty;
               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    // create video source
                    _videoSource = new VideoFileSource(openFileDialog.FileName);

                    // open it
                    OpenVideoSource(_videoSource);
               }
          }

          // Open video file using DirectShow
          /// <summary>
          /// Handles the Click event of the openVideoFileUsingDirectShowToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void openVideoFileUsingDirectShowToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    // create video source
                    _videoSource = new FileVideoSource(openFileDialog.FileName);

                    // open it
                    OpenVideoSource(_videoSource);
               }
          }

          // Open video file using FFMPEG
          /// <summary>
          /// Handles the Click event of the openVideoFileUsingFfmpegToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void openVideoFileUsingFfmpegToolStripMenuItem_Click(object sender, EventArgs e)
          {
               OpenVideoFileSource();
          }

          // Open video source
          /// <summary>
          /// Opens the video source.
          /// </summary>
          /// <param name="source">The source.</param>
          private void OpenVideoSource(IVideoSource source)
          {
               // set busy cursor
               this.Cursor = Cursors.WaitCursor;

               // stop current video source
               CloseCurrentVideoSource();

               // start new video source
               videoSourcePlayer.VideoSource = source;
               videoSourcePlayer.Start();

               // reset stop watch
               stopWatch = null;

               // start timer
               timer.Start();

               this.Cursor = Cursors.Default;
          }

          private void radioButtonImageSource_Click(object sender, EventArgs e)
          {
               switch ((sender as RadioButton).Text)
               {
                    case "Still":
                         CloseCurrentVideoSource();
                         EnablePictureBoxStatic();
                         OpenImageFileSource();
                         break;

                    case "Video File":
                         EnableVideoSourcePlayer();
                         OpenVideoFileSource();
                         break;

                    case "Camera":
                         EnableVideoSourcePlayer();
                         OpenVideoDeviceSource();
                         break;

                    default:
                         break;
               }
          }

          // On timer event - gather statistics
          /// <summary>
          /// Handles the Tick event of the timer control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void timer_Tick(object sender, EventArgs e)
          {
               IVideoSource videoSource = videoSourcePlayer.VideoSource;

               if (videoSource != null)
               {
                    // get number of frames since the last timer tick
                    int framesReceived = videoSource.FramesReceived;

                    if (stopWatch == null)
                    {
                         stopWatch = new Stopwatch();
                         stopWatch.Start();
                    }
                    else
                    {
                         stopWatch.Stop();

                         float fps = 1000.0f * framesReceived / stopWatch.ElapsedMilliseconds;
                         fpsLabel.Text = fps.ToString("F2") + " fps";

                         stopWatch.Reset();
                         stopWatch.Start();
                    }
               }
          }

          /// <summary>
          /// Handles the Click event of the videoSourcePlayer control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void videoSourcePlayer_Click(object sender, EventArgs e)
          {
               videoSourcePlayer.SignalToStop();
               videoSourcePlayer.WaitForStop();
          }

          // New frame received by the player
          /// <summary>
          /// Handles the NewFrame event of the videoSourcePlayer control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="args">The <see cref="NewFrameEventArgs"/> instance containing the event data.</param>
          private void videoSourcePlayer_NewFrame(object sender, NewFrameEventArgs args)
          {
               DateTime now = DateTime.Now;
               Graphics g = Graphics.FromImage(args.Frame);

               // paint current time
               SolidBrush brush = new SolidBrush(Color.Red);
               g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
               brush.Dispose();

               g.Dispose();
          }

          #endregion Private Methods

          private void ButtonGetImage_Click(object sender, EventArgs e)
          {

          }
     }
}