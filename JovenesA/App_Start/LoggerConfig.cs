using System.Web;
using System.Web.Mvc;
using log4net;

namespace JovenesA
{


  public class LoggerConfig
  {

    public ILog Log4 = null;

    public static ILog RegisterLogger()
    {
        return LogManager.GetLogger(typeof(LoggerConfig));
    }
  }
}
