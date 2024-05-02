using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Boacao.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Digite a Senha")]
        [StringLength(12, ErrorMessage = "A Senha deve possuir no máximo 12 caracteres")]
        public string? Senha { get; set; }
    }
}