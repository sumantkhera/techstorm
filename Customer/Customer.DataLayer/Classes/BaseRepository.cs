using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DataLayer.Classes
{
    public class BaseRepository : IDisposable
    {
        public string DBConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
