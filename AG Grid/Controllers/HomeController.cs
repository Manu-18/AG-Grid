using AG_Grid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AG_Grid.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataDBContext tempDB;
        public HomeController(DataDBContext dataDB)
        {
            this.tempDB = dataDB;
        }

        [HttpGet]
        public IActionResult Index()    
        {
            

            return View();
        }
        

        [HttpPost]
        public IActionResult Index(Data std) //Create ->Insert
        {
            if (ModelState.IsValid)
            {
                tempDB.Data.Add(std);
                tempDB.SaveChanges();
                return RedirectToAction("AgGrid", "AgGrid");
            }
            return View();
        }
        //public IActionResult AgGrid()
        //{

        //    var studentData = tempDB.Data.ToList();

        //    return View(studentData);
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}