using Microsoft.AspNetCore.Mvc;
using NhtLab06.Models;

namespace NhtLab06.Controllers
{
    public class NhtEmployeeController : Controller
    {
        private static List<NhtEmployee> nhtListEmployee = new List<NhtEmployee>()
        {
            new NhtEmployee { NhtId = 1, NhtName = "Nguyễn Hữu Tuấn", NhtBirthDay = new DateTime(2005, 08, 12), NhtEmail = "huutuansans@gmail.com", NhtPhone = "0328942958", NhtSalary = 1000, NhtStatus = true },
            new NhtEmployee { NhtId = 2, NhtName = "Trần Thị B", NhtBirthDay = new DateTime(1992, 5, 15), NhtEmail = "b@example.com", NhtPhone = "0987654321", NhtSalary = 1200, NhtStatus = true },
            new NhtEmployee { NhtId = 3, NhtName = "Lê Văn C", NhtBirthDay = new DateTime(1988, 9, 20), NhtEmail = "c@example.com", NhtPhone = "0912345678", NhtSalary = 1100, NhtStatus = false },
            new NhtEmployee { NhtId = 4, NhtName = "Phạm Thị D", NhtBirthDay = new DateTime(1995, 3, 10), NhtEmail = "d@example.com", NhtPhone = "0934567890", NhtSalary = 1150, NhtStatus = true },
            new NhtEmployee { NhtId = 5, NhtName = "Đỗ Văn E", NhtBirthDay = new DateTime(1991, 7, 25), NhtEmail = "e@example.com", NhtPhone = "0978123456", NhtSalary = 1300, NhtStatus = false }

        };

        public IActionResult NhtIndex()
        {
            return View(nhtListEmployee);
        }

        // Action GET: /NhtEmployee/HvtCreate
        public ActionResult NhtCreate(NhtEmployee model)
        {
            if (ModelState.IsValid)
            {
                // tu dong tang ID
                int newId = nhtListEmployee.Any() ? nhtListEmployee.Max(e => e.NhtId) + 1 : 1;
                model.NhtId = newId;

                nhtListEmployee.Add(model);

                //chuyen huong ve trang danh sach
                return RedirectToAction("NhtIndex");
            }

            // Nếu có lỗi, trả lại view form để sửa
            return View(model);
        }

        [HttpPost]
        public IActionResult NhtCreateSubmit(NhtEmployee emp)
        {
            emp.NhtId = nhtListEmployee.Max(e => e.NhtId) + 1;
            nhtListEmployee.Add(emp);
            return RedirectToAction("NhtIndex");
        }

        [HttpGet]
        public IActionResult NhtEdit(int id)
        {
            var emp = nhtListEmployee.FirstOrDefault(e => e.NhtId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult NhtEditPUT(NhtEmployee updatedEmp)
        {
            var emp = nhtListEmployee.FirstOrDefault(e => e.NhtId == updatedEmp.NhtId);
            if (emp != null)
            {
                emp.NhtName = updatedEmp.NhtName;
                emp.NhtBirthDay = updatedEmp.NhtBirthDay;
                emp.NhtEmail = updatedEmp.NhtEmail;
                emp.NhtPhone = updatedEmp.NhtPhone;
                emp.NhtSalary = updatedEmp.NhtSalary;
                emp.NhtStatus = updatedEmp.NhtStatus;
            }
            return RedirectToAction("NhtIndex");
        }

        public IActionResult NhtDelete(int id)
        {
            var emp = nhtListEmployee.FirstOrDefault(e => e.NhtId == id);
            if (emp != null) nhtListEmployee.Remove(emp);
            return RedirectToAction("NhtIndex");
        }

    }
}
