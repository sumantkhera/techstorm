using Customer.BusinessEntities.Common;
using Customer.DataLayer.Classes.Enum;
using Database.Context;
using System;
using System.Configuration;

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

        #region Properties
        public string DBConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            }
        }

        #endregion

        #region Common Method
        /// <summary>
        /// Create sucess status.
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Object of status and message.</returns>
        protected AddUpdateResultViewModel CreateSuccessStatus(int id)
        {
            AddUpdateResultViewModel addUpdateResultViewModel = new AddUpdateResultViewModel();
            addUpdateResultViewModel.Id = id.ToString();
            return addUpdateResultViewModel;
        }

        /// <summary>
        /// Create failure status
        /// </summary>
        /// <returns>Object of status and message.</returns>
        protected AddUpdateResultViewModel CreateFailureNotFoundStatus()
        {
            AddUpdateResultViewModel addUpdateResultViewModel = new AddUpdateResultViewModel();
            addUpdateResultViewModel.Message = ReponseStatus.RecordNotFound.ToString();
            return addUpdateResultViewModel;
        }
        
        #endregion


        public void Dispose()
        {
            if (_databaseContext != null)
                _databaseContext.Dispose();
        }
    }
}
