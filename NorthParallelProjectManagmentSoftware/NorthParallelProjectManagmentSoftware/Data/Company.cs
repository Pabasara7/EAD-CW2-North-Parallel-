using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Decription for the company is required")]
        public string CompanyDescription { get; set; }
        [Required]
        public List<Project> CompanyProjects { get; set; }
        [Required]
        public List<User> CompanyUsers { get; set; }
        [Required]
        public DateTime CompanyJoinedDate { get; set; }
        [Required]
        public string MainCompany { get; set; }
    }
}
