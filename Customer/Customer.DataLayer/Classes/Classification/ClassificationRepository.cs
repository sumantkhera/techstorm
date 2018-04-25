using Customer.BusinessEntities.Classification;
using Customer.DataLayer.Interface.Classification;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Customer.DataLayer.Classes.Classification
{
    public class ClassificationRepository : BaseRepository, IClassificationRepository, IDisposable
    {
        public IEnumerable<ClassificationViewModel> GetClassificationList()
        {
            using (var databaseContext = new DatabaseContext())
            {
                var result = from classification in databaseContext.Classifications
                             select (new ClassificationViewModel
                             {
                                 Id = classification.Id,
                                 ClassificationName = classification.ClassificationName,
                             });
                return result.ToList();
            }
        }
    }
}
