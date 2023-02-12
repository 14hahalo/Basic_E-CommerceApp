using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;
using ECommerce.Application.Services.AdminService;
using ECommerce.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IAdminService _adminService;
        public ManagerController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public async Task<ActionResult<List<ListOfManagersVM>>> GetAllManagers()
        {
            var managers = await _adminService.GetManagers();
            if (managers == null)
            {
                return NotFound();
            }
            return Ok(managers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UpdateManagerDTO>> GetManager([FromRoute] Guid id)
        {
            var manager = await _adminService.GetManager(id);
            if (manager == null)
            {
                return NotFound();
            }
            return Ok(manager);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<UpdateManagerDTO>> DeleteManager([FromRoute] Guid id)
        {
            await _adminService.DeleteManager(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CreateManager([FromBody]AddManagerDTO addManagerDTO)
        {
            try
            {
                await _adminService.CreateManager(addManagerDTO);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok(addManagerDTO);
        }
    }
}
