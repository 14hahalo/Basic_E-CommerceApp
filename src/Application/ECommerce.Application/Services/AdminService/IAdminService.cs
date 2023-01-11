using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;

namespace ECommerce.Application.Services.AdminService
{
    public interface IAdminService
    {
        Task CreateManager(AddManagerDTO addManagerDTO);
        Task<List<ListOfManagersVM>> GetManagers();
    }
}
