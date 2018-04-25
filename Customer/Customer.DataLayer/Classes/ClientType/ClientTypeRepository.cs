using Customer.DataLayer.Interface.ClientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.ClientType;
using Database.Context;

namespace Customer.DataLayer.Classes.ClientType
{
    public class ClientTypeRepository : IClientTypeRepository
    {
        public IEnumerable<ClientTypeViewModel> GetClientTypeList()
        {
            using (var databaseContext = new DatabaseContext())
            {
                var result = from clientTypes in databaseContext.ClientTypes
                             select (new ClientTypeViewModel
                             {
                                 Id = clientTypes.Id,
                                 ClientTypeName = clientTypes.ClientTypeName,
                             });
                return result.ToList();
            }
        }
    }
}
