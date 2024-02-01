using _01MvcLayoutsViewBagandTempDataMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace _01MvcLayoutsViewBagandTempDataMastery.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        static List<Customer> Customers = new List<Customer>()
        {
            new Customer{Id=102,Name="Vasu",Mobile=9000734808,OrderDate=DateTime.Now},
            new Customer{Id=102,Name="Venu",Mobile=6304963414,OrderDate=DateTime.Now}
        };
        public ActionResult Index()
        {
            ViewBag.text = "Welcome Cusomers";
            return View(Customers);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["Msg"] = "Customer Registration";
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult Create(Customer Cust)
        {
            if (ModelState.IsValid)
            {
                Customers.Add(Cust);
                TempData["tempmsg"] = "New Customer Registraion Success";
                return RedirectToAction("Index");
            }
            else
            {
                return View(Cust);
            }
        }
        public ActionResult NameList()
        {
            List<string> list = new List<string>()
            {
                "ToothPaste",
                "Fruits",
                "biscuits"
            };
            
            ViewBag.nameList = list;
            return View();

        }

    }
}