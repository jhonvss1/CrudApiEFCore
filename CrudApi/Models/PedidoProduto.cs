using System.ComponentModel.DataAnnotations;

namespace CrudApi.Models
{
    public class PedidoProduto
    {
        [Key]
        public int PedidoProdutoId { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

    }
}
