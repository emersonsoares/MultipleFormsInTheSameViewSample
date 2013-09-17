using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultipleFormsInTheSameViewSample.ViewModels
{
    public class RegisterOrLoginViewModel
    {
        #region Properties for Login

        [Required(ErrorMessage = "Digite um email")]
        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}", ErrorMessage = "Email inválido")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Digite uma senha")]
        [MinLength(5, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        [MaxLength(20, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        public string LoginPassword { get; set; }

        #endregion

        #region Properties for Register

        [Required(ErrorMessage = "Digite um email")]
        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}", ErrorMessage = "Email inválido")]
        public string RegisterEmail { get; set; }

        [Required(ErrorMessage = "Digite uma senha")]
        [MinLength(5, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        [MaxLength(20, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        public string RegisterPassword { get; set; }

        [Required(ErrorMessage = "Digite o primeiro nome")]
        public string RegisterFirstName { get; set; }

        [Required(ErrorMessage = "Digite o segundo nome")]
        public string RegisterLastName { get; set; }

        #endregion
    }
}