using Microsoft.Extensions.DependencyInjection;
using WebApp.Kafka.Infrastructure.MessageKafka;

namespace WebApp.Kafka.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
        {
            services.AddMessageServices();


            return services;
        }

        private static IServiceCollection AddMessageServices(this IServiceCollection services)
        {
            services.AddSingleton<IMessageService, MessageService>();

            return services;
        }
    }
}
