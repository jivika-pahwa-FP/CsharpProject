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
using Microsoft.AspNetCore.Hosting;

namespace gradecardmvc.Controllers
{
    public class StudentController : Controller
    {       
        
        string Baseurl = "https://localhost:5001/";
        private readonly IWebHostEnvironment webHostEnvironment;
        //public StudentController(){}
        public StudentController(IWebHostEnvironment _webHostEnvironment){
             webHostEnvironment = _webHostEnvironment;
        }

            [HttpGet]
            public IActionResult Login(){
                return View();
            }
            
            [HttpPost]
            public async Task<IActionResult> Login(StudentTable obj){
                StudentTable student = new StudentTable();

            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Clear();
                System.Console.WriteLine("within block");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 HttpResponseMessage Res = await client.PostAsync("api/Student/CheckLogin",content1);
                 System.Console.WriteLine("Api Checked "+Res.StatusCode);
                      
                if (Res.IsSuccessStatusCode)
                {
                    var ProductResponse = Res.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<StudentTable>(ProductResponse);
                    //System.Console.WriteLine(student.Id + student.Name + student.Password);
                    
                }
                    if(student != null){
                    HttpContext.Session.SetString("StudentID",student.Id.ToString());
                    HttpContext.Session.SetString("id",student.Id.ToString());
                    ViewBag.StudentName = HttpContext.Session.GetString("StudentID");
                    System.Console.WriteLine(ViewBag.StudentName);
                    return RedirectToAction("getStudentDashboard",new {id=student.Id});
                    }
                    else return View();

            }
            }

            
            [HttpGet]
            public IActionResult Logout(){
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }

            public async  Task<IActionResult> getStudentDashboard(int id){
                StudentTable std = new StudentTable();

                using(var httpClient = new HttpClient())
                {
                    using(var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id)){
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        std = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                    }
                }
                    ViewBag.StudentName = HttpContext.Session.GetString("StudentID");
                    ViewBag.id = HttpContext.Session.GetString("id");
                     return View(std);
            }

            public async  Task<IActionResult> GradeCard(int id){
             StudentTable p1 = new StudentTable();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                    
                    ViewBag.StudentName = HttpContext.Session.GetString("StudentID");
                }
            }
              return View(p1);
            }

            [HttpGet]
            public async  Task<IActionResult> SubmitAssignment(int id){
             Student p1 = new Student();
            // Product p2 = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/api/Faculty/StudentEdit/"+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    p1 = JsonConvert.DeserializeObject<Student>(apiResponse); 
                    ViewBag.id = HttpContext.Session.GetString("id");
                }
            }
              return View(p1);
            }

            [HttpPost]
            public async  Task<IActionResult> SubmitAssignment(Student obj){
                string filename = null;
                if(obj.FileUpload != null){
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath,"image");
                    filename = obj.FileUpload.FileName;
                    string filepath = Path.Combine(uploadFolder,filename);
                    System.Console.WriteLine(filepath);
                    var filestream = new FileStream(filepath,FileMode.Create);
                    obj.FileUpload.CopyTo(filestream);
                }
                    
                     StudentTable std = new StudentTable();
                     std.Id = obj.Id;
                     std.Name = obj.Name;
                     std.FileUpload = "/image/"+filename;
                    System.Console.WriteLine(std.FileUpload);

                    // StudentTable temp = new StudentTable();
                    
            using (var httpClient = new HttpClient())
            {       
                httpClient.BaseAddress = new Uri(Baseurl);

                 StringContent content1 = new StringContent(JsonConvert.SerializeObject(std), Encoding.UTF8, "application/json");
                 int id = obj.Id;
                 System.Console.WriteLine("content"+content1);
                var response = await httpClient.PutAsync("https://localhost:5001/api/Student/Update/"+id,content1);
                System.Console.WriteLine("code : "+response.StatusCode);
               
                // using (var response = await httpClient.PutAsync("https://localhost:5001/api/Student/Update/"+id,content1))
                // {   
                // System.Console.WriteLine("response !! fileew");
                // System.Console.WriteLine(response.StatusCode);
                //     string apiResponse = await response.Content.ReadAsStringAsync();
                //     //ViewBag.status = "Assignment Submitted Successfully !!";
                //     JsonConvert.DeserializeObject<StudentTable>(apiResponse);
                //     //System.Console.WriteLine("File Name "+std.FileUpload);
                    
                //     System.Console.WriteLine(obj.Id + obj.Name + obj.FileUpload);
                //     System.Console.WriteLine(std.Id + std.Name + std.FileUpload);
                // }
            }


              return View();
            }

            

        
    }
}