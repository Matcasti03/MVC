using CadastroProdutos.Models;
using Microsoft.AspNetCore.Mvc;
//importa recursos do framework
namespace CadastroProdutos.Controllers;
//        organiza as classes
public class ProdutosController : Controller
//           Nome do Controller Herança da classe Controller
{
    public IActionResult Index()
    //     Tipo de retorno da ação
    //Index() = Método responsável pela página inicial
    {
        var Produtos = new List<Produto>
        {
            new Produto
            {
                Id=1,
                Nome= "Teclado",
                Preco= 129.90m,
                Estoque =15
            },

            new Produto
            {
                Id= 1,
                Nome= "mouse",
                Preco= 59.90m,
                Estoque =15
            },

            new Produto
            {
                Id=1,
                Nome="monitor",
                Preco= 899.90m,
                Estoque =15
            }
        };

        return View(Produtos);
        //Content = Retorna conteúdo textual
    }
};