// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-16-2018
// ***********************************************************************
// <copyright file="MainFormViewModel.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ComputerVisionVideoPlayer.ViewModels
{
     using System;
     using ReactiveUI;

     /// <summary>
     /// Class MainFormViewModel.
     /// </summary>
     /// <seealso cref="ReactiveUI.ReactiveObject" />
     public class MainFormViewModel : ReactiveUI.ReactiveObject
     {
          #region Public Properties

          /// <summary>
          /// Gets the run process command.
          /// </summary>
          /// <value>The run process command.</value>
          public ReactiveCommand RunProcessCommand { get; private set; }

          #endregion Public Properties
     }
}