using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestProject.Utils
{
    public static class Variable
    {
        static readonly IDictionary<string, string> _variables;

        public static string GetValue(string key)
        {
            //TODO get value from variables.json
            switch (key.ToLower())
            {
                case "p_vsmc_url":
                    return "https://int-ssweb.visioninternet.com/";
                case "p_sysadmin_email":
                    return "sysadmin@visioninternet.com";
                case "p_sysadmin_password":
                    return "Vision@123";
                default:
                    break;
            }
            return key;
        }

    }
}
