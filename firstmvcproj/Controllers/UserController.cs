using Microsoft.AspNetCore.Mvc;
using firstmvcproj.Models;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace firstmvcproj.Controllers
{
    public class UserController : Controller
    {

        class Employee{
            public string name = "EMP1";
           }

           class user{
            public string name = null;
           }
        
        public IActionResult Index(){
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Employee,user>();
            });
            IMapper  mapper = config.CreateMapper();
            var source = new Employee();
            var dest = mapper.Map<Employee,user>(source);
            ViewData["name"] = source.name;
            System.Console.WriteLine(source.name);
            return View();
        }
    }
} 