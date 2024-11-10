using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4, 150, ErrorMessage ="Violated Legth requirements")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90, ErrorMessage = "Vaccation can not be accepted for this length")]
        public int NumberOfDays { get; set; }

        
    }
}
