using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.BusinessEntities.Classification;

namespace Customer.DataLayer.Interface.Classification
{
    public interface IClassificationRepository
    {
        IEnumerable<ClassificationViewModel> GetClassificationList();
    }
}
