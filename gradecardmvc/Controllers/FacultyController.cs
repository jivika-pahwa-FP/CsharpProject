using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gradecardmvc.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net;

namespace gradecardmvc.Controllers
{
    public class FacultyController : Controller
    {
        
        string Baseurl = "https://localhost:5001/";

        [HttpGet]
        public IActionResult Login(){
                return View();
        }

        [HttpPost]
            public async Task<IActionResult> Login(TeacherTable obj){
                TeacherTable faculty = new TeacherTable();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Clear();
                System.Console.WriteLine("within block");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.PostAsync("api/Faculty/CheckLogin",content1);
                 System.Console.WriteLine("Api Checked "+Res.StatusCode);
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    faculty = JsonConvert.DeserializeObject<TeacherTable>(ProductResponse);
                   // System.Console.WriteLine(faculty.Id + faculty.Name + faculty.Password);
                    
                }
                    if(faculty != null){
                    
                    HttpContext.Session.SetString("FacultyID",faculty.Password);
                    return RedirectToAction("getAllStudent");
                    }
                    else return View();

            }
            }

            [HttpGet]
            public IActionResult Logout(){
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
        

            public async  Task<IActionResult> getAllFaculty(){
                List<TeacherTable> std = new List<TeacherTable>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Faculty/getFacultyData");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<TeacherTable>>(ProductResponse);
                     ViewBag.FacultyName = HttpContext.Session.GetString("FacultyID");

                }
              return View(std);
            }
            }


        [HttpGet]
        public async Task<IActionResult> CreateFaculty()
        {
            List<TeacherTable> std = new List<TeacherTable>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Faculty/getFacultyData");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<TeacherTable>>(ProductResponse);

                }
                var id = std.OrderByDescending(x=> x.Id).FirstOrDefault().Id;
                ViewBag.FacultyID = id+1;
                 return View();

             }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaculty(TeacherTable p)
        {
            //Editing the product http post method
            TeacherTable p1 = new TeacherTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/Faculty/FacultyAddData", content1))
                {
                    System.Console.WriteLine(content1);
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<TeacherTable>(apiResponse);
                    
                    System.Console.WriteLine(p1.Id + p1.Name + p1.Password);
                }
                
            }
            return RedirectToAction("getAllFaculty");
        }

        
        [HttpGet]
        public async Task<IActionResult> EditFaculty(int id)
        {
            
            TeacherTable p1 = new TeacherTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/FacultyEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<TeacherTable>(apiResponse);
                }
            }
              return View(p1);

        }

        [HttpPost]
        public async Task<IActionResult> EditFaculty(TeacherTable p)
        {
            //Editing the product http post method
            TeacherTable p1 = new TeacherTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                int id = p.Id;
                using (var response = await httpClient.PutAsync("https://localhost:5001/api/Faculty/FacultyUpdate/"+id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<TeacherTable>(apiResponse);
                }
            }
            return RedirectToAction("getAllFaculty");
        }

        [HttpGet]
        public async Task<IActionResult> DetailFaculty(int id)
        {
            
            TeacherTable p1 = new TeacherTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/FacultyEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<TeacherTable>(apiResponse);
                }
            }
              return View(p1);

        }

        [HttpGet]
        public async Task<ActionResult> DeleteFaculty(int id)
        {
            TempData["Id"] = id;
            TeacherTable e = new TeacherTable();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/FacultyEdit/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<TeacherTable>(apiResponse);
                }
            }
            return View(e);

        }

        [HttpPost]
        public async Task<ActionResult> DeleteFaculty(StudentTable p)
        {
            //Deleting a product
            int id = Convert.ToInt32(TempData["Id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/Faculty/FacultyDelete/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("getAllFaculty");
        }



// ********************************************************

    
        public async  Task<IActionResult> getAllStudent(){
                List<StudentTable> std = new List<StudentTable>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Faculty/getStudentData");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<StudentTable>>(ProductResponse);
                    ViewBag.FacultyName = HttpContext.Session.GetString("FacultyID");

                }
              return View(std);
            }
            }
        
        [HttpGet]
        public async Task<IActionResult> CreateStudent()
        {
            List<StudentTable> std = new List<StudentTable>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Faculty/getStudentData");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<StudentTable>>(ProductResponse);

                }
                var id = std.OrderByDescending(x=> x.Id).FirstOrDefault().Id;
                ViewBag.StudentID = id+1;
              return View();
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentTable p)
        {
            //Editing the product http post method
            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:5001/api/Faculty/StudentAddData", content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
            return RedirectToAction("getAllStudent");
        }
        
        [HttpGet]
        public async Task<IActionResult> EditStudent(int id)
        {
            
            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
              return View(p1);

        }

        [HttpPost]
        public async Task<IActionResult> EditStudent(StudentTable p)
        {
            //Editing the product http post method
            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");
                int id = p.Id;
                using (var response = await httpClient.PutAsync("https://localhost:5001/api/Faculty/StudentUpdate/"+id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
            return RedirectToAction("getAllStudent");
        }

        
        [HttpGet]
        public async Task<IActionResult> DetailStudent(int id)
        {
            
            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
              return View(p1);

        }

         [HttpGet]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            TempData["Id"] = id;
            StudentTable e = new StudentTable();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
            return View(e);

        }

        [HttpPost]
        public async Task<ActionResult> DeleteStudent(StudentTable p)
        {
            //Deleting a product
            int id = Convert.ToInt32(TempData["Id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:5001/api/Faculty/StudentDelete/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("getAllStudent");
        }

        [HttpGet]
        public async Task<IActionResult> GradeCard(int id){

            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                    ViewBag.FacultyName = HttpContext.Session.GetString("FacultyID");
                }
            }
              return View(p1);
        }

        [HttpPost]
        public async Task<IActionResult> GradeCard(StudentTable obj){

            StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                
                httpClient.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                int id = obj.Id;
                using (var response = await httpClient.PutAsync("https://localhost:5001/api/Faculty/StudentUpdate/"+id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                }
            }
            return RedirectToAction("getGradeCard");
        }

        public async  Task<IActionResult> getGradeCard(){
                List<StudentTable> std = new List<StudentTable>();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.GetAsync("api/Faculty/getStudentData");
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    std = JsonConvert.DeserializeObject<List<StudentTable>>(ProductResponse);
                    ViewBag.FacultyName = HttpContext.Session.GetString("FacultyID");

                }
              return View(std);
            }
            }

                // public FileStreamResult ShowFile(string filename)  {  
                //     string fileURL = @"C:\CsharpProject\gradecardmvc\wwwroot\"+filename; 
                //     FileStream fs = new FileStream(fileURL,FileMode.Open,FileAccess.Read);
                //          var fsresult = new FileStreamResult(fs,"application/pdf");
                //         return fsresult;
                    
                // }

                [HttpGet]
                public IActionResult Check(){
                    return View();
                }

                [HttpPost]
                public IActionResult Check(StudentTable obj){
                    if(obj.Name == "admin"){
                       // ViewBag.result = "admin is here";
                        return RedirectToAction("getAllFaculty");
                    }else{
                        ViewBag.result = "you are not admin";
                        return View();
                    }
                }

                
                 

    }

    }   
