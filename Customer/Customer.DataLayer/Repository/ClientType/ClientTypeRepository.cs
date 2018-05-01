using Customer.DataLayer.IRepository.ClientType;
using Customer.ViewModel.ClientType;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Customer.DataLayer.Repository.ClientType
{
    /// <summary>
    /// /This class containt the method related to client type.
    /// </summary>
    public class ClientTypeRepository : BaseRepository, IClientTypeRepository
    {
        #region Public method.
        /// <summary>
        /// Get list of client type.
        /// </summary>
        /// <returns>List of clientTypeViewmodel</returns>
        public IEnumerable<ClientTypeViewModel> GetClientTypeList()
        {
            string query = "SELECT Id,ClientTypeName FROM ClientTypes where IsDeleted =0 ";
            using (SqlConnection con = new SqlConnection(base.DBConnectionString))
            {
                return con.Query<ClientTypeViewModel>(query);
            }
        }

        #endregion
    }
}
