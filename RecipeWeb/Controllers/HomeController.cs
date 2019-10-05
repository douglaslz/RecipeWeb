using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/RecipeList
        public ActionResult RecipeList()
        {
            return View();
        }

        // GET: Home/AddRecipe
        public ActionResult AddRecipe()
        {
            return View();
        }


        // GET: Home/ViewRecipe
        public ActionResult ViewRecipe()
        {
            return View();
        }

        // GET: Home/ReViewRecipe
        public ActionResult ReViewRecipe()
        {
            return View();
        }

    }
}