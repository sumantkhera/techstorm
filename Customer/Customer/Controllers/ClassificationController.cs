namespace Customer.Controllers
{
    using Customer.BusinessLayer.Interface.Classification;
    using Customer.Filters;
    using Customer.Logging;
    using System.Web.Http;

    /// <summary>
    /// This class contain the function related to classification.
    /// </summary>
    [CustomAuthorizeAttribute]
    public class ClassificationController : BaseController
    {
        #region Constructor

        private readonly IClassificationBL _classificationBL;
        public ClassificationController(IClassificationBL classificationBL)
        {
            this._classificationBL = classificationBL;
        }

        #endregion


        #region Get
        /// <summary>
        /// Get list of classification.
        /// </summary>
        /// <returns>Json list of classfication.</returns>
        [HttpGet]
        public IHttpActionResult GetClassificationList()
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetClassificationList");
            var result = this._classificationBL.GetClassificationList();
            _lLogger.End();
            return Ok(result);
        }

        #endregion

    }
}
