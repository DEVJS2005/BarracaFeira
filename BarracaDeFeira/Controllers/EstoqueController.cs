using BarracaDeFeira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarracaDeFeira.Controllers
{
    public class EstoqueController : Controller
    {
        BdBarracaDeFeiraEntities bd = new BdBarracaDeFeiraEntities();
        // GET: Estoque
        public ActionResult EstoqueIndex()
        {
            return View(bd.Estoque.ToList());
        }
    }
}