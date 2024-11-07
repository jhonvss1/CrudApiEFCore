using CrudApi.Context;
using CrudApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace CrudApi.Controllers
{
    [Route("produto/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly ClienteContext _produtoContext;

        public ProdutoController(ClienteContext produto)
        {
            _produtoContext = produto;
        }

        [HttpPost("CadastrarProduto")]
        public IActionResult CadastrarProduto(Produto produto, string nome, string marca, string descricao)
        {
            produto.NomeProduto = nome;
            produto.MarcaProduto = marca;
            produto.DescricaoProduto = descricao;

            _produtoContext.Add(produto);
            _produtoContext.SaveChanges();
            return Ok(produto); 
        }

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            var produtoBanco = _produtoContext.Produtos.ToList();
                if (produtoBanco == null)
                return NotFound();

            return Ok(produtoBanco);
        }

    }
}
