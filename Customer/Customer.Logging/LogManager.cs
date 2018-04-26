

namespace Customer.Logging
{
    using System;
    using System.Reflection;
    public class LogManager
    {
        private static ILogger logger;

        static LogManager()
        {
            logger = Log4NetLogger.Instance;
        }   

        #region Log
        public static void Log(Type t, LogLevel level, string activityName)
        {
            string loginUser = ""; //context.username
            string message = activityName + " activity is performed. For user: " + loginUser + " on dated: " + DateTime.Now;
            logger.Log(t, level, message);
        }
        public static void Log(Type t, LogLevel level, string exceptionMessage, System.Exception exception)
        {
            string loginUser = ""; //context.username
            string message = exceptionMessage + " activity is performed. For user: " + loginUser + " on dated: " + DateTime.Now;
            logger.Log(t, level, message, exception);
        }
        #endregion

        #region Log Information
        //Not in used, if needed change the accessor from private to public
        private static void LogMethod()
        {
            MethodBase methodBase = MethodBase.GetCurrentMethod();
            logger.Log(methodBase.DeclaringType, LogLevel.INFO, methodBase.Name + " method is called.");
        }
        //Not in used, if needed change the accessor from private to public
        private static void LogMethod(string loginUser)
        {
            MethodBase methodBase = MethodBase.GetCurrentMethod();
            logger.Log(methodBase.DeclaringType, LogLevel.INFO, methodBase.Name + " method is called. For user: " + loginUser);
        }
        //Not in used, if needed change the accessor from private to public
        private static void LogActivity(Type t, string activityName)
        {
            logger.Log(t, LogLevel.INFO, activityName + " activity is performed.");
        }
        //Not in used, if needed change the accessor from private to public
        private static void LogActivity(Type t, string activityName, string loginUser)
        {
            logger.Log(t, LogLevel.INFO, activityName + " activity is performed. For user: " + loginUser);
        }
        #endregion

        #region Log Error
        //Not in used, if needed change the accessor from private to public
        private static void LogError(Type t, string methodName, System.Exception exception)
        {
            logger.Log(t, LogLevel.ERROR, "Error found in method " + methodName + ". ", exception);
        }
        //Not in used, if needed change the accessor from private to public
        private static void LogError(Type t, string methodName, string loginUser, System.Exception exception)
        {
            logger.Log(t, LogLevel.ERROR, "Error found in method " + methodName + ". For loged user: " + loginUser + ".", exception);
        }
        #endregion


    }
}

