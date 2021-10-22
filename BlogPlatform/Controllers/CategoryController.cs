using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        private IRepository<Category> _categoryRepo;
        public CategoryController(IRepository<Category> categoryRepo)
        {
            this._categoryRepo = categoryRepo;
        }
        public IActionResult Index()
        {
            return View(_categoryRepo.GetAll());
        }

        public IActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            _categoryRepo.Create(newCategory);

            return View(newCategory);
        }
        public IActionResult Delete(int id)
        {
            Category cat = _categoryRepo.GetByID(id);

            return View(cat);
        }

        [HttpPost]
        public IActionResult Delete(int id, Category cat)
        {
            Category delCat = _categoryRepo.GetByID(id);
            _categoryRepo.Delete(delCat);
            return RedirectToAction("Index");


        }


    }
}