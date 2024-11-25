using LeaveManagementSystem.Web.Models.LeaveAllocations;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public interface ILeaveAllocationsService
    {
        Task AllocateLeave(string employeeId);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int? allocationId);
        Task<LeaveAllocation> GetCurrentAllocation(int leaveTypeId, string employeeId);
        Task<List<EmployeeListVM>> GetEmployees();
        Task EditAllocation(LeaveAllocationEditVM allocationEditVm);
    }
}