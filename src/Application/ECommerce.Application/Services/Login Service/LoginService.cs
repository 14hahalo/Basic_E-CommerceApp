using ECommerce.Application.Models.DTOs;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;

namespace ECommerce.Application.Services.Login_Service
{
    public class LoginService : ILoginService
    {
        private readonly IEmployeeRepo _employeeRepo;
        public LoginService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<Employee> Login(LoginDTO loginDTO)
        {
            var employee = await _employeeRepo.GetDefault(
                x => x.EMail == loginDTO.EMail &&
                x.Password == loginDTO.Password);
            return employee;
        }
    }
}
