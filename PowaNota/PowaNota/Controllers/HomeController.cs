using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sessao = Nota1.Sessao.Session;

namespace Nota1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (sessao.logado)
            {
                return RedirectToAction("Index", "Nota");
            }
            return View();
        }

        public ActionResult logout()
        {
            sessao.logado = false;
            return Index();
        }

    }
}