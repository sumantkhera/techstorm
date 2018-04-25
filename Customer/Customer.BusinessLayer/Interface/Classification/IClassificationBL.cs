using Customer.BusinessEntities.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessLayer.Interface.Classification
{
    public interface IClassificationBL
    {
        IEnumerable<ClassificationViewModel> GetClassificationList();
    }
}
