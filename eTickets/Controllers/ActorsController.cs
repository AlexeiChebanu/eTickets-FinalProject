﻿using eTickets.Data;
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
            var data = await _services.GetAll();
            return View(data);
        }
        //Get req actros/create
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
            _services.Add(actor);
            return RedirectToAction(nameof(Index));         
                       
        }
    }
}
