using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestTest.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
            //write insert logic  

        }
        [HttpGet]
        public string GetEmpDetails()
        {
            return "Vithal Wadje";

        }
        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and Id " + Id;

        }
    }
}
