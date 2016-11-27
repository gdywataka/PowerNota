using Nota1.Sessao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PowaNota.Filtro
{
    public class AuthFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!Session.logado)
            {
                filterContext.Controller.ViewBag.IsLogado = "1";
            }
            else
            {
                filterContext.Controller.ViewBag.IsLogado = "0";
            }
        }

    }
}
