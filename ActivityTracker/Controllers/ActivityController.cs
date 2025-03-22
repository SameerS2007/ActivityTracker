using ActivityTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActivityTracker.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDBContext db;
        public ActivityController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Activities.ToList());
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Name, Date")]  Activity activity)
        {
            db.Activities.Add(activity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
