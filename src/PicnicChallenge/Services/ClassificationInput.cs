using Microsoft.ML.Transforms.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PicnicChallenge.Services
{
    /// <summary>
    /// Defines the input data for the ML.NET model
    /// </summary>
    public class ClassificationInput
    {
        /// <summary>
        /// Gets or sets the image that needs to be classified
        /// </summary>
        [ImageType(225, 225)]
        public Bitmap Image { get; set; }
    }
}
