using System.Diagnostics;
using ClassLibraryConfiguration.Core.Classes;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryConfiguration.Web.Models;
using Microsoft.Extensions.Options;

namespace ClassLibraryConfiguration.Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly ConnectionStringsConfig connectionStringsConfig;
    private readonly SmtpConfig smtpConfig;

    public HomeController(IOptions<ConnectionStringsConfig> connectionStringsConfig, IOptions<SmtpConfig> smtpConfig)
    {
      this.connectionStringsConfig = connectionStringsConfig.Value;
      this.smtpConfig = smtpConfig.Value;
    }
    public IActionResult Index()
    {
      return View(new ConfigurationExampleModel
      {
        ConnectionStringsConfig = connectionStringsConfig,
        SmtpConfig = smtpConfig
      });
    }

    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
