using Customer.BusinessLayer.IService.ClientType;
using Customer.DataLayer.IRepository.ClientType;
using Customer.Logging;
using Customer.ViewModel.ClientType;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Service.ClientType
{
    /// <summary>
    /// This class contain the method of related to client type.
    /// </summary>
    public class ClientTypeService : IClientTypeService
    {
        #region Constructor
        private IClientTypeRepository _clientTypeService;
        private readonly ILogger _lLogger;
        public ClientTypeService(IClientTypeRepository clientTypeService)
        {
            this._clientTypeService = clientTypeService;
            _lLogger = Log4NetLogger.Instance;
        }
        #endregion

        /// <summary>
        /// Get list of client type.
        /// </summary>
        /// <returns>List of clientTypeViewmodel</returns>
        public IEnumerable<ClientTypeViewModel> GetClientTypeList()
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetClientTypeList BL");
            var result = this._clientTypeService.GetClientTypeList();
            _lLogger.End();
            return result;
        }
    }
}
