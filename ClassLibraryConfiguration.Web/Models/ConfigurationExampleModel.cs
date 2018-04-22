using ClassLibraryConfiguration.Core.Classes;

namespace ClassLibraryConfiguration.Web.Models
{
  public class ConfigurationExampleModel
  {
    public ConnectionStringsConfig ConnectionStringsConfig { get; set; }
    public SmtpConfig SmtpConfig { get; set; }
  }
}
