using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTestes.Model
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
