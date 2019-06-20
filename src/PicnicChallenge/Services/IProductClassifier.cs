using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PicnicChallenge.Services
{
    /// <summary>
    /// Implement this interface to define a product classifier
    /// </summary>
    public interface IProductClassifier
    {
        /// <summary>
        /// Predicts the class given the image data
        /// </summary>
        /// <param name="imageData">Image data to classify</param>
        /// <returns>Returns the name of the predicted class</returns>
        Task<String> Predict(Stream imageData);
    }
}
