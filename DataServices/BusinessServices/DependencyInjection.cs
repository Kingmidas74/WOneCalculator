using BusinessServices.PipelineBehaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessServices
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection));
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);    
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            return services;
        }
    }    
}
