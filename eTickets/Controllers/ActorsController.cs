using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Services;
using eTickets.Models;

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
            var data = await _services.GetAllAsync();
            return View(data);
        }
        //Get req actors/create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.AddAsync(actor);
            return RedirectToAction(nameof(Index));                              
        }
        //Get: Actrors/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);

            if (actorDetails == null) 
                return View("Empty");
            return View(actorDetails);
        }

        //Get req actors/create
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _services.GetByIdAsync(id);

            if (actorDetails == null)
                return View("Not Found");
            return View(actorDetails);
        }


        [HttpPost]
        public async Task<IActionResult> Edit( int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
