using Customer.BusinessEntities.Classification;
using Customer.BusinessLayer.Interface.Classification;
using Customer.DataLayer.Interface.Classification;
using Customer.Logging;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Classes.Classification
{
    /// <summary>
    /// This class contain the method declaration related to classification.
    /// </summary>
    public class ClassificationBL : IClassificationBL
    {
        #region Constructor
        private readonly ILogger _lLogger;
        private IClassificationRepository _classificationService;
        public ClassificationBL(IClassificationRepository classificationService)
        {
            _lLogger = Log4NetLogger.Instance;
            this._classificationService = classificationService;
        }
        #endregion

        #region Public method
        /// <summary>
        /// Get the list of classification.
        /// </summary>
        /// <returns>List of classification.</returns>
        public IEnumerable<ClassificationViewModel> GetClassificationList()
        {
            _lLogger.Start(LogLevel.INFO, null, () => "GetClassificationList");
            var classificationList = this._classificationService.GetClassificationList();
            _lLogger.End();
            return classificationList;
        }
        #endregion
    }
}
