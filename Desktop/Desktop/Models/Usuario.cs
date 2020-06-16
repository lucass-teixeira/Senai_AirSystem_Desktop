using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Models
{
    public class Usuario
    {
        public int codigo { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }
        [DataType(DataType.Date)]
        public DateTime dataNasc { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public string confSenha { get; set; }

        public bool isAdmin { get; set; }





    }
}
