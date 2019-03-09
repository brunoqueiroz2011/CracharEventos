using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crachevent.Models
{
    public class Pessoa
    {
        [Required]
        [StringLength(1000000,ErrorMessage ="O {0} deve ter pelo menos {100} caracteres.",MinimumLength =100)]
        [Display(Name ="Participantes")]
        public string Nome { get; set; }
    }

    public class ContactViewModel
    {
        public string name { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string linkedin { get; set; }
        public string github { get; set; }
        public string wordpress { get; set; }

        public ContactViewModel() { }
    }
}