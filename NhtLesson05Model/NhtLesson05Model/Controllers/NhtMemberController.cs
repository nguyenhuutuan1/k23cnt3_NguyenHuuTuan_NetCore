using Microsoft.AspNetCore.Mvc;
using NhtLesson05Model.Models.DataModels;

namespace NhtLesson05Model.Controllers
{
    public class NhtMemberController : Controller
    {
        private static List<NhtMember> nhtListMember = new List<NhtMember>()
        {
            new NhtMember
            {
                NhtMemberId = "2310900112",
                NhtUserName = "HuuTuan",
                NhtPassword = "pass123",
                NhtFullName = "Nguyen Huu Tuan",
                NhtEmail = "huutuansans@gmail.com"
            },
            new NhtMember
            {
                NhtMemberId = "M002",
                NhtUserName = "lan456",
                NhtPassword = "pass456",
                NhtFullName = "Tran Thi Lan",
                NhtEmail = "lan@example.com"
            },
            new NhtMember
            {
                NhtMemberId = "M003",
                NhtUserName = "minh789",
                NhtPassword = "pass789",
                NhtFullName = "Le Minh Hoang",
                NhtEmail = "minh@example.com"
            },
            new NhtMember
            {
                NhtMemberId = "M004",
                NhtUserName = "thu999",
                NhtPassword = "pass999",
                NhtFullName = "Pham Thi Thu",
                NhtEmail = "thu@example.com"
            },
            new NhtMember
            {
                NhtMemberId = "M005",
                NhtUserName = "bao888",
                NhtPassword = "pass888",
                NhtFullName = "Doan Bao Chau",
                NhtEmail = "bao@example.com"
            }
        };
        public IActionResult NhtIndex() //List  member
        {
            return View();
        }
    }
}
