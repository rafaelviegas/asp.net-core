using casa_do_codigo.Models;
using casa_do_codigo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace casa_do_codigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataServices _dataServices;
        public PedidoController(IDataServices dataServices)
        {
            this._dataServices = dataServices;
        }

        public IActionResult Carrossel()
        {

            return View(_dataServices.GetProdutos());
        }



        public IActionResult Carrinho()
        {
            return View(GetCarrinhoViewModel());
        }

        private CarrinhoViewModels GetCarrinhoViewModel()
        {
            var produtos = _dataServices.GetProdutos();

            var itensDeCarrinho = _dataServices.GetItensPedido();

            return new CarrinhoViewModels(itensDeCarrinho);
        }

        public IActionResult Resumo()
        {

            return View(GetCarrinhoViewModel());
        }
    }
}
