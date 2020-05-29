using DelicateCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelicateCV.Entities
{
    public class TemplateGenerator
    {
        public static string GetHTMLString(CvGenerationViewModel model)
        {
            //var employees = DataStorage.GetAllEmployess();

            var sb = new StringBuilder();
            sb.AppendLine(@"<!DOCTYPE html>");
            sb.AppendLine(@"<html lang='en'>");
            sb.AppendLine(@"<head>");
            sb.AppendLine(@"    <meta charset='UTF-8' />");
            sb.AppendLine(@"    <meta name='viewport' content='width=device-width, initial-scale=1.0' />");
            sb.AppendLine(@"    <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous' />");
            sb.AppendLine(@"    <link rel='stylesheet' href='css/index.css' />");
            sb.AppendLine(@"    <link rel='stylesheet' href='css/template1.css' />");
            sb.AppendLine(@"    <title>CV Template 1</title>");
            sb.AppendLine(@"</head>");
            sb.AppendLine(@"<body class='template-body'>");
            sb.AppendLine(@"    <!-- template header -->");
            sb.AppendLine(@"    <div class='template-container'>");
            sb.AppendLine(@"        <div class='jumbotron jumbotron-fluid bg-info text-white'>");
            sb.AppendLine(@"            <div class='container main'>");
            sb.AppendLine(@"                <div class='row'>");
            sb.AppendLine(@"                    <div class='col-md-6'>");
            sb.AppendLine(@"                        <h1 class='h1 ml-3'>");
            sb.AppendFormat(@"                            <span class='firstname'>{0}</span>", model.Fullname);
            sb.AppendLine(@"                        </h1>");
            sb.AppendLine(@"                    </div>");
            sb.AppendLine(@"                    <div class='col-md-2'></div>");
            sb.AppendLine(@"                    <div class='col-md-4'>");
            
            sb.AppendLine(@"                        <div class='phone'>");
            sb.AppendLine(@"                            <h6>Phone</h6>");
            sb.AppendFormat(@"                            <small>{0}</small>", model.Phone);
            sb.AppendLine(@"                        </div>");
            sb.AppendLine(@"                        <div class='email'>");
            sb.AppendLine(@"                            <h6>Email</h6>");
            sb.AppendFormat(@"                            <small>{0}</small>", model.Email);
            sb.AppendLine(@"                        </div>");
            sb.AppendLine(@"                    </div>");
            sb.AppendLine(@"                </div>");
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"        </div>");
            sb.AppendLine(@"        <div class='template-content'>");
            sb.AppendLine(@"            <div class='summary'>");
            sb.AppendLine(@"                <h5 class='h5'>Summary</h5>");
            sb.AppendFormat(@"                <p>{0}</p>", model.Summary);
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"            <div class='skill'>");
            sb.AppendLine(@"                <h5 class='h5'>Skills Highlights</h5>");
            sb.AppendLine(@"                <ul>");
            sb.AppendFormat(@"                    <li>{0}</li>", model.Skills);
            
            sb.AppendLine(@"                </ul>");
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"            <div class='experience'>");
            sb.AppendLine(@"                <h5 class='h5'>Experience</h5>");
            sb.AppendFormat(@"                <p><span class='job-title'>{0}</span>: <span>{1} - {2}</span></p>", model.JobTitle, model.ExperienceStart, model.ExperienceEnd);
            sb.AppendFormat(@"                <p>{0}</p>", model.Company);
            sb.AppendLine(@"                <ul>");
            sb.AppendFormat(@"                    <li>{0}</li>", model.Duties);
            
            sb.AppendLine(@"                </ul>");
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"            <div class='education'>");
            sb.AppendLine(@"                <h5 class='h5'>Education</h5>");
            sb.AppendFormat(@"                <p>{0} {1} &mdash; {2}</p>", model.Degree, model.Course, model.GradYear);
            sb.AppendFormat(@"                <p>{0}</p>", model.Institution);
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"            <div class='languages'>");
            sb.AppendLine(@"                <h5 class='h5'>Languages</h5>");
            sb.AppendLine(@"                <ul>");
            sb.AppendFormat(@"                    <li>{0}</li>", model.Languages);
            
            sb.AppendLine(@"                </ul>");
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"            <div class='certification'>");
            sb.AppendLine(@"                <h5 class='h5'>Certifications</h5>");
            sb.AppendFormat(@"                <p>{0}</p>", model.Certifications);
            
            sb.AppendLine(@"            </div>");
            sb.AppendLine(@"        </div>");
            sb.AppendLine(@"        <div class='template-footer bg-info'></div>");
            sb.AppendLine(@"    </div>");
            sb.AppendLine(@"    <script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'");
            sb.AppendLine(@"            integrity='sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj'");
            sb.AppendLine(@"            crossorigin='anonymous'></script>");
            sb.AppendLine(@"    <script src='https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js'");
            sb.AppendLine(@"            integrity='sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo'");
            sb.AppendLine(@"            crossorigin='anonymous'></script>");
            sb.AppendLine(@"    <script src='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js'");
            sb.AppendLine(@"            integrity='sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI'");
            sb.AppendLine(@"            crossorigin='anonymous'></script>");
            sb.AppendLine(@"</body>");
            sb.AppendLine(@"</html>");

            return sb.ToString();


        }
    }
}
