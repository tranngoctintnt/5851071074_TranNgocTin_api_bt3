using _5851071074_TranNgocTin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5851071074_TranNgocTin.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            //for (int i = 0; i < 10; i++)
            //{
                var StudentInfo = new StudentInfo
                {
                    Name = $"Tran Ngoc Tin",
                    Masv = $"5851071074",
                    Namsinh = 1999,
                    Age = DateTime.Now.Year - 1999
                };
                studentInfoList.Add(StudentInfo);
            //}

            return studentInfoList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {

                Name = $"Tran Ngoc Tin",
                Masv = $"5851071074",
                Namsinh = id,
                Age = DateTime.Now.Year - id

            };
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
