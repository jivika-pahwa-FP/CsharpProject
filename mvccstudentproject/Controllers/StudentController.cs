using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvccstudentproject.Models;
using Newtonsoft.Json;

namespace mvccstudentproject.Controllers
{
    public class StudentController : Controller
    {
        string Baseurl = "https://localhost:5001/";

    public async Task<IActionResult> getStudentData()
        {
            List<Student> std = new List<Student>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Student");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<Student>>(ProductResponse);

                }
              return View(std);
            }
        }

        public async Task<IActionResult> getById(int id)
        {
            Student std = new Student();

            using (var httpClient = new HttpClient())
            {
                
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Student/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    std = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
              return View(std);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
              return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Student p)
        {
            //Editing the product http post method
            Student p1 = new Student();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/Student/", content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return RedirectToAction("getStudentData");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Student std = new Student();

            using (var httpClient = new HttpClient())
            {
                
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Student/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    std = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
              return View(std);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student p)
        {
            //Editing the product http post method
            Student p1 = new Student();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                int id = p.id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:5001/api/Student/" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return RedirectToAction("getStudentData");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            TempData["id"] = id;
            Student e = new Student();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Student/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return View(e);

        }

        [HttpPost]
        public async Task<ActionResult> Delete(Student p)
        {
            //Deleting a product
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/Student/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("getStudentData");
        }



}
}