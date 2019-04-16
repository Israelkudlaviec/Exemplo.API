using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo.API.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
