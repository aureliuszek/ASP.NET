﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wsei.ExchangeThings.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Wsei.ExchangeThings.Web.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CompanyModel company) 
        {
            var viewModel = new CompanyAddedViewModel
            {

                NameLength = company.Name.Length,
                DescriptionLength = company.Description.Length,
                IsHidden = !company.IsVisible
            };
            return View("CompanyAdded",viewModel);
        }
    }
}
