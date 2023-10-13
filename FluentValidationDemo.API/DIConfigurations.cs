using MediatR;

namespace FluentValidationDemo.API
{
    public static class DIConfigurations
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DIConfigurations));
        }
    }
}
