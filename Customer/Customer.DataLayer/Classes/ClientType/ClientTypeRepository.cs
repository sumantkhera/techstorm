using Customer.DataLayer.Interface.ClientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.ClientType;
using Database.Context;
using System.Data.SqlClient;
using Dapper;

namespace Customer.DataLayer.Classes.ClientType
{
    public class ClientTypeRepository : BaseRepository, IClientTypeRepository
    {
        public IEnumerable<ClientTypeViewModel> GetClientTypeList()
        {
            string query = "SELECT Id,ClientTypeName FROM ClientTypes where IsDeleted =0 ";
            using (SqlConnection con = new SqlConnection(base.DBConnectionString))
            {
                return con.Query<ClientTypeViewModel>(query);
            }
        }
    }
}
