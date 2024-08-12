using Confluent.Kafka;

namespace WebApp.Kafka.Infrastructure.MessageKafka
{
    public interface IMessageService
    {
        Task<DeliveryResult<string,T>> ProducerAsync<T>(T message);
    }
}
