using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boacao.Models
{
    [Table("Doador")]
    public class Doador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Doador")]
        [StringLength(60, ErrorMessage = "O Nome do Doador deve possuir no máximo 60 caracteres")]
        public string? NomePessoa { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
        public string? EmailPessoa { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        [StringLength(20, ErrorMessage = "O Telefone deve possuir no máximo 20 caracteres")]
        public string? FonePessoa { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy  hh:mm}")]    
        public DateTime DataCadastro { get; set; }
    }
}