using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models.Test;

namespace WebApplication7.Controllers
{
    public class TestController : Controller
    {
        private ITestrepository _repo;

        private IHttpContextAccessor _accessor;
        public TestController(ITestrepository repo, IHttpContextAccessor accessor)
        {
            _repo = repo;
            _accessor = accessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllTest()
        {
            List<TestModel> viewmodel =  _repo.GetAllTest();

            ViewBag.GetAllTest = viewmodel;
            return View(Json(viewmodel));
        }
        [HttpPost]
        public IActionResult PostTest(TestModel model)
        {
            model.date = DateTime.Now.ToString("HH:mm:ss");
             _repo.PostTest(model);
            return Redirect("/Test/GetAllTest");
        }
     
        [HttpGet]
        public IActionResult DelTest(int no)
        {
            _repo.DelTest(no);
            return Redirect("/Test/GetAllTest");
        }
        [HttpGet]
        public IActionResult PutTest(int no)
        {
            ViewBag.model = _repo.GetSelect(no);
            return View();
        }
        [HttpPost]
        public IActionResult EditTest(TestModel model)
        {
            _repo.PutTest(model);
            return Redirect("/Test/GetAllTest");
        }
    }
}