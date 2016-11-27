using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nota1.Models;
using Nota1.Sessao;
using sessao =  Nota1.Sessao.Session;

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

        //Metodo de criar 
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    id= Convert.ToInt32(collection["id"]),
                    email = collection["Data"],
                    login= collection["Dioghx"],
                    senha = collection["Titulo"]
                };

                listaUsuarios.Add(usuario);
                return View();

            }

            catch (Exception e)
            {
                Response.Write(e.Message);
            }
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.nomeUsuario = "";
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