using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using lab2.Models;

namespace lab2.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            var now = DateTime.Now;
            string greeting = now.Hour < 12 ? "Good morning!" : "Good evening!";

            ViewBag.Message = greeting;
            ViewBag.Time = now.ToLongTimeString();

            return View();
        }

        public IActionResult ProductInfo()
        {
            var products = new List<Product>
            {
                new Product { Name = "Bread", Price = 25.5 },
                new Product { Name = "Milk", Price = 38.2 },
                new Product { Name = "Cheese", Price = 120.9 },
                new Product { Name = "Bread", Price = 20.9 },
                new Product { Name = "Potato", Price = 10.9 },
                new Product { Name = "Cucumber", Price = 5.0 },
            };
            return View(products);
        }

        public IActionResult SuperMarkets()
        {
            var markets = new List<string> { "ATB", "Silpo", "Furshet", "Metro", "WellMart" };
            ViewBag.SuperMarkets = markets;
            return View();
        }

        public IActionResult ShoppingList()
        {
            var shoppingList = new Dictionary<string, int>
            {
                {"Bread", 2},
                {"Milk", 1},
                {"Cheese", 5},
                {"Potato", 3},
                {"Water", 5},
                {"Cucumber", 2},
                {"Apples", 5},
            };
            return View(shoppingList);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            var markets = new List<string> { "ATB", "Silpo", "Furshet", "Metro", "WellMart" };
            ViewBag.SuperMarkets = markets;
            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string productName, string supermarket, string deliveryDate)
        {
            ViewBag.Result = $"You ordered '{productName}' from {supermarket} with delivery on {deliveryDate}.";
            return View("Result");
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
