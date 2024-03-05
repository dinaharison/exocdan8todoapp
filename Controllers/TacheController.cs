using exocdan8todoapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace exocdan8todoapp.Controllers
{
    public class TacheController : Controller
    {
        public ActionResult ListeTache()
        {
            
            return View(DBConnection.retrouverTaches("dinah"));
        }

        public ActionResult Modifier(int id)
        {
            return Content($"<h4> Ressource numéro : {id} </h4>");
        }
    }
}