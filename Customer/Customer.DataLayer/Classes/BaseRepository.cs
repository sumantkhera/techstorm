using Customer.BusinessEntities.Common;
using Customer.DataLayer.Classes.Enum;
using Database.Context;
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

        protected DatabaseContext _databaseContext;

        #region CONSTRUCTOR
        public BaseRepository()
        {
            _databaseContext = new DatabaseContext();
        }
        #endregion

        public string DBConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            }
        }
        public void Dispose()
        {
            if (_databaseContext != null)
                _databaseContext.Dispose();
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
