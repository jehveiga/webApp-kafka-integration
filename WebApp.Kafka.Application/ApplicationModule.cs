using Microsoft.Extensions.DependencyInjection;
using WebApp.Kafka.Producer.Application.Services;

namespace WebApp.Kafka.Producer.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddProducerMessage();

            return services;
        }

        private static IServiceCollection AddProducerMessage(this IServiceCollection services) 
        {
            services.AddScoped<IProducerMessageService, ProducerMessageService>();

            return services;
        }
    }
}
