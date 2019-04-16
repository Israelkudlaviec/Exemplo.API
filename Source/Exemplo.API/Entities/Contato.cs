using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo.API.Entities
{
    public class Contato
    {
        public Contato()
        {

        }

        public int ContatoID { get; set; }
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}
