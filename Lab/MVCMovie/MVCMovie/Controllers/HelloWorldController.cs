using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public string Index()
        {

            return "this is my default action form HelloWorld...";
            //return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
/*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        */
       // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
