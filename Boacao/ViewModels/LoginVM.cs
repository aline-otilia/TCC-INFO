using System.ComponentModel.DataAnnotations;


namespace Boacao.ViewModels;

public class LoginVM
{
    [Display(Name = "Email de Acesso")]
    [Required(ErrorMessage = "Informe seu email")]
    [EmailAddress(ErrorMessage = "Informe um email válido")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Informe sua senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}