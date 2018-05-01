using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.ViewModel.Security
{
    using System;
    using System.Security.Claims;
    using System.Security.Principal;
    public class CustomIdentity : IPrincipal
    {

        public IIdentity Identity { get; }

        public CustomIdentity()
        {

        }
        public CustomIdentity(ClaimsPrincipal claimsPrincipal)
        {
            UserId = claimsPrincipal.HasClaim(x => x.Type == "userId") ? Convert.ToInt32(claimsPrincipal.FindFirst("UserId").Value) : 0;
            UserName = claimsPrincipal.HasClaim(x => x.Type == "userName") ? claimsPrincipal.FindFirst("userName").Value : string.Empty;
        }

        public int UserId { get; set; }
        public string UserName { get; set; }

        /// <summary>
        /// IsInRole
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public bool IsInRole(string role)
        {
            return true;//throw new NotImplementedException();
        }
    }
}
