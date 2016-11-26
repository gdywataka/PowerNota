using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nota1.Models;
using Nota1.Sessao;

namespace Nota1.Controllers
{
    public class UsuarioController : Controller
    {
        Session sessao = new Session
        {
            usuarioLogado = new Usuario
            {
                login = "adm",
                senha = "adm",
                email = "joseMunirShipS2@hue.hue"
            }
        };

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

        public ActionResult login()
        {
            ViewBag.nomeUsuario = sessao.usuarioLogado.login;
            return View();
        }

        [HttpPost]
        public ActionResult login(FormCollection fc)
        {
            if (fc["login"].Equals("adm") && fc["senha"].Equals("adm"))
            {
                Session["session"] = sessao.usuarioLogado;
                sessao.logado = true;
                return RedirectToAction("Index", "Nota");
            }
            Response.Write("login ou usuario Inválidos");
            return new EmptyResult();
        }
    }
}