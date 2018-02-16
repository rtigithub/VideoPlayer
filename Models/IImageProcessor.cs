// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-16-2018
// ***********************************************************************
// <copyright file="IImageProcessor.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ComputerVisionVideoPlayer.Models
{
     using System;
     using System.Drawing;
     using ReactiveUI;

     /// <summary>
     /// Interface IImageProcessor
     /// </summary>
     /// <seealso cref="ReactiveUI.IReactiveObject" />
     /// <seealso cref="System.IDisposable" />
     internal interface IImageProcessor : IReactiveObject, IDisposable
     {
          #region Public Properties

          /// <summary>
          /// Gets or sets the image to be processed.
          /// </summary>
          /// <value>The image to be processed.</value>
          Bitmap ImageToBeProcessed { get; set; }

          /// <summary>
          /// Gets or sets the processed image.
          /// </summary>
          /// <value>The processed image.</value>
          Bitmap ProcessedImage { get; set; }

          /// <summary>
          /// Gets or sets the thresholded image.
          /// </summary>
          /// <value>The thresholded image.</value>
          Bitmap ThresholdedImage { get; set; }

          #endregion Public Properties

          #region Public Methods

          /// <summary>
          /// Processes the image.
          /// </summary>
          /// <param name="tempImage">The temporary image.</param>
          /// <returns>Bitmap.</returns>
          Bitmap ProcessImage(Bitmap tempImage);

          #endregion Public Methods
     }
}