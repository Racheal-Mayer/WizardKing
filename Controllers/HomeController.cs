using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public static Pet petone = new Pet("Kenny");        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(petone);
        }

        [HttpGet("Feed")]
        public IActionResult Feed()
        {
            petone.Eat();
            if (petone.Lose()== true)
            {
                return View("YouLose", petone);
            }
            if(petone.Win() == true)
            {
                return View("YouWin", petone);
            }
            else
            return View("Index", petone);
            }
        
        [HttpGet("Play")]
        public IActionResult Play()
        {
            petone.Play();
            if (petone.Lose()== true)
            {
                return View("YouLose", petone);
            }
            if(petone.Win() == true)
            {
                return View("YouWin", petone);
            }
            else
            return View("Index", petone);
            }
                    
            [HttpGet("Work")]
            public IActionResult Work()
            {
            petone.Work();
            if (petone.Lose()== true)
            {
                return View("YouLose", petone);
            }
            if(petone.Win() == true)
            {
                return View("YouWin", petone);
            }
            else
            return View("Index", petone);
            }
            [HttpGet("Sleep")]
            public IActionResult Sleep()
            {
            petone.Sleep();
            if (petone.Lose()== true)
            {
                return View("YouLose", petone);
            }
            if(petone.Win() == true)
            {
                return View("YouWin", petone);
            }
            else
            return View("Index", petone);
            }

            [HttpGet("youwin")]
            public IActionResult YouWin()
            {
                return View("YouWin", petone);
            }
            
            [HttpGet("youlose")]
            public IActionResult YouLose()
            {
                return View("YouLose", petone);
            }

            [HttpGet("reset")]
            public IActionResult Reset()
            {
            petone = new Pet("Kenny");
                return Redirect("/");
            }
        }
    }

