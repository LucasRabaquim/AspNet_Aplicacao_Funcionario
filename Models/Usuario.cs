using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteWeb.Models
{
    public class Usuario
    {
        [Display(Name = "Nome do usuário")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [RegularExpression(@"[a-zA-Z]+", ErrorMessage = "Somente letras")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Idade do usuário")]
        [Range(18, 70, ErrorMessage = "Idade permitida entre 18 e 70 anos")]
        public string Idade { get; set; }

        [Display(Name = "CPF do usuário")]
        [RegularExpression(@"([0-9]{3}\.){2}([0-9]{3}-)[0-9]{2}", ErrorMessage = "CPF inválido!!!")]
        public string cpf { get; set; }

        [Display(Name = "Email do usuário")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Display(Name = "Crie seu login")]
        [RegularExpression(@"[a-zA-Z0-9]{5,15}", ErrorMessage = "Somente letras e números de 5 a 15 caracteres")]
        public string Login { get; set; }

        [Display(Name = "Crie sua senha")]
        [Required(ErrorMessage = "Senha obrigatório")]
        [RegularExpression(@"[a-zA-Z0-9]{5,}", ErrorMessage = "No mínimo 5 caracteres")]

        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string ConfSenha { get; set; }
    }
}