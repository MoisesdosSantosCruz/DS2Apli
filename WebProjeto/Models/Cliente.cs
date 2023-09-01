using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace WebProjeto.Models
{
    public class Cliente
    {
        [Display(Name ="Código")]
        
        public int Codcli { get; set; }


        [Display(Name = "Nome de Usuário")]
        [Required(ErrorMessage = "Por favor, preencha o campo Nome")]
        [StringLength(50, MinimumLength = 3)]

        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage ="Por favor, preencha o campo CPF")]
        [StringLength(50, MinimumLength = 3)]
        [DisplayFormat(DataFormatString = "(xxx-xxx-xxx-yy)")]

        public int CPF { get; set; }

        [Display(Name = "Data de Nacimento")]
        [Required(ErrorMessage = "Por favor, preencha o campo DataNasc")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]

        public DateTime DataNasc { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Por favor, preencha o campo Endereço")]
        [StringLength(50, MinimumLength = 3)]
        
        public string Endereco { get; set; }
        
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Por favor, preencha o campo Telefone")]
        [StringLength(11)]
        [DisplayFormat(DataFormatString = "(xx)xxxxx-xxxx")]
        
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage ="Por favor, preencha o campo Email")]
        [RegularExpression("@\"\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*\" ")]
        
        public string Email {get; set; }

    }
}