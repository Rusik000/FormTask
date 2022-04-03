using FormTask.Entities;
using FormTask.FakeRepo;
using FormTask.Helpers;
using FormTask.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTask.Controllers
{
    public class UserController : Controller
    {


        private readonly IWebHostEnvironment _webhost;

        public UserController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }
        //home page 
        public IActionResult Index()
        {
            var model = new UserViewModel
            {
                Users = UserRepo.Users
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserHelperViewModel model)
        {
            var helper = new ImageHelper(_webhost);
            model.User.ImagePath = await helper.SaveFile(model.File);
            UserRepo.Users.Add(model.User);
            return RedirectToAction("Index");    
        }

    }
}
