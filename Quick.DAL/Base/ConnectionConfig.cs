using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Quick.DAL.Base
{
    public class ConnectionConfig
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
        }
    }
}
