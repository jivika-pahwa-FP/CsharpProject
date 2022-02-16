using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using airflight.Models;
using Microsoft.AspNetCore.Http;

namespace airflight.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DatabaseTrainingContext db;

        public CustomerController(DatabaseTrainingContext _db){
            db = _db;
        }
        public IActionResult Index(){
            return RedirectToAction("Registeration");
        }

        [HttpGet]
        public IActionResult Registeration(){
            return View();
        }

        [HttpPost]
        public IActionResult Registeration(CustomerDetail obj){
            db.CustomerDetails.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public IActionResult Login(CustomerDetail obj){

            CustomerDetail customerID = db.CustomerDetails.Where(x => x.Customerid == obj.Customerid).FirstOrDefault();
            CustomerDetail customerPass = db.CustomerDetails.Where(x => x.Password == obj.Password).FirstOrDefault();
            if(customerID != null && customerPass !=null){
                HttpContext.Session.SetString("customerName",customerID.Customername);
                return RedirectToAction("getallFlight");
            }
            else
            return View();
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Registeration");
        }

        public IActionResult getallFlight(){
            
            ViewBag.customerName = HttpContext.Session.GetString("customerName");
            return View(db.FlightDetails.ToList());
        }

        [HttpGet]
        public IActionResult BookFlight(int id){

            BookingDetail book = new BookingDetail();
            RouteDetail route = db.RouteDetails.Where(x => x.Flightid == id).SingleOrDefault();
            FlightDetail flight = db.FlightDetails.Where( x=> x.Flightid == id).FirstOrDefault();

            book.Bookingid = db.BookingDetails.OrderByDescending(x => x.Bookingid).FirstOrDefault().Bookingid;
            book.Bookingid++;
            book.Flightid = id;
            book.Routeid = route.Routeid;
            book.Doj = DateTime.Now;
            book.Numberofpassengers = 1;
            book.Totalvalue = flight.Costperseat;
            return View(book);
        }

        [HttpPost]
        public IActionResult BookFlight(BookingDetail obj){
            obj.Totalvalue *= obj.Numberofpassengers;
            db.BookingDetails.Add(obj);
            db.SaveChanges();
            return RedirectToAction("BookFlightDetails",new { bookId = obj.Bookingid});
        }

        [HttpGet]
        public IActionResult BookFlightDetails(int bookId){
            ViewBag.customerName = HttpContext.Session.GetString("customerName");
           BookingDetail obj = db.BookingDetails.Find(bookId);
            return View(obj);
        }
    }
}