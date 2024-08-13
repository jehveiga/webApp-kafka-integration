using WebApp.Kafka.Infrastructure.MessageKafka;
using WebApp.Kafka.Producer.Application.Dtos.InputModels;

namespace WebApp.Kafka.Producer.Application.Services
{
    public class ProducerMessageService : IProducerMessageService
    {
        private readonly IMessageService _messageService;

        public ProducerMessageService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<string> SendMessage(PessoaInputModel pessoaInputModel)
        {
            var pessoa = pessoaInputModel.ToEntity();

            var result = await _messageService.ProducerAsync(pessoa);

            return result;
        }
    }
}
