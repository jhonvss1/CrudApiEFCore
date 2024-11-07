using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace CrudApi.Models
{
    public class Pedido()
    {
    

        [Key]
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }  
        public int IdCliente { get; set; } 
        public Cliente Cliente { get; set; }

        //Relacionamento muitos-para-muitos com Produto através de uma tabela de junção
        public ICollection<PedidoProduto> PedidoProdutos { get; set; } = new List<PedidoProduto> ();
       
    }
}
