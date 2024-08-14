using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApp.Kafka.Core.Entities
{
    public class Pessoa : Entity
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string cpf, DateTime dataNascimento) : base()
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; } = string.Empty;
        public string Cpf { get; private set; } = string.Empty;
        public DateTime DataNascimento { get; private set; }
    }
}
