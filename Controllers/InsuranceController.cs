using DTO.HealthInsuranceDTO;
using DTO.MedicareDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Controllers
{
    public class InsuranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HealthInsurance(HealthDTO healthDTO)
        {
            return View();
        }
        [HttpPost]
        public IActionResult MedicareInsurance(MedicareDTO medicareDTO)
        {
            return View();
        }
        public IActionResult HealthInsurance()
        {
            return View();
        }
        public IActionResult MedicareInsurance()
        {
            return View();
        }
    }
}
