using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Business.Test.Helper
{
    public class ClassificationHelper
    {
        protected DatabaseContext _databaseContext;
        public ClassificationHelper()
        {
            this._databaseContext = new DatabaseContext();
        }
        public int ClassificationCount
        {
            get
            {
                var count = _databaseContext.Classifications.Count(p => p.IsDeleted == false);
                return count;
            }
        }
    }
}
