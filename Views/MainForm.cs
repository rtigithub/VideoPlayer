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

     /// <summary>
     /// Class MainForm.
     /// </summary>
     /// <seealso cref="System.Windows.Forms.Form" />
     public partial class MainForm : Form
     {
          #region Private Fields

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
               VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

               if (form.ShowDialog(this) == DialogResult.OK)
               {
                    // create video source
                    VideoCaptureDevice videoSource = form.VideoDevice;

                    // open it
                    OpenVideoSource(videoSource);
               }
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
                    JPEGStream jpegSource = new JPEGStream(form.URL);

                    // open it
                    OpenVideoSource(jpegSource);
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
                    MJPEGStream mjpegSource = new MJPEGStream(form.URL);

                    // open it
                    OpenVideoSource(mjpegSource);
               }
          }

          // Open video file using DirectShow
          /// <summary>
          /// Handles the Click event of the openVideofileusingDirectShowToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void openVideofileusingDirectShowToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    // create video source
                    FileVideoSource fileSource = new FileVideoSource(openFileDialog.FileName);

                    // open it
                    OpenVideoSource(fileSource);
               }
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
     }
}