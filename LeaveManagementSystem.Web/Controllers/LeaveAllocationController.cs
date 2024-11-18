using LeaveManagementSystem.Web.Models.LeaveAllocations;
using LeaveManagementSystem.Web.Services.LeaveAllocations;
using LeaveManagementSystem.Web.Services.LeaveTypes;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    [Authorize]
    public class LeaveAllocationController(ILeaveAllocationsService _leaveAllocationsService, ILeaveTypesService _leaveTypesService) : Controller
    {
        [Authorize(Roles = Roles.Administrator)]
        public async Task<IActionResult> Index(string? userId)
        {
            var employees = await _leaveAllocationsService.GetEmployees();
            return View(employees);
        }
        
        [Authorize(Roles = Roles.Administrator)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(string? id)
        {
            await _leaveAllocationsService.AllocateLeave(id);
            return RedirectToAction(nameof(Details), new { userId = id });
        }

        public async Task<IActionResult> EditAllocation(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var allocation = await _leaveAllocationsService.GetEmployeeAllocation(id.Value);
            if(allocation == null)
            {
                return NotFound();

            }
            return View(allocation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(LeaveAllocationEditVM allocationEditVm)
        {
            if (await _leaveTypesService.DaysExceedMaximum(allocationEditVm.LeaveType.Id, allocationEditVm.Days))
            {
                ModelState.AddModelError("Days", "The allocation exceeds the maximum leave type value");
            }
            if (ModelState.IsValid)
            {
                await _leaveAllocationsService.EditAllocation(allocationEditVm);
                return RedirectToAction(nameof(Details), new { userId = allocationEditVm.Employee.Id});
            }

            var days = allocationEditVm.Days;
            allocationEditVm = await _leaveAllocationsService.GetEmployeeAllocation(allocationEditVm.Id);
            allocationEditVm.Days = days;

            return View(allocationEditVm);
        }

        public async Task<IActionResult> Details(string? userId)
        {
            var employeeVm = await _leaveAllocationsService.GetEmployeeAllocations(userId);
            return View(employeeVm);
        }
    }
}
