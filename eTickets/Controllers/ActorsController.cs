using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Services;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorService _services;
       
        public ActorsController (IActorService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAll();
            return View(data);
        }
    }
}
