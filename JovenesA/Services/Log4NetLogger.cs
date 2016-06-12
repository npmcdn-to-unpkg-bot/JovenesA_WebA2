using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using System.Diagnostics;

namespace JovenesA.Services
{

  public static class Log4
  {

    private static ILog _log = LogManager.GetLogger("Log4");

    public static void Trace(string message)
    {
      _log.Info(message);
    }

    public static void Trace(Object obj)
    {
      _log.Info(obj);
    }

    //private static ILog _logger = LogManager.GetLogger("Log4");

    //public static void Info(Object obj)
    //{
    //  _logger.Debug(obj);
    //}

    //public static void Trace(string message)
    //{
    //  _logger.Info(message);
    //}

    //public static void Warn(string message)
    //{
    //  _logger.Warn(message);
    //}

    //public static void Debug(string message)
    //{
    //  _logger.Debug(message);
    //}

    //public static void Error(string message)
    //{
    //  _logger.Error(message);
    //}

    //public static void Error(string message, Exception x)
    //{
    //  _logger.Error(message, x);
    //}

    //public static void Fatal(string message)
    //{
    //  _logger.Fatal(message);
    //}

  }
}