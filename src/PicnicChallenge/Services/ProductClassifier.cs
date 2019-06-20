using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PicnicChallenge.Services
{
    /// <summary>
    /// Classifies images to product categories
    /// </summary>
    public class ProductClassifier : IProductClassifier
    {
        /// <summary>
        /// Predicts the class given the image data
        /// </summary>
        /// <param name="imageData">Image data to classify</param>
        /// <returns>Returns the name of the predicted class</returns>
        public Task<string> Predict(Stream imageData)
        {
            //TODO : Implement pipeline
            return Task.FromResult("None");
        }
    }
}
