using Microsoft.AspNetCore.Mvc;
using PicnicChallenge.Forms;
using PicnicChallenge.Services;
using System.Drawing;
using System.Threading.Tasks;

namespace PicnicChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductClassifier _productClassifier;

        /// <summary>
        /// Initializes a new instance of <see cref="HomeController"/>
        /// </summary>
        /// <param name="productClassifier">Classifier to use</param>
        public HomeController(IProductClassifier productClassifier)
        {
            _productClassifier = productClassifier;
        }

        /// <summary>
        /// Renders the index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Accepts an image upload and produces the form
        /// to provide additional details.
        /// </summary>
        /// <param name="form">Form data to use</param>
        /// <returns>Returns the </returns>
        [HttpPost]
        public async Task<IActionResult> AdditionalDetails([FromForm]UploadImageForm form)
        {
            var category = await _productClassifier.Predict(form.Image.OpenReadStream());

            return View(new CreateIssueForm
            {
                ItemCategory = category
            });
        }

        /// <summary>
        /// Submits the issue for further processing
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SubmitIssue([FromForm]CreateIssueForm form)
        {
            // This does nothing, obviously, but could submit the issue internally.
            return Redirect("Thanks");
        }

        /// <summary>
        /// Renders the thank you page.
        /// </summary>
        /// <returns></returns>
        public IActionResult Thanks()
        {
            return View();
        }
    }
}