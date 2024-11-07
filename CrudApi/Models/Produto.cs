using Microsoft.EntityFrameworkCore;    
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace CrudApi.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string? NomeProduto { get; set; }
        public string? MarcaProduto { get; set;  }
        public string? DescricaoProduto { get; set; }
        // Relacionamento muitos-para-muitos com Pedido através de uma tabela de junção
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto>(); 
    }
}
