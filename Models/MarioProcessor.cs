// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-16-2018
// ***********************************************************************
// <copyright file="MarioProcessor.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ComputerVisionVideoPlayer.Models
{
     using System;
     using System.Drawing;
     using System.Reactive.Disposables;
     using Accord;
     using Accord.Imaging;
     using Accord.Imaging.Filters;
     using ReactiveUI;

     /// <summary>
     /// Class MarioProcessor.
     /// </summary>
     /// <seealso cref="ReactiveUI.ReactiveObject" />
     /// <seealso cref="ComputerVisionVideoPlayer.Models.IImageProcessor" />
     internal class MarioProcessor : ReactiveObject, IImageProcessor
     {
          #region Private Fields

          /// <summary>
          /// The image to be processed
          /// </summary>
          private Bitmap _imageToBeProcessed;

          /// <summary>
          /// The processed image
          /// </summary>
          private Bitmap _processedImage;

          /// <summary>
          /// The thresholded image
          /// </summary>
          private Bitmap _thresholdedImage;

          /// <summary>
          /// The disposable collection
          /// </summary>
          private CompositeDisposable disposableCollection;

          /// <summary>
          /// The disposed value
          /// </summary>
          private bool disposedValue = false;

          /// <summary>
          /// The fill hue
          /// </summary>
          private int fillHue = 0;

          /// <summary>
          /// The fill luminance
          /// </summary>
          private float fillLuminance = 0;

          /// <summary>
          /// The fill saturation
          /// </summary>
          private float fillSaturation = 0f;

          /// <summary>
          /// The filters sequence
          /// </summary>
          private FiltersSequence filtersSequence = new FiltersSequence();

          /// <summary>
          /// The HSL filter
          /// </summary>
          private HSLFiltering hslFilter = new HSLFiltering();

          /// <summary>
          /// The hue
          /// </summary>
          private IntRange hue = new IntRange((int)(360.0 * 45.0 / 255.0), (int)(360.0 * 237.0 / 255.0));

          /// <summary>
          /// The luminance
          /// </summary>
          private Range luminance = new Range(0, 1);

          /// <summary>
          /// The saturation
          /// </summary>
          private Range saturation = new Range(0, 1);

          #endregion Private Fields

          #region Public Constructors

          /// <summary>
          /// Initializes a new instance of the <see cref="MarioProcessor" /> class.
          /// </summary>
          public MarioProcessor()
          {
          }

          #endregion Public Constructors

          #region Public Properties

          /// <summary>
          /// Gets the disposable collection.
          /// </summary>
          /// <value>The disposable collection.</value>
          public CompositeDisposable DisposableCollection => this.disposableCollection;

          /// <summary>
          /// Gets or sets the image to be processed.
          /// </summary>
          /// <value>The image to be processed.</value>
          public Bitmap ImageToBeProcessed
          {
               get { return _imageToBeProcessed; }
               set { this.RaiseAndSetIfChanged(ref _imageToBeProcessed, value); }
          }

          /// <summary>
          /// Gets or sets the processed image.
          /// </summary>
          /// <value>The processed image.</value>
          Bitmap IImageProcessor.ProcessedImage
          {
               get { return _processedImage; }
               set { this.RaiseAndSetIfChanged(ref _processedImage, value); }
          }

          /// <summary>
          /// Gets or sets the thresholded image.
          /// </summary>
          /// <value>The thresholded image.</value>
          Bitmap IImageProcessor.ThresholdedImage
          {
               get { return _thresholdedImage; }
               set { this.RaiseAndSetIfChanged(ref _thresholdedImage, value); }
          }

          #endregion Public Properties

          #region Public Methods

          // This code added to correctly implement the disposable pattern.
          /// <summary>
          /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
          /// </summary>
          public void Dispose()
          {
               // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
               Dispose(true);
               // TODO: uncomment the following line if the finalizer is overridden above.
               // GC.SuppressFinalize(this);
          }

          /// <summary>
          /// Processes the image.
          /// </summary>
          /// <param name="tempImage">The temporary image.</param>
          /// <returns>System.Drawing.Bitmap.</returns>
          /// <exception cref="NotImplementedException"></exception>
          public Bitmap ProcessImage(Bitmap tempImage)
          {
               throw new NotImplementedException();
          }

          /// <summary>
          /// Processes the image to be processed.
          /// </summary>
          /// <param name="tempImage">The temporary image.</param>
          /// <returns>System.Drawing.Bitmap.</returns>
          public Bitmap ProcessImageToBeProcessed(Bitmap tempImage)
          {
               hslFilter.Hue = hue;
               hslFilter.Saturation = saturation;
               hslFilter.Luminance = luminance;
               hslFilter.FillOutsideRange = false;
               hslFilter.FillColor = new HSL(0, 0f, 0f);
               return ApplyFilter(tempImage, hslFilter);
          }

          #endregion Public Methods

          #region Protected Methods

          /// <summary>
          /// Disposes the specified disposing.
          /// </summary>
          /// <param name="disposing">The disposing.</param>
          protected virtual void Dispose(bool disposing)
          {
               if (!disposedValue)
               {
                    if (disposing)
                    {
                         // TODO: dispose managed state (managed objects).
                         this.disposableCollection?.Dispose();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                    // TODO: set large fields to null.

                    disposedValue = true;
               }
          }

          #endregion Protected Methods

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

          #endregion Private Methods
     }
}