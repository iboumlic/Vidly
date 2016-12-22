using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.customerID == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> 
            {
                new Customer{customerID = 1,customerName = "Issam Boumlic", customerEmail ="iboumlic@gmail.com"},
                new Customer{customerID = 2, customerName = "Michelle Ruddy", customerEmail = "mlruddy@gmail.com"}
            };
        }
    }
}