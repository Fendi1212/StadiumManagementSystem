using System;
using System.Web.Mvc;

namespace MangementSystemStudium.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/Checkout
        public ActionResult Checkout(string selectedMatch, string selectedVenue, string selectedCategory)
        {
            // Pack selected widgets into ViewBag components to display them on the confirmation screen
            ViewBag.Match = selectedMatch ?? "🏆 World Cup Final — Match 64";
            ViewBag.Venue = selectedVenue ?? "Stadium Alpha (Main Pitch)";
            ViewBag.Category = selectedCategory ?? "⭐ Category 1 (Prime Pitchside)";

            return View();
        }
    }
}