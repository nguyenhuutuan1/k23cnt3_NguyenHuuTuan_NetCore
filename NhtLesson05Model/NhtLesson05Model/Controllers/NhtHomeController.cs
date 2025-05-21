using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NhtLesson05Model.Models;
using NhtLesson05Model.Models.DataModels;

namespace NhtLesson05Model.Controllers
{
    public class NhtHomeController : Controller
    {
        private readonly ILogger<NhtHomeController> _logger;

        public NhtHomeController(ILogger<NhtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhtIndex()
        {
            return View();
        }

        public IActionResult NhtAbout()
        {
            NhtMember nhtMember = new NhtMember();
            nhtMember.NhtMemberId = Guid.NewGuid().ToString();
            nhtMember.NhtUserName = "HuuTuan";
            nhtMember.NhtPassword = "123456@";
            nhtMember.NhtFullName = "Nguyen Huu Tuan";
            nhtMember.NhtEmail = "huutuansans@gmail.com";

            return View(nhtMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
