using ECommerce.Application.Models.DTOs;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Services.Login_Service
{
    public interface ILoginService
    {
        Task<Employee> Login(LoginDTO loginDTO);
    }
}
