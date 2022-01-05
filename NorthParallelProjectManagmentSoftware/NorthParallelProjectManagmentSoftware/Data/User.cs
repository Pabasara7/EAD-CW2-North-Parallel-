using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class User
    {

        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required]
        public string UserAuthorityLevel { get; set; }

        public Company UserAssignedCompany { get; set; }
        public Project UserAssignedProjects { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        public string MainCompany { get; set; }
        public List<Tickets> UserAssignedTickets { get; set; }
        public string UserState { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string UserPassword { get; set; }

    }
}
