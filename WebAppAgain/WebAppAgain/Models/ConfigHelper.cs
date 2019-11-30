using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebAppAgain.Models
{
    public static class ConfigHelper
    {
        public static string GetAppName()
        {
            return ConfigurationManager.AppSettings["ApplicationName"] ?? "ERROR";


        }

    }
}