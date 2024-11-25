using LeaveManagementSystem.Web.Models.LeaveAllocations;
using System.ComponentModel;

namespace LeaveManagementSystem.Web.Models.LeaveRequests
{
    public class ReviewRequestVM : LeaveRequestReadOnlyVM
    {
        public EmployeeListVM Employee {  get; set; } = new EmployeeListVM();

        [DisplayName("Additional Information")]
        public string RequestComments {  get; set; }
    }
}