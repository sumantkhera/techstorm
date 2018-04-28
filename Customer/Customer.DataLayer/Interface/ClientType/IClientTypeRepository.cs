using Customer.BusinessEntities.ClientType;
using System.Collections.Generic;

namespace Customer.DataLayer.Interface.ClientType
{
    /// <summary>
    /// This interface contain method related to clienttype.
    /// </summary>
    public interface IClientTypeRepository
    {
        /// <summary>
        /// Get list of client type.
        /// </summary>
        /// <returns>List of clientTypeViewmodel</returns>
        IEnumerable<ClientTypeViewModel> GetClientTypeList();
    }
}
