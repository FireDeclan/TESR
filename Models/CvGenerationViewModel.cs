using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DelicateCV.Models
{
    public class CvGenerationViewModel
    {
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Summary { get; set; }
        public string Skills { get; set; }
        public string Institution { get; set; }
        public string Course { get; set; }
        
        public string GradYear { get; set; }
        public string Degree { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        
        public string ExperienceStart { get; set; }
        
        public string ExperienceEnd { get; set; }
        public string Duties { get; set; }
        public string Languages { get; set; }
        public string Certifications { get; set; }
    }
}
