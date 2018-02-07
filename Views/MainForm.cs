// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-07-2018
// ***********************************************************************
// <copyright file="MainForm.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ComputerVisionVideoPlayer
{
     using System;
     using System.Collections.Generic;
     using System.Diagnostics;
     using System.Drawing;
     using System.Drawing.Imaging;
     using System.Windows.Forms;
     using Accord.Imaging;
     using Accord.Imaging.Filters;
     using Accord.Math.Geometry;
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
          /// My image
          /// </summary>
          private Bitmap _myImage;

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
          /// Initializes a new instance of the <see cref="MainForm" /> class.
          /// </summary>
          public MainForm()
          {
               InitializeComponent();
          }

          #endregion Public Constructors

          #region Public Properties

          /// <summary>
          /// Gets the BLOB count.
          /// </summary>
          /// <value>The BLOB count.</value>
          public BlobCounter blobCount { get; private set; }

          /// <summary>
          /// Gets my image.
          /// </summary>
          /// <value>My image.</value>
          public Bitmap MyImage
          {
               get { return _myImage; }
               private set
               {
                    // make sure the image has 24 bpp format
                    if (value.PixelFormat != PixelFormat.Format24bppRgb)
                    {
                         _myImage = Accord.Imaging.Image.Clone(_myImage, PixelFormat.Format24bppRgb);
                    }
                    else
                    {
                         _myImage = value;
                    }
                    ButtonProcess.Enabled = true;
               }
          }

          /// <summary>
          /// Gets or sets the video source.
          /// </summary>
          /// <value>The video source.</value>
          public IVideoSource VideoSource { get => this._videoSource; set => this._videoSource = value; }

          #endregion Public Properties

          #region Private Methods

          /// <summary>
          /// Applies the filter.
          /// </summary>
          /// <param name="myImage">My image.</param>
          /// <param name="filter">The filter.</param>
          /// <returns>Bitmap.</returns>
          private Bitmap ApplyFilter(Bitmap myImage, IFilter filter)
          {
               try
               {
                    return filter.Apply(myImage);
               }
               finally
               {
                    //myImage.Dispose();
               }
          }

          /// <summary>
          /// Handles the Click event of the ButtonProcess control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void ButtonProcess_Click(object sender, EventArgs e)
          {
               Bitmap GrayImage = ApplyFilter(new Bitmap(MyImage), Grayscale.CommonAlgorithms.RMY);
               Bitmap EdgeImage = ApplyFilter(GrayImage, new SobelEdgeDetector());
               DisplayImage(EdgeImage, pictureBox1);
               Bitmap SegmentedImage = ApplyFilter(EdgeImage, new Threshold(128));
               //DisplayImage(SegmentedImage, pictureBox2);
               Blob[] _blobs = SegmentBlobs(SegmentedImage);
               List<Rectangle> regions = FindShapes(SegmentedImage, _blobs);
               DisplayRegionsOnSourceImage(MyImage, regions);
               Crop crop = new Crop(regions[0]);
               DisplayImage(crop.Apply(MyImage), pictureBox2);
          }

          private void DisplayRegionsOnSourceImage(Bitmap myImage, List<Rectangle> regions)
          {
               using (Graphics graphic = Graphics.FromImage(myImage))
               {
                    graphic.DrawRectangle(new Pen(Color.Yellow, 2), regions[0]);
                    DisplayImage(myImage, pictureBoxStatic);
               }
          }

          // Capture 1st display in the system
          /// <summary>
          /// Handles the Click event of the capture1stDisplayToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

          /// <summary>
          /// Displays the image.
          /// </summary>
          /// <param name="processImage">The process image.</param>
          /// <param name="pictureBox">The picture box.</param>
          private void DisplayImage(Bitmap processImage, Accord.Controls.PictureBox pictureBox)
          {
               pictureBox.Image = processImage;
          }

          /// <summary>
          /// Enables the picture box static.
          /// </summary>
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

          /// <summary>
          /// Enables the video source player.
          /// </summary>
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
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
          private void exitToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          /// <summary>
          /// Finds the shapes.
          /// </summary>
          /// <param name="image">The image.</param>
          /// <param name="blobs">The blobs.</param>
          /// <returns>List&lt;Rectangle&gt;.</returns>
          private List<Rectangle> FindShapes(Bitmap image, Blob[] blobs)
          {
               SimpleShapeChecker simpleShapeChecker = new SimpleShapeChecker();
               List<Rectangle> region = new List<Rectangle>();
               foreach (var _blob in blobs)
               {
                    List<Accord.IntPoint> edgePoints = blobCount.GetBlobsEdgePoints(_blob);
                    if (simpleShapeChecker.IsCircle(edgePoints))
                    {
                         region.Add(_blob.Rectangle);
                    }
               }
               return region;
          }

          // Open local video capture device
          /// <summary>
          /// Handles the Click event of the localVideoCaptureDeviceToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
          private void localVideoCaptureDeviceToolStripMenuItem_Click(object sender, EventArgs e)
          {
               OpenVideoDeviceSource();
          }

          /// <summary>
          /// Handles the FormClosing event of the MainForm control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
          private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
          {
               CloseCurrentVideoSource();
          }

          /// <summary>
          /// Opens the image file source.
          /// </summary>
          private void OpenImageFileSource()
          {
               openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.bmp;*.png|All files|*.*";
               openFileDialog.FileName = string.Empty;
               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    FileNameLabel.Text = openFileDialog.FileName;
                    MyImage = new Bitmap(openFileDialog.FileName);
                    DisplayImage(MyImage, pictureBoxStatic);
               }
          }

          // Open JPEG URL
          /// <summary>
          /// Handles the Click event of the openJPEGURLToolStripMenuItem control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

          /// <summary>
          /// Opens the video device source.
          /// </summary>
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

          /// <summary>
          /// Opens the video file source.
          /// </summary>
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
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

          /// <summary>
          /// Handles the Click event of the radioButtonImageSource control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

          /// <summary>
          /// Segments the blobs.
          /// </summary>
          /// <param name="_image">The image.</param>
          /// <returns>Blob[].</returns>
          private Blob[] SegmentBlobs(Bitmap _image)
          {
               blobCount = new BlobCounter();
               blobCount.FilterBlobs = true;
               blobCount.MinHeight = 80;
               blobCount.MinWidth = 80;
               blobCount.ProcessImage(_image);
               return blobCount.GetObjectsInformation();
          }

          // On timer event - gather statistics
          /// <summary>
          /// Handles the Tick event of the timer control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
          /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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
          /// <param name="args">The <see cref="NewFrameEventArgs" /> instance containing the event data.</param>
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