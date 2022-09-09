using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Core.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; } //MANTÉM?
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

    }
}
