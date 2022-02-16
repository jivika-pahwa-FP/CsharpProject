using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using airflight.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace airflight.Controllers
{
    public class ProductController : Controller
    {
        
        private readonly DatabaseTrainingContext db;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(DatabaseTrainingContext _db, IWebHostEnvironment web){
            db = _db;
            webHostEnvironment = web;
        }

        public IActionResult ProductList(){
            return View(db.PracticeTables.ToList());
        }
       // [Route("Producttttt")]
        [HttpGet]
        public IActionResult AddProduct(){
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            using (var db=new DatabaseTrainingContext())
            {
                 string uniqueFileName = null;  
  
            if (p.Image != null)  
            {  
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "image");  
                uniqueFileName=p.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    p.Image.CopyTo(fileStream);  
                }  
                PracticeTable p1 = new PracticeTable();
                p1.Id =p.Id;
                p1.Image = "~/image/"+uniqueFileName;
                p1.ProductName = p.ProductName;
                db.PracticeTables.Add(p1);
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            else
             return View();
            }
        }
              }
    }

 