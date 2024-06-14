using System.ComponentModel.DataAnnotations;

namespace Boacao.ViewModels;

public class RegisterVM
{
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Por favor, informe seu email")]
    [EmailAddress(ErrorMessage = "Por favor, informe um email válido")]
    [StringLength(100, ErrorMessage = "O email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [StringLength(20, ErrorMessage = "A Senha deve possuir no minimo 6 e no máximo 20 caracteres", MinimumLength = 6)]
    public string Senha { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirmar Senha")]
    [Required(ErrorMessage = "Por favor, informe a confirmação")]
    [Compare("Senha", ErrorMessage = "As Senhas não conferem")]
    public string ConfirmarSenha { get; set; }
    
}