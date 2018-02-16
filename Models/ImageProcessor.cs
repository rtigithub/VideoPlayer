// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-13-2018
// ***********************************************************************
// <copyright file="ImageProcessor.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ComputerVisionVideoPlayer.Models
{
     using System;
     using System.Drawing;

     /// <summary>
     /// Class ImageProcessor.
     /// </summary>
     internal class ImageProcessor : IImageProcessor
     {
          #region Public Constructors

          /// <summary>
          /// Initializes a new instance of the <see cref="ImageProcessor"/> class.
          /// </summary>
          public ImageProcessor()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ImageProcessor"/> class.
          /// </summary>
          /// <param name="imageToBeProcessed">The image to be processed.</param>
          /// <exception cref="System.ArgumentNullException">imageToBeProcessed</exception>
          public ImageProcessor(Bitmap imageToBeProcessed)
          {
               this.ImageToBeProcessed = imageToBeProcessed ?? throw new ArgumentNullException(nameof(imageToBeProcessed));
          }

          #endregion Public Constructors

          #region Public Properties

          public IObservable<Bitmap> ProcessedImage { get; set; }
          public IObservable<Bitmap> ThresholdedImage { get; set; }
          public IObservable<Bitmap> ImageToBeProcessed { get; set; }

          #endregion Public Properties

          #region Public Methods

          /// <summary>
          /// Processes the image.
          /// </summary>
          /// <param name="tempImage">The temporary image.</param>
          /// <returns>Bitmap.</returns>
          public Bitmap ProcessImage(Bitmap tempImage)
          {
               return tempImage;
          }

          #endregion Public Methods
     }
}