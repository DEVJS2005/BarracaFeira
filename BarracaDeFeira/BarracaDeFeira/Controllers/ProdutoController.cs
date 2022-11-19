using BarracaDeFeira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarracaDeFeira.Controllers
{
    public class ProdutoController : Controller
    {
        BdBarracaDeFeiraEntities bd = new BdBarracaDeFeiraEntities();
        // GET: Produto
        public ActionResult Index()
        {
            return RedirectToAction("EstoqueIndex", "Estoque");
        }

        public ActionResult ListaProduto()
        {
            return View(bd.Produto.ToList());
        }

        [HttpGet]
        public ActionResult CadastroProduto()
        {
            return View(bd.Produto.ToList());
        }

        [HttpPost]
        public ActionResult CadastroProduto(string descricaoProduto, decimal valorUnitario)
        {
            Produto prod = new Produto();
            prod.descricaoProduto = descricaoProduto;
            prod.valorUnitario = valorUnitario;

            bd.Produto.Add(prod);
            bd.SaveChanges();

            return RedirectToAction("EstoqueIndex", "Estoque");
        }

        [HttpGet]
        public ActionResult EditarProduto(int id)
        {
            Produto prod = bd.Produto.ToList().Find(x => x.idProduto == id);

            return View(prod);
          
            
        }

        [HttpPost]
        public ActionResult EditarProduto(int id, string descricaoProduto, decimal valorUnitario)
        {
            Produto prod = bd.Produto.ToList().Find(x => x.idProduto == id);
            prod.descricaoProduto = descricaoProduto;
            prod.valorUnitario = valorUnitario;

            bd.SaveChanges();

            return RedirectToAction("CadastroProduto", "Produto");
        }

        [HttpGet]
        public ActionResult EntradaProduto(int id)
        {
            Produto prod = bd.Produto.ToList().Find(x => x.idProduto == id);

            return View(prod);

        }

        [HttpPost]
        public ActionResult EntradaProduto(int id, int quantidadeItem)
        {
            Produto prod = bd.Produto.ToList().Find(x => x.idProduto == id);

            Entrada entrada = new Entrada();
            entrada.idProduto = prod.idProduto;
            entrada.dataEntrada = DateTime.Now;
            entrada.quantidadeEntrada = quantidadeItem;

            bd.Entrada.Add(entrada);
            bd.SaveChanges();

            return RedirectToAction("EstoqueIndex", "Estoque");

        }
    }
}