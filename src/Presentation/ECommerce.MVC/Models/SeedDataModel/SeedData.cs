using ECommerce.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Enums;

namespace ECommerce.MVC.Models.SeedDataModel
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<ECommerceAppDbContext>();
            dbContext.Database.Migrate();
            if (dbContext.Categories.Count() == 0)
            {
                dbContext.Categories.Add(new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Home Appliances",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                });
                dbContext.Categories.Add(new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Electronics",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                });
                dbContext.Categories.Add(new Category()
                {
                    Id = Guid.NewGuid(),
                    CategoryName = "Textile",
                    CreateDate = DateTime.Now,
                    Status = Domain.Enums.Status.Active
                });
            }

            if (dbContext.Employees.Count() == 0)
            {
                dbContext.Employees.Add(new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Halil Can",
                    LastName = "Toptas",
                    EMail = "halilcan.toptas@bilgeadamboost.com",
                    Status = Status.Active,
                    Password = "1234",
                    CreateDate = DateTime.Now,
                    Role = Roles.Admin,
                    BirthDate=new DateTime(1994,12,5)
                });
            }
            dbContext.SaveChanges();

        }
    }
}
