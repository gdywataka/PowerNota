using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nota1.Models;
using Nota1.Sessao;
using sessao = Nota1.Sessao.Session;
using Newtonsoft.Json;
using Nota1.Util;

namespace Nota1.Controllers
{
    public class UsuarioController : Controller
    {

        static List<Usuario> listaUsuarios = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }
        //Metodo de criar 
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    email = collection["email"],
                    login = collection ["login"],
                    senha = collection["senha"]
                };

                string jsonEnvio = JsonConvert.SerializeObject(usuario);

                WebService.uploadJson("/Usuario/criar", jsonEnvio);

            }

            catch (Exception e)
            {
                Response.Write(e.Message);
                return View();
            }

            ViewBag.login = collection["login"];

            return View();
        }
         
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string erro;
            if (sessao.logar(fc["login"],fc["senha"],out erro))
            {
                return RedirectToAction("Index","Nota");
            }

            ViewBag.erro = erro;

            return Login();
        }
    }
}