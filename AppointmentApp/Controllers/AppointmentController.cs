using AppointmentApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentApp.Controllers
{
    public class AppointmentController : Controller
    {
        static List<AppointmentModel> appointments = new List<AppointmentModel>();
        public IActionResult Index()
        {
            return View(appointments);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(AppointmentModel appointment) //this is what we are expecting to see in our view basd on the details being passed through the controller
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }
    }
}
