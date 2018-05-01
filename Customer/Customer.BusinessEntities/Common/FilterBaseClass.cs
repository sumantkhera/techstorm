using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.ViewModel.Common
{
    public class FilterBaseClass
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SortOrder { get; set; } = "desc";
        public string SortColumn { get; set; } = "name";
    }
}
