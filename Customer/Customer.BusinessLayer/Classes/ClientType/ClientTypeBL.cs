using Customer.BusinessEntities.ClientType;
using Customer.BusinessLayer.Interface.ClientType;
using Customer.DataLayer.Interface.ClientType;
using Customer.Logging;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Classes.ClientType
{
    /// <summary>
    /// This class contain the method of related to client type.
    /// </summary>
    public class ClientTypeBL : IClientTypeBL
    {
        #region Constructor
        private IClientTypeRepository _clientTypeService;
        private readonly ILogger _lLogger;
        public ClientTypeBL(IClientTypeRepository clientTypeService)
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
