using AutoMapper;
using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Enums;
using ECommerce.Domain.Repositories;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ECommerce.Application.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepo _employeeRepo;
        public AdminService(IMapper mapper, IEmployeeRepo employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }
        public async Task CreateManager(AddManagerDTO addManagerDTO)
        {
            var addEmployee = _mapper.Map<Employee>(addManagerDTO);
            if (addEmployee.UploadPath != null)
            {
                using var image = Image.Load(addManagerDTO.UploadPath.OpenReadStream());
                image.Mutate(x => x.Resize(600, 560));// Size of the uploaded picture
                Guid guid = Guid.NewGuid();
                image.Save($"/wwwroot/images/{guid}.jpg");
                addEmployee.ImagePath = ($"/images/{guid}.jpg");
                await _employeeRepo.Create(addEmployee);
            }
            else
            {
                addEmployee.ImagePath = ($"/images/default.png");
                await _employeeRepo.Create(addEmployee);
            }
        }
        public async Task<List<ListOfManagersVM>> GetManagers()
        {
            var managers = await _employeeRepo.GetFilteredList(
                select: x => new ListOfManagersVM
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Role = x.Role
                },
                where: x => (x.Status == Status.Active && x.Role == Roles.Manager),
                orderBy: x => x.OrderBy(x => x.FirstName));
            return managers;
        }
    }
}
