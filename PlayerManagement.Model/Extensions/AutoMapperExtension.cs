using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PlayerManagement.Model.Extensions
{
    public static class AutoMapperExtension
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
