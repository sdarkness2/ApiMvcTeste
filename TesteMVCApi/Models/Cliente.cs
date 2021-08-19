using System.ComponentModel.DataAnnotations;

namespace TesteMVCApi.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
