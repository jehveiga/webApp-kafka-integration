
using Confluent.Kafka;
using WebApp.Kafka.Infrastructure.MessageKafka.Config;
using WebApp.Kafka.Infrastructure.MessageKafka.Serializador;

namespace WebApp.Kafka.Infrastructure.MessageKafka
{
    public class MessageService : IMessageService
    {
        private readonly string _bootstrapserver;

        public MessageService()
        {
            _bootstrapserver = ParametersConfig.BOOTSTRAP_SERVER;
        }

        public async Task<string> ProducerAsync<T>(T message)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = _bootstrapserver,

                // Habilitar idempotência
                EnableIdempotence = true,
                Acks = Acks.All,
                MaxInFlight = 1,
                MessageSendMaxRetries = 2,

                TransactionalId = Guid.NewGuid().ToString()
            };


            // Instância
            using var producer = new ProducerBuilder<string, T>(config)
                                    .SetValueSerializer(new SerializerProducer<T>())
                                    .Build();

            var topico = ParametersConfig.TOPIC_NAME;


            var result = await producer.ProduceAsync(topic: topico, message: new ()
            {
                Key = Guid.NewGuid().ToString(),
                Value = message

            });


            return result.Status.ToString();
        }
    }
}
