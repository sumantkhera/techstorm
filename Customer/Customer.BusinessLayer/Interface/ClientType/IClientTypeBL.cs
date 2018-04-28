using Customer.BusinessEntities.ClientType;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Interface.ClientType
{
    /// <summary>
    /// This interface contain the declaration method related to client type.
    /// </summary>
    public interface IClientTypeBL
    {
        /// <summary>
        ///  Get List of ClientType.
        /// </summary>
        /// <returns>List of client type</returns>
        IEnumerable<ClientTypeViewModel> GetClientTypeList();
    }
}
