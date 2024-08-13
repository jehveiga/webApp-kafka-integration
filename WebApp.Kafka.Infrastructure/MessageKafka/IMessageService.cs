using Confluent.Kafka;

namespace WebApp.Kafka.Infrastructure.MessageKafka
{
    public interface IMessageService
    {
        Task<string> ProducerAsync<T>(T message);
    }
}
