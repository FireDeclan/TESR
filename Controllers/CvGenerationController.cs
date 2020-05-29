using DelicateCV.Entities;
using DelicateCV.Models;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DelicateCV.Controllers
{
    public class CvGenerationController : Controller
    {
        private IConverter _converter;

        public CvGenerationController(IConverter converter)
        {
            _converter = converter;
        }


        [HttpPost]
        public IActionResult CvOne(CvGenerationViewModel model)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Delicate Cv PDF"
            };

            var objectSettings = new ObjectSettings
            {
                //PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(model),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "Data", "template1.css") },
               // HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
               // FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var file = _converter.Convert(pdf);
            return File(file, "application/pdf");

            /*UserDetails user = TempData["userdata"] as UserDetails;*/
            /*model.Fullname = data.Fullname;
            model.Phone = data.Phone;
            model.Email = data.Email;
            model.Summary = data.Summary;
            model.Skills = data.Skills;
            model.Institution = data.Institution;
            model.Course = data.Course;
            model.GradYear = data.GradYear;
            model.Degree = data.Degree;
            model.Company = data.Company;
            model.JobTitle = data.JobTitle;
            model.ExperienceStart = data.ExperienceStart;
            model.ExperienceEnd = data.ExperienceEnd;
            model.Duties = data.Duties;
            model.Languages = data.Languages;
            model.Certifications = data.Certifications;*/

            //return  View("CvOne", model);
            
        }

        [HttpPost]
        public IActionResult CvTwo(CvGenerationViewModel model)
        {

            return  View("CvTwo", model);

        }

        [HttpPost]
        public IActionResult CvThree(CvGenerationViewModel model)
        {

            return  View("CvThree", model);

        }
    }
}
