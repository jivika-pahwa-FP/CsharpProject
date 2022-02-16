using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapi.Models;
using Microsoft.EntityFrameworkCore;

namespace firstapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase{

        [HttpGet]
        [Route("data")]
        public async Task<ActionResult<List<JivikaSbtransaction>>> getAllData(){
            using(var db = new DatabaseTrainingContext()){
                var data = await db.JivikaSbtransactions.ToListAsync();
                return Ok(data);
            }
        }

        [HttpGet]
        [Route("ID/{Id}")]
        public async Task<ActionResult<List<JivikaSbtransaction>>> getbyID(int Id){
            using (var db = new DatabaseTrainingContext()){
                var data = await db.JivikaSbtransactions.FindAsync(Id);
                return Ok(data);
            }
        }


        [HttpPost]
        [Route("AddData")]
        public  async Task<ActionResult> Adddata(JivikaSbtransaction obj){
            using (var db = new DatabaseTrainingContext()){
                var data = await  db.JivikaSbtransactions.AddAsync(obj);
                db.SaveChanges();
                return Ok(data);
            }
        }

        [HttpPut]
        [Route("EditData/{id}")]
        public  async Task<ActionResult> Updatedata(int id,JivikaSbtransaction obj){
            using (var db = new DatabaseTrainingContext()){
                db.JivikaSbtransactions.Update(obj);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteData")]
        public  async Task<ActionResult> Deletedata(int id){
            using (var db = new DatabaseTrainingContext()){
                var data = db.JivikaSbtransactions.Find(id);
                db.JivikaSbtransactions.Remove(data);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

    }
}