﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Sample.Controllers
{
    using DataModel;
    using Model.Pies;
    using Repository;

    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        public PieController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var data = this.pieRepository.GetAllPies().OrderBy(a => a.Name);
            return View(new PieViewModel
            {
                Title = "Welcome to Bethanya's Pie Shop",
                Pies = data.Any() ? data.ToList() : new List<Pie>()
            });
        }

        public IActionResult Details(int id)
        {
            var data = this.pieRepository.GetPieById(id);
            if (data == null)
                return NotFound();

            return View(data);
        }


    }
}