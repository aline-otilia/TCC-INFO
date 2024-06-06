using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boacao.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite a Categoria")]
        [StringLength(30, ErrorMessage = "A Categoria deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }
    }
}