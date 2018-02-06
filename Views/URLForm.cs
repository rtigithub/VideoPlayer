// ***********************************************************************
// Assembly         : WindowsApplication
// Author           : Resolution Technology, Inc.
// Last Modified On : 02-06-2018
// ***********************************************************************
// <copyright file="URLForm.cs" company="Resolution Technology, Inc.">
//     Resolution Technology, Inc. © 2018; Portions AForge © 2008
// </copyright>
// <summary></summary>
// ***********************************************************************/

namespace ComputerVisionVideoPlayer
{
     using System;
     using System.Windows.Forms;

     /// <summary>
     /// Class URLForm.
     /// </summary>
     /// <seealso cref="System.Windows.Forms.Form" />
     public partial class URLForm : Form
     {
          #region Private Fields

          /// <summary>
          /// The URL
          /// </summary>
          private string url;

          #endregion Private Fields

          #region Public Constructors

          // Constructor
          /// <summary>
          /// Initializes a new instance of the <see cref="URLForm"/> class.
          /// </summary>
          public URLForm()
          {
               InitializeComponent();
          }

          #endregion Public Constructors

          #region Public Properties

          // Description of the dialog
          /// <summary>
          /// Gets or sets the description.
          /// </summary>
          /// <value>The description.</value>
          public string Description
          {
               get { return descriptionLabel.Text; }
               set { descriptionLabel.Text = value; }
          }

          // Selected URL
          /// <summary>
          /// Gets the URL.
          /// </summary>
          /// <value>The URL.</value>
          public string URL
          {
               get { return url; }
          }

          // URLs to display in combo box
          /// <summary>
          /// Sets the ur ls.
          /// </summary>
          /// <value>The ur ls.</value>
          public string[] URLs
          {
               set
               {
                    urlBox.Items.AddRange(value);
               }
          }

          #endregion Public Properties

          #region Private Methods

          // On "Ok" button clicked
          /// <summary>
          /// Handles the Click event of the okButton control.
          /// </summary>
          /// <param name="sender">The source of the event.</param>
          /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
          private void okButton_Click(object sender, EventArgs e)
          {
               url = urlBox.Text;
          }

          #endregion Private Methods
     }
}