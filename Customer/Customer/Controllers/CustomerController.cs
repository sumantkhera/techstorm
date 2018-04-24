using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Customer.Controllers
{
    public class CustomerController : ApiController
    {
        //Creating Instance of DatabaseContext class  
        private DatabaseContext db = new DatabaseContext();

        //Creating a method to return Json data   
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                //Prepare data to be returned using Linq as follows  
                var result = from customer in db.Customers
                             select new
                             {
                                 customer.BusinessName,
                                 customer.ClassificationId,
                             };
                return Ok(result);
            }
            catch (Exception ex)
            {
                //If any exception occurs Internal Server Error i.e. Status Code 500 will be returned  
                return InternalServerError();
            }
        }

    }
}