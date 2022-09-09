﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Models.Usuario.ListarUsuarioPorId
{
    public class ListarUsuarioPorIdResponse
    {
        public int Id { get; set; } 
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
