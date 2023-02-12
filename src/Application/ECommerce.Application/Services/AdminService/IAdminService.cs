using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;

namespace ECommerce.Application.Services.AdminService
{
    public interface IAdminService
    {
        Task CreateManager(AddManagerDTO addManagerDTO);
        Task<List<ListOfManagersVM>> GetManagers();
        Task<UpdateManagerDTO> GetManager(Guid id);
        Task UpdateManager(UpdateManagerDTO updateManagerDTO);
        Task DeleteManager(Guid id);
    }
}
