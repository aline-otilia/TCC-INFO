using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boacao.Models
{
    [Table("Depoimento")]
    public class Depoimento
    {
         [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira o nome do autor do depoimento.")]
        [StringLength(100, ErrorMessage = "O nome do autor não pode exceder 100 caracteres.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Por favor, insira o conteúdo do depoimento.")]
        public string Conteudo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data do Depoimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataDepoimento { get; set; }

        [Display(Name = "Aprovado")]
        public bool Aprovado { get; set; } = false;
        
    }
}




