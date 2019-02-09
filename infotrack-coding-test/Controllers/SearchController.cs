using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using infotrack_coding_test.Models;

namespace infotrack_coding_test.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet("")]
        public IActionResult Search()
        {
            return View(new SearchViewModel());
        }

        [HttpPost("")]
        public async Task<IActionResult> Search([FromForm]SearchViewModel searchViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(searchViewModel);
            }
            var results = new ResultsViewModel
            {
                SearchPositions = new List<int>(),
                Keywords = searchViewModel.Keywords
            };

            return View("~/Views/Search/Results.cshtml", results);
        }
    }
}