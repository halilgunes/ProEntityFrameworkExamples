using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC1P.Models;

namespace MVC1P.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryRepository categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.Categories);
        }

        public IActionResult EditCategory(int id)
        {
            ViewBag.EditId = id;
            return View("Index", categoryRepository.Categories);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryRepository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            categoryRepository.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}