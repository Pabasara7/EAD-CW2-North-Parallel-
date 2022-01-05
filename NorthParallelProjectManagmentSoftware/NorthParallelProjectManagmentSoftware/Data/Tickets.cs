using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NorthParallelProjectManagmentSoftware.Data
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        public string TicketName { get; set; }
        [Required]
        public Company TicketCompany { get; set; }
        [Required]
        public Project TicketProject { get; set; }
        [Required]
        public User TicketAssignedUser { get; set; }
        [Required]
        public string TicketDescription { get; set; }
        [Required]
        public string TicketProgress { get; set; }
        [Required]
        public string TicketCurrentStateUpdate { get; set; }
        [Required]
        public DateTime TicketStartDate { get; set; }
        [Required]
        public string MainCompany { get; set; }
    }
}
