using Customer.BusinessLayer.IService.Classification;
using Customer.DataLayer.IRepository.Classification;
using Customer.Logging;
using Customer.ViewModel.Classification;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Service.Classification
{
    /// <summary>
    /// This class contain the method declaration related to classification.
    /// </summary>
    public class ClassificationService : IClassificationService
    {
        #region Constructor
        private readonly ILogger _lLogger;
        private IClassificationRepository _classificationService;
        public ClassificationService(IClassificationRepository classificationService)
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
