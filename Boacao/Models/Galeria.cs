using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boacao.Models
{
    [Table("GaleriaFotos")]
    public class Galeria
    {
         [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, insira um título para a foto.")]
        [StringLength(100, ErrorMessage = "O título não pode exceder 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Por favor, insira a descrição da foto.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Por favor, insira o caminho da imagem.")]
        [Display(Name = "Caminho da Imagem")]
        public string Imagem { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Upload")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataUpload { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; } = true;
        
    }
}


