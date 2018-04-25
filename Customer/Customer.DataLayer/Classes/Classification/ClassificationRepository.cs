using Customer.BusinessEntities.Classification;
using Customer.DataLayer.Interface.Classification;
using Dapper;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Customer.DataLayer.Classes.Classification
{
    public class ClassificationRepository : BaseRepository, IClassificationRepository, IDisposable
    {
        public IEnumerable<ClassificationViewModel> GetClassificationList()
        {
            string query = "SELECT Id,ClassificationName FROM Classifications where IsDeleted =0 ";
            using (SqlConnection con = new SqlConnection(base.DBConnectionString))
            {
                return con.Query<ClassificationViewModel>(query);
            }
        }
    }
}
