namespace Customer.Controllers
{
    using Customer.BusinessLayer.Interface.ClientType;
    using Customer.Filters;
    using Customer.Logging;
    using System.Web.Http;

    /// <summary>
    /// This class contain the function related to client type.
    /// </summary>
    [CustomAuthorizeAttribute]
    public class ClientTypeController : BaseController
    {
        #region Constructor

        private readonly IClientTypeBL _clientTypeBL;
        public ClientTypeController(IClientTypeBL clientTypeBL)
        {
            this._clientTypeBL = clientTypeBL;
        }

        #endregion


        #region Get

        /// <summary>
        /// Get List of ClientType.
        /// </summary>
        /// <returns>Json list of client type.</returns>
        [HttpGet]
        public IHttpActionResult GetClientTypeList()
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetClientTypeList");
            var result = this._clientTypeBL.GetClientTypeList();
            _lLogger.End();
            return Ok(result);
        }

        #endregion
    }
}
