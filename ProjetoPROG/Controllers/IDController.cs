using ProjetoPROG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPROG.Controllers
{
    public class IDController : Controller
    {
        public List<ID> Cadastros = new List<ID>
        {
            new ID {codigoIdentificacao = 123},
            new ID {codigoIdentificacao = 321}
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(ID);
        }

        public ActionResult Details(int id)
        {
            var ids = ID.SingleOrDefault(c => c.ID == id);

            if (id == null)
            {
                return HttpNotFound();
            }

            return View(ids);
        }
    }
}