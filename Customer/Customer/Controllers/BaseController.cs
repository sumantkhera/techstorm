namespace Customer.Controllers
{
    using Customer.Logging;
    using System.Web.Http;

    /// <summary>
    /// This class contain common function.
    /// </summary>
    public class BaseController : ApiController
    {
        #region Constructor
        public ILogger _lLogger { get; set; }

        public BaseController()
        {
            _lLogger = Log4NetLogger.Instance;
        }
        #endregion

        public int UserId
        {
            get
            {
                int userId = 0;
                int.TryParse(User.Identity.Name, out userId);
                return userId;
            }
        }
    }
}