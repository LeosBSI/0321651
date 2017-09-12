using ProjetoPROG.Models;
using ProjetoPROG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPROG.Controllers
{
    public class CadastroController : Controller
    {
        public List<Cadastro> Cadastros = new List<Cadastro>
        {
            new Cadastro {Nome = "Leonardo ", ID = 1},
            new Cadastro {Nome = "Carlos", ID = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(Cadastros);
        }

        public ActionResult Details(int id)
        {
            var cadastro = Cadastros.SingleOrDefault(c => c.ID == id);

            if (cadastro == null)
            {
                return HttpNotFound();
            }

            return View(cadastro);
        }
	}
}