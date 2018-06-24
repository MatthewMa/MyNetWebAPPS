﻿using PartyInvite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // There is a validation error
                return View();
            }
            
        }

        // GET Home/LanguageExampleOne
        public String LanguageExampleOne()
        {
            return "Hello,world!";
        }

        // GET Home/AutoProperty
        public ViewResult AutoProperty()
        {
            // create a new Product object
            Product myProduct = new Product();
            // set the property value
            myProduct.Name = "Kayak";
            // get the property
            string productName = myProduct.Name;
            // generate the view
            return View("Result",
            (object)String.Format("Product name: {0}", productName));
        }

        // GET Home/CreateProduct
        public ViewResult CreateProduct()
        {
            // create a new Product object
            Product myProduct = new Product() {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person.",
                Price = 275M,
                Category = "Watersports"
            };
            return View("Result",
            (object)String.Format("Category: {0}", myProduct.Category));
        }

        // GET Home/CreateCollection
        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };
            List<int> intList = new List<int> { 10, 20, 30, 40 };
            Dictionary<string, int> myDict = new Dictionary<string, int> {
                { "apple", 10 }, { "orange", 20 }, { "plum", 30 }
            };
            // create and populate ShoppingCart
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product> {
                    new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccer ball", Price = 19.50M},
                    new Product {Name = "Corner flag", Price = 34.95M}
                }
            };
            decimal cartTotal = cart.TotalPrices();
            return View("Result", (object)string.Format("Total:{0:c}",cartTotal));
        }
    }
}