using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicnicChallenge.Forms
{
    /// <summary>
    /// Form used to upload an image of the defective product
    /// </summary>
    public class UploadImageForm
    {
        /// <summary>
        /// Gets or sets the uploaded image data
        /// </summary>
        [Required]
        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
    }
}
