using Microsoft.AspNetCore.Mvc;
using System;
using TurniejMaxow.Models;
using System.Linq;

namespace TurniejMaxow.Controllers
{
    public class HomeController : Controller
    {
        private IResponsesRepository repository;
        public HomeController(IResponsesRepository repo) => repository = repo;
        public ViewResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public ViewResult SignForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SignForm(FormResponse guestResponse)
        {
            if (ModelState.IsValid) {
                guestResponse.Signed = DateTime.Today;
                repository.Add(guestResponse);
                return View("Thanks", guestResponse);
            } else {
                //validation problem
                return View();
            }
        }

        public ViewResult ListParticipants()
        {
           return View(
               repository.Responses.Select(s=>s));
        }
    }
}
