using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class ContentController : Controller
    {
        private IRepository<Content> _contentRepo;
        public ContentController(IRepository<Content> contentRepo)
        {
            this._contentRepo = contentRepo;
        }
        public IActionResult Index()
        {
            return View(_contentRepo.GetAll());
        }
        
        public IActionResult Create()
        {
            ViewBag.Categories = _contentRepo.GetAllCategories();
            return View(new Content());
        }
        
        [HttpPost]
        public IActionResult Create(Content newContent)
        {
            ViewBag.Categories = _contentRepo.GetAllCategories();
            newContent.PublishDate = DateTime.Now;
            _contentRepo.Create(newContent);
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Content content = _contentRepo.GetByID(id);

            return View(content);
        }
        [HttpPost]
        public IActionResult Delete(int id, Content content)
        {
            Content contentDel = _contentRepo.GetByID(content.Id);
            _contentRepo.Delete(contentDel);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Content content = _contentRepo.GetByID(id);
            return View(content);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                int x = id.GetValueOrDefault();
                Content content = _contentRepo.GetByID(x);
                return View(content);
            }

        }
        [HttpPost]
        public IActionResult Edit(int id, Content content)
        {
            _contentRepo.Update(content);
            return RedirectToAction("Index");

        }
    }
}
