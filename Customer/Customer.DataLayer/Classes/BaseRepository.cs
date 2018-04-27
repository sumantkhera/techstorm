using Customer.BusinessEntities.Common;
using Customer.DataLayer.Classes.Enum;
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

        protected AddUpdateResultViewModel CreateSuccessStatus(int id)
        {
            AddUpdateResultViewModel addUpdateResultViewModel = new AddUpdateResultViewModel();
            addUpdateResultViewModel.Id = id.ToString();
            return addUpdateResultViewModel;
        }


        protected AddUpdateResultViewModel CreateFailureNotFoundStatus()
        {
            AddUpdateResultViewModel addUpdateResultViewModel = new AddUpdateResultViewModel();
            addUpdateResultViewModel.Message = ReponseStatus.RecordNotFound.ToString();
            return addUpdateResultViewModel;
        }
    }
}
