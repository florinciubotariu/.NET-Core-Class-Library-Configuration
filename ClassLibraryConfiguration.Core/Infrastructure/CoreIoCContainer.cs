using ClassLibraryConfiguration.Core.Classes;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibraryConfiguration.Core.Infrastructure
{
  public static class CoreIoCContainer
  {
    public static IServiceCollection AddToContainer(this IServiceCollection services)
    {
      services.Configure<ConnectionStringsConfig>(ConfigurationHelper.Configuration.GetSection("ConnectionStrings"));
      services.Configure<SmtpConfig>(ConfigurationHelper.Configuration.GetSection("Smtp"));
      return services;
    }
  }
}
