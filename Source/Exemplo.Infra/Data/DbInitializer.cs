using Exemplo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo.Infra.Data
{
    public static class DbInitializer
    {

        public static void Initialize(ContextDb context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Israel",
                    Cpf="11111111111",
                },
                new Cliente
                {
                    Nome = "Teste Cliente 2",
                    Cpf="22222222222"
                }
            };
            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    NomeContato = "Israel COntato 1",
                    Telefone="4136363636",
                    Email="teste@teste.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    NomeContato = "Israel COntato 2",
                    Telefone="4136363636",
                    Email="teste2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();

        }

    }
}
