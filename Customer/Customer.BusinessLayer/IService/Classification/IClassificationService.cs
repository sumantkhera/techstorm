using Customer.ViewModel.Classification;
using System.Collections.Generic;

namespace Customer.BusinessLayer.IService.Classification
{
    /// <summary>
    /// This interface contain the method declaration related to classification.
    /// </summary>
    public interface IClassificationService
    {
		/// <summary>
		/// Get Classification  Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IEnumerable<ClassificationViewModel> GetClassificationList();
    }
}
