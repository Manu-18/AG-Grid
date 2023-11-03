using AG_Grid.Models;
using Microsoft.AspNetCore.Mvc;

namespace AG_Grid.Controllers
{
    public class AgGridController : Controller
    {
        private readonly DataDBContext tempDB;
        public AgGridController(DataDBContext dataDB)
        {
            this.tempDB = dataDB;
        }
        [HttpGet]
        public IActionResult AgGrid()
        {
            var studentData = tempDB.Data.ToList();

            return View(studentData);
        }

        [HttpPost]
        public IActionResult Edit([FromBody] Data data)
        {
            var updateDta = tempDB.Data.Find(data.Id);



            // Update the properties of the existing student with the new data
            updateDta.FirstName = data.FirstName;
            updateDta.LastName = data.LastName;
            updateDta.Contact = data.Contact;
            updateDta.Colony = data.Colony;
            updateDta.City = data.City;
            updateDta.Country = data.Country;

            tempDB.SaveChanges();

            return RedirectToAction("Index","Home");

        }
    }

}
