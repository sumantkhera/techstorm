using Customer.ViewModel.ClientType;
using System.Collections.Generic;

namespace Customer.BusinessLayer.IService.ClientType
{
    /// <summary>
    /// This interface contain the declaration method related to client type.
    /// </summary>
    public interface IClientTypeService
    {
        /// <summary>
        ///  Get List of ClientType.
        /// </summary>
        /// <returns>List of client type</returns>
        IEnumerable<ClientTypeViewModel> GetClientTypeList();
    }
}
