
using System.ComponentModel.DataAnnotations;

namespace CrudApi.Models
{
    public class Cliente
    {
      

        //Declarando as tabelas no BD 
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? CPF {  get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Telefone { get; set; }

        // Relacionamento um-para-muitos com Pedido
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>(); 

    }
}
