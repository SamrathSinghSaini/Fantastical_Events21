using Fantastical_Events_2021.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Controllers
{
    public class EventController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var activities = _context.Activities.OrderBy(a => a.ActivityName).ToList();
            return View();
        }

       
    }
}
