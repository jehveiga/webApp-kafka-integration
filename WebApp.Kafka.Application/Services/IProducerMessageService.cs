using WebApp.Kafka.Producer.Application.Dtos.InputModels;

namespace WebApp.Kafka.Producer.Application.Services
{
    public interface IProducerMessageService
    {
        Task<string> SendMessage(PessoaInputModel pessoaInputModel);
    }
}
