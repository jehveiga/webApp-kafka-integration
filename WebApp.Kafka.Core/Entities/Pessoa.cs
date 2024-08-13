using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Kafka.Core.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa(string nome, string cpf, DateTime dataNascimento) : base()
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}
