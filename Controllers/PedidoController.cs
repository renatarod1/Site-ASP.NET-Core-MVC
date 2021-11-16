using Microsoft.AspNetCore.Mvc;
using WS_Lanches.Models;
using WS_Lanches.Repositories;

namespace WS_Lanches.Controllers
{
    public class PedidoController : Controller {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra) {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido) {
            var items = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = items;

            if (_carrinhoCompra.CarrinhoCompraItens.Count == 0) {
                ModelState.AddModelError("", "Seu carrinho está vazio, inclua um lanche...");
            }

            if (ModelState.IsValid) {
                _pedidoRepository.CriarPedido(pedido);

                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :) ";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();//.ToString("C2");

                _carrinhoCompra.LimparCarrinho();
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }

            return View(pedido);
        }
    }
}
