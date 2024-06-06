using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Boacao.Models
{
    [Table("Doador")]
    public class Doador
    {
        [Key]
        public string DoadorId { get; set; }
        [ForeignKey("ContaUsuarioId")]
        public IdentityUser ContaUsuario { get; set; }

        [Required(ErrorMessage = "Digite o Nome do Doador")]
        [StringLength(60, ErrorMessage = "O Nome do Doador deve possuir no máximo 60 caracteres")]
        public string NomePessoa { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy  hh:mm}")]    
        public DateTime DataCadastro { get; set; }
    }
}