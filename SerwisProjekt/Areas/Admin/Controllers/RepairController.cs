using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SerwisProjekt.DataAccess.Repository.IRepository;

namespace SerwisProjekt.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RepairController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RepairController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Repair.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}