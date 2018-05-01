using Customer.ViewModel.Classification;
using System.Collections.Generic;

namespace Customer.DataLayer.IRepository.Classification
{
    /// <summary>
    /// This interface contain the method related to classification.
    /// </summary>
    public interface IClassificationRepository
    {
        /// <summary>
        /// Get the list of classification.
        /// </summary>
        /// <returns>List of classification.</returns>
        IEnumerable<ClassificationViewModel> GetClassificationList();
    }
}
