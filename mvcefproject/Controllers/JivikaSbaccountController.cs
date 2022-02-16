using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcefproject.Models;

namespace mvcefproject.Controllers
{
    public class JivikaSbaccountController : Controller
    {
        
       private readonly DatabaseTrainingContext db;
        JivikaSbaccount sb_account_table = new JivikaSbaccount();

        public JivikaSbaccountController(DatabaseTrainingContext _db){
            db = _db;
        }

        public IActionResult getallAcc()
        {
            
            return View(db.JivikaSbaccounts.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(JivikaSbaccount obj)
        {
            db.JivikaSbaccounts.Add(obj);
            db.SaveChanges();
            return RedirectToAction("getallAcc");
        }

        public IActionResult Details(int AccountNo)
        {
            JivikaSbaccount obj = db.JivikaSbaccounts.Where( x => x.AccountNo == AccountNo).SingleOrDefault();
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int AccountNo)
        {
            JivikaSbaccount obj = db.JivikaSbaccounts.Where( x => x.AccountNo == AccountNo).SingleOrDefault();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(JivikaSbaccount account)
        {
            db.JivikaSbaccounts.Update(account);
            db.SaveChanges();
            return RedirectToAction("getallAcc");
        }

        [HttpGet]
        public IActionResult Delete(int AccountNo)
        {
            JivikaSbaccount obj = db.JivikaSbaccounts.Where( x => x.AccountNo == AccountNo).SingleOrDefault();
           db.JivikaSbaccounts.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("getallAcc");
            //return View(obj);
        }
        [HttpPost]
    [ActionName("Delete/{AccountNo}")]
        public IActionResult DeleteConfirmed(int AccountNo)
        {
             
             JivikaSbaccount obj = db.JivikaSbaccounts.Where( x => x.AccountNo == AccountNo).SingleOrDefault();
            if(obj != null){
            db.JivikaSbaccounts.Remove(obj);
            db.SaveChanges();
            }
            return RedirectToAction("getallAcc");
        }
    
    }
}