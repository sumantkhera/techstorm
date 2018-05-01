using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.ViewModel.Common
{
    public class BaseViewModel
    {
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifyOn { get; set; }
        public string ModifyBy { get; set; }
    }
}
