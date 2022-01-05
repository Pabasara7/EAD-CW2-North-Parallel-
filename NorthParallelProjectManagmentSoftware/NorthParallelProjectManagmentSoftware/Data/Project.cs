using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public Company ProjectCompany { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public List<User> ProjectUsers { get; set; }
        [Required]
        public List<Tickets> ProjectTickets { get; set; }
        [Required]
        public DateTime ProjectStartDate { get; set; }
        [Required]
        public DateTime ProjectEndDate { get; set; }
        [Required]
        public string MainCompany { get; set; }
    }
}
