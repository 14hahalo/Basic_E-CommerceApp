﻿using ECommerce.Application.Models.DTOs;
using ECommerce.Application.Models.VMs;
using ECommerce.Application.Services.AdminService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagerController : Controller
    {
        private readonly IAdminService _adminService;
        public ManagerController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddManager()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddManager(AddManagerDTO addManagerDTO)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7296/");
                var responseTask = client.PostAsJsonAsync<AddManagerDTO>("api/Manager/PostManagers", addManagerDTO);

                responseTask.Wait();
                var resultTask = responseTask.Result;
                if (responseTask.IsCompletedSuccessfully)
                {
                    return RedirectToAction(nameof(ListOfManagers));
                }
                else
                {
                    return BadRequest();
                }
            }
        }
        public async Task<IActionResult> ListOfManagers()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7296/");
                //API'ın senin localinde bulunan adresini ya da server adress!!
                var responseTask = client.GetAsync("api/Manager/GetManagers");
                //Api'de bize bilgileri getirecek olan route'u yanı actionresult'ı tetikledim.
                responseTask.Wait();
                var resultTask = responseTask.Result;
                if (responseTask.IsCompletedSuccessfully)
                {
                    var readTask = resultTask.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var readData = JsonConvert.DeserializeObject<List<ListOfManagersVM>>(readTask.Result);
                    return View(readData);
                }
                else
                {
                    ViewBag.EmptyList = "List is not Found";
                    return View(new List<ListOfManagersVM>());
                }
            }
        }
        [HttpGet]
        public async Task<IActionResult> UpdateManager(Guid id)
        {
            var updateManager = await _adminService.GetManager(id);

            return View(updateManager);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateManager(UpdateManagerDTO updateManagerDTO)
        {
            if (ModelState.IsValid)
            {
                await _adminService.UpdateManager(updateManagerDTO);
                return RedirectToAction(nameof(ListOfManagers));
            }

            return View(updateManagerDTO);

        }
        public async Task<IActionResult> DeleteManager(Guid id)
        {
            await _adminService.DeleteManager(id);

            return RedirectToAction(nameof(ListOfManagers));

        }
    }

}
