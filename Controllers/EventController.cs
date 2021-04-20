using Fantastical_Events_2021.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fantastical_Events_2021.Models;
using Microsoft.AspNetCore.Http; 

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

            var events = _context.Events.OrderBy(e => e.EventName).ToList();
            return View(events.ToList());
        }

        public IActionResult Browse(int eventId)
        {

            var activities = _context.Activities.Where(a => a.EventId == eventId).OrderBy(a => a.ActivityName).ToList();
             
            ViewBag.events = _context.Events.Find(eventId).EventName.ToString();
            return View(activities);

            
        }

       



    }
}
