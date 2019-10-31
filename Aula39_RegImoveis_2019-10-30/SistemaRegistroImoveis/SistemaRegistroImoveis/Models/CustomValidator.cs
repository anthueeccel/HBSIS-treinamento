using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaRegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {

        private string fieldName { get; set; }

        public CustomValidator(string field)
        {
            this.fieldName = field;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ProprietarioContext db = new ProprietarioContext();

            if (validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    //throw new Exception("Usuário já existente em nossa base de dados");
                    return new ValidationResult("Usuario já cadastrado");
            }
            if (validationContext.DisplayName == "DtNascimento")
            {
                var valorDataNascimento = DateTime.Parse(value.ToString());
                var dataHoje = DateTime.Now;
                if (valorDataNascimento >= dataHoje.AddYears(-18) || valorDataNascimento <= dataHoje.AddYears(150))
                    return new ValidationResult("Data inválida. Não pode ser menor que 18 ou maior que 150");

                //throw new Exception("Usuário já existente em nossa base de dados");
            }
                       
            return ValidationResult.Success;
        }

    }
}