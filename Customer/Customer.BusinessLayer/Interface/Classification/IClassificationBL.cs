using Customer.BusinessEntities.Classification;
using System.Collections.Generic;

namespace Customer.BusinessLayer.Interface.Classification
{
    /// <summary>
    /// This interface contain the method declaration related to classification.
    /// </summary>
    public interface IClassificationBL
    {
		/// <summary>
		/// Get Classification  Information
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IEnumerable<ClassificationViewModel> GetClassificationList();
    }
}
