using DelicateCV.Entities;
using DelicateCV.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelicateCV.Controllers
{
    public class CvFormController : Controller
    {
        [HttpGet]
        public IActionResult FormOne()
        {
            return View();
        }


        [HttpPost]
        public IActionResult FormOne(CvFormViewModel model)
        {
            UserDetails user = new UserDetails
            {
                Fullname = model.Fullname,
                Phone = model.Phone,
                Email = model.Email,
                Summary = model.Summary,
                Skills = model.Skills,
                Institution = model.Institution,
                Course = model.Course,
                GradYear = model.GradYear,
                Degree = model.Degree,
                Company = model.Company,
                JobTitle = model.JobTitle,
                ExperienceStart = model.ExperienceStart,
                ExperienceEnd = model.ExperienceEnd,
                Duties = model.Duties,
                Languages = model.Languages,
                Certifications = model.Certifications
            };
            TempData["userdata"] = user;
            return RedirectToAction("CvOne", "CvGeneration");
        }

        [HttpGet]
        public IActionResult FormTwo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormTwo(CvFormViewModel model)
        {
            UserDetails user = new UserDetails
            {
                Fullname = model.Fullname,
                Phone = model.Phone,
                Email = model.Email,
                Summary = model.Summary,
                Skills = model.Skills,
                Institution = model.Institution,
                Course = model.Course,
                GradYear = model.GradYear,
                Degree = model.Degree,
                Company = model.Company,
                JobTitle = model.JobTitle,
                ExperienceStart = model.ExperienceStart,
                ExperienceEnd = model.ExperienceEnd,
                Duties = model.Duties,
                Languages = model.Languages,
                Certifications = model.Certifications
            };
            TempData["userdata"] = user;
            return RedirectToAction("CvTwo", "CvGeneration");
        }

        [HttpGet]
        public IActionResult FormThree()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormThree(CvFormViewModel model)
        {
            UserDetails user = new UserDetails
            {
                Fullname = model.Fullname,
                Phone = model.Phone,
                Email = model.Email,
                Summary = model.Summary,
                Skills = model.Skills,
                Institution = model.Institution,
                Course = model.Course,
                GradYear = model.GradYear,
                Degree = model.Degree,
                Company = model.Company,
                JobTitle = model.JobTitle,
                ExperienceStart = model.ExperienceStart,
                ExperienceEnd = model.ExperienceEnd,
                Duties = model.Duties,
                Languages = model.Languages,
                Certifications = model.Certifications
            };
            TempData["userdata"] = user;
            return RedirectToAction("CvThree", "CvGeneration");
        }
    }
}
