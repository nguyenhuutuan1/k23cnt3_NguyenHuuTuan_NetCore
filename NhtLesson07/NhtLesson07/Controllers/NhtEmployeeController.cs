using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NhtLesson07.Models;

namespace NhtLesson07.Controllers
{
    public class NhtEmployeeController : Controller
    {
        //Mock Data:
        private static List<NhtEmployee> nhtListEmployee = new List<NhtEmployee>()
        {
            new NhtEmployee
            {
                NhtId = 231090011,
                NhtName = "Nguyễn Văn A",
                NhtBirthDay = new DateTime(2005, 08, 12),
                NhtEmail = "a@example.com",
                NhtPhone = "0123456789",
                NhtSalary = 1000,
                NhtStatus = true
            },
            new NhtEmployee
            {
                NhtId = 2,
                NhtName = "Trần Thị B",
                NhtBirthDay = new DateTime(1992, 5, 15),
                NhtEmail = "b@example.com",
                NhtPhone = "0987654321",
                NhtSalary = 1200,
                NhtStatus = true
            },
            new NhtEmployee
            {
                NhtId = 3,
                NhtName = "Lê Văn C",
                NhtBirthDay = new DateTime(1988, 9, 20),
                NhtEmail = "c@example.com",
                NhtPhone = "0912345678",
                NhtSalary = 1100,
                NhtStatus = false
            },
            new NhtEmployee
            {
                NhtId = 4,
                NhtName = "Phạm Thị D",
                NhtBirthDay = new DateTime(1995, 3, 10),
                NhtEmail = "d@example.com",
                NhtPhone = "0934567890",
                NhtSalary = 1150,
                NhtStatus = true
            },
            new NhtEmployee
            {
                NhtId = 5,
                NhtName = "Đỗ Văn E",
                NhtBirthDay = new DateTime(1991, 7, 25),
                NhtEmail = "e@example.com",
                NhtPhone = "0978123456",
                NhtSalary = 1300,
                NhtStatus = false
            }
        };
        // GET: NhtEmployeeController
        public ActionResult NhtIndex()
        {
            return View(nhtListEmployee);
        }

        // GET: NhtEmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhtEmployeeController/NhtCreate
        public ActionResult NhtCreate()
        {
            var nhtEmployee = new NhtEmployee();
            return View(nhtEmployee);
        }

        // POST: NhtEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhtCreate(NhtEmployee NhtModel)
        {
            try
            {
                // thêm mới nhân viên vào list
                NhtModel.NhtId = nhtListEmployee.Max(x=>x.NhtId ) + 1;
                nhtListEmployee.Add(NhtModel);
                return RedirectToAction(nameof(NhtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhtEmployeeController/NhtEdit/5
        public ActionResult NhtEdit(int id)
        {
            var nhtEmployee = nhtListEmployee.FirstOrDefault(x => x.NhtId == id);
            return View(nhtEmployee);
        }

        // POST: NhtEmployeeController/NhtEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NhtEdit(int id, NhtEmployee nhtModel)
        {
            try
            {
                for (int i = 0;i < nhtListEmployee.Count; i ++)
                {
                    if (nhtListEmployee[i].NhtId == id)
                    {
                        nhtListEmployee[i] = nhtModel;
                        break;
                    }
                }    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NhtEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhtEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
