using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Dependancy_Injection.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Core_Dependancy_Injection.Controllers
{
    public class ClientController : Controller
    {
        // Create Interface Type Objects
        private readonly IA A = null;
        private readonly IB B = null;
        private readonly IC C = null;

        // AddTransient will create object and inject in Constructor
        public ClientController(IA A, IB B, IC C)
        {
            // Assign Created Object to Local Objects
            this.A = A;
            this.B = B;
            this.C = C;

        }

        // This is normal calling in DI with Constructor
        public async Task<IActionResult> Index()
        {
            // Get Methods and Properties of Class without creating their objects
            ViewBag.DataA = await A.GetDataA();
            ViewBag.DataB = await B.GetDataB();
            ViewBag.DataC = await C.GetDataC();

            return View();
        }

        // THis is From Servicess DI, AddTransient inject Object here
        public async Task<IActionResult> CallActionA([FromServices] IA A)
        {
            // Get Methods and Properties of Class without creating their objects
            ViewBag.DataA = await A.GetDataA();
            return View();
        }

        // THis is From Servicess DI, AddTransient inject Object here
        public async Task<IActionResult> CallActionBC([FromServices] IB B, IC C)
        {
            // Get Methods and Properties of Class without creating their objects
            ViewBag.DataB = await B.GetDataB();
            ViewBag.DataC = await C.GetDataC();
            return View();
        }



    }
}