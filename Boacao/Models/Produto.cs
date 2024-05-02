using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Boacao.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Produto")]
        [StringLength(60, ErrorMessage = "O Nome do Produto deve possuir no máximo 60 caracteres")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "Digite a Descrição")]
        [StringLength(100, ErrorMessage = "A Descrição deve possuir no máximo 500 caracteres")]
        public string? Descricao { get; set; }

        public string? CategoriId { get; set; }

        [StringLength(200)]
        public string? Foto { get; set; }

        public bool Ativo { get; set; } = true;


    }
}