using Customer.BusinessLayer.Interface.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Classification;
using Customer.DataLayer.Interface.Classification;

namespace Customer.BusinessLayer.Classes.Classification
{
    public class ClassificationBL : IClassificationBL
    {
        private IClassificationRepository _classificationService;
        public ClassificationBL(IClassificationRepository classificationService)
        {
            this._classificationService = classificationService;
        }

        public IEnumerable<ClassificationViewModel> GetClassificationList()
        {
            return this._classificationService.GetClassificationList();
        }
    }
}
