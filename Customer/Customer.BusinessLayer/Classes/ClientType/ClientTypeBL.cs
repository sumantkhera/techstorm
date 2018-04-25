using Customer.BusinessLayer.Interface.ClientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.ClientType;
using Customer.DataLayer.Interface.ClientType;

namespace Customer.BusinessLayer.Classes.ClientType
{
    public class ClientTypeBL : IClientTypeBL
    {
        private IClientTypeRepository _clientTypeService;
        public ClientTypeBL(IClientTypeRepository clientTypeService)
        {
            this._clientTypeService = clientTypeService;
        }



        public IEnumerable<ClientTypeViewModel> GetClientTypeList()
        {
            return this._clientTypeService.GetClientTypeList();
        }
    }
}
