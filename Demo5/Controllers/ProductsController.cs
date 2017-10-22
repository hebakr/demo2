using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo5.Controllers
{
    public class ProductsController : Controller
    {
        private AppDbContext _dbContext;
        public ProductsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();

            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _dbContext.Products.Find(id);

            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Products.Update(product);
                _dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _dbContext.Products.Find(id);

            _dbContext.Products.Remove(product);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}