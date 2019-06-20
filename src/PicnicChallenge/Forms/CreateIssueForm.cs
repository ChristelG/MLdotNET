using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace PicnicChallenge.Forms
{
    /// <summary>
    /// Defines the data the user can submit to create a new issue
    /// </summary>
    public class CreateIssueForm
    {
        /// <summary>
        /// Predicted image category
        /// </summary>
        [DisplayName("Item category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// The comments for the issue
        /// </summary>
        public string Comments { get; set; }
    }
}