using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ClassLibraryConfiguration.Core
{
  public static class ConfigurationHelper
  {
    public static readonly IConfigurationRoot Configuration;
    public static readonly string EnvironmentVariable = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

    static ConfigurationHelper()
    {
      Configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{EnvironmentVariable}.json", optional: true, reloadOnChange: true)
        .Build();
    }

    public static string GetConnectionString()
    {
      return Configuration.GetConnectionString("DefaultConnection");
    }
  }
}
