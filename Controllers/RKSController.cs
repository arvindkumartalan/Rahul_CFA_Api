using Microsoft.AspNetCore.Mvc;
using Rahul_CFA_Api.DBContext;
using Rahul_CFA_Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rahul_CFA_Api.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class RKSController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RKSController(AppDbContext db)
        {
            _db = db;
        }
        [Route("get/allDetail")]
        [HttpGet]
        public List<Student> Get()
        {
            var res = _db.students.ToList();
            return res;
        }

        // GET api/<RKSController>/5
        [HttpPost]
        [Route("Add/Student")]
        public HttpResponseMessage Get(Student obj)
        {
            if (obj.RollNo==0)
            {
                _db.students.Add(obj);
                _db.SaveChanges();
            }
            else
            {
                _db.students.Update(obj);
                _db.SaveChanges();
            }
            HttpResponseMessage res = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return res;
        }

        
        [HttpGet]
        [Route("Edit/Detail")]
        public Student Edit(int id)
        {
           var editrow= _db.students.Where(s => s.RollNo == id).First();


            //HttpResponseMessage res = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            return editrow;
        }

       

        
        [HttpDelete]
        [Route("del/student")]
        public HttpResponseMessage Delete(int Id)
        {

            var del = _db.students.Where(n => n.RollNo == Id).First();
            _db.students.Remove(del);
            _db.SaveChanges();
            HttpResponseMessage res = new HttpResponseMessage(System.Net.HttpStatusCode.OK);

            return res;
        }
    }
}
