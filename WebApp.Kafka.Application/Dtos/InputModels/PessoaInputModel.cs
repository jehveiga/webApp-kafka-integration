using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApp.Kafka.Core.Entities;

namespace WebApp.Kafka.Producer.Application.Dtos.InputModels
{
    public class PessoaInputModel
    {
        [JsonConstructor]
        public PessoaInputModel(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public Pessoa ToEntity()
        {
            return new Pessoa(Nome, Cpf, DataNascimento);

        }

    }


}
