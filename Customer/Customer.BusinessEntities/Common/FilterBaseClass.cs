using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BusinessEntities.Common
{
    public class FilterBaseClass
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int SortOrder { get; set; }
        public int SortCOlumn { get; set; }
    }
}
