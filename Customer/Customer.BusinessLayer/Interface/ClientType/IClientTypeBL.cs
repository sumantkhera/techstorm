using Customer.BusinessEntities.ClientType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Interface.ClientType
{
    public interface IClientTypeBL
    {
		/// <summary>
		///  Get ClientType  Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IEnumerable<ClientTypeViewModel> GetClientTypeList();
    }
}
