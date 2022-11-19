using BarracaDeFeira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarracaDeFeira.Controllers
{
    public class PedidoController : Controller
    {
        BdBarracaDeFeiraEntities bd = new BdBarracaDeFeiraEntities();
        // GET: Pedido
        int cont = 0;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addProduto(int id)
        {
            bool objProduto = false;

            Pedido pedido = Session["carrinho"] != null ? (Pedido)Session["carrinho"] : new Pedido();

            Produto produto = bd.Produto.Find(id);

            if (produto != null)
            {
                PedidoProduto pedProd = new PedidoProduto();
                pedProd.Produto = produto;
                pedProd.quanidadeItem = 1;

                foreach (var obj in pedido.PedidoProduto)
                {
                    if (obj.Produto.idProduto == produto.idProduto)
                    {
                        obj.quanidadeItem += 1;
                        objProduto = true;
                        break;
                    }
                    
                }

                if (objProduto == false)
                {
                    pedido.PedidoProduto.Add(pedProd);
                }

              

                Session["carrinho"] = pedido;
                
            }

            return RedirectToAction("Carrinho");
        }

        public ActionResult Carrinho()
        {
            Pedido pedido = Session["carrinho"] != null ? (Pedido)Session["carrinho"] : new Pedido();
            return View(pedido);
        }
    }
}