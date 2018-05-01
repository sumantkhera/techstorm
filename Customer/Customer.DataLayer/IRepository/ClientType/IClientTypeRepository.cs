using Customer.ViewModel.ClientType;
using System.Collections.Generic;

namespace Customer.DataLayer.IRepository.ClientType
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
