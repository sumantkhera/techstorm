// <copyright file="Log4NetLogger.cs" company="TechStorm">
//     Copyright (c) TechStorm. All rights reserved.
// </copyright>
namespace Customer.Logging
{
    using System;
    using System.IO;
    using System.Linq.Expressions;
    using System.Web.Hosting;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    using log4net;
    using Newtonsoft.Json;

    public class Log4NetLogger : ILogger
    {
        private string methodName;
        private string paramaterLog;
        private static Log4NetLogger _iLogger = null;
        private List<Tuple<String, object>> providedParametars;

        public Log4NetLogger()
        {

        }

        public static Log4NetLogger Instance
        {
            get
            {
                lock (new object())
                {
                    if (_iLogger == null)
                    {
                        _iLogger = new Log4NetLogger();
                        string configFile = HostingEnvironment.ApplicationPhysicalPath + "\\Web.config";
                        var fileInfo = new FileInfo(configFile);
                        log4net.Config.XmlConfigurator.ConfigureAndWatch(fileInfo);
                    }
                }
                return _iLogger;
            }
        }

        private ILog log;

        public void Log(Type t, LogLevel level, string message)
        {
            log = log4net.LogManager.GetLogger(t.Name);
            lock (this)
            {
                switch (level)
                {
                    case LogLevel.FATAL:
                        if (log.IsFatalEnabled) log.Fatal(message);
                        break;
                    case LogLevel.ERROR:
                        if (log.IsErrorEnabled) log.Error(message);
                        break;
                    case LogLevel.WARN:
                        if (log.IsWarnEnabled) log.Warn(message);
                        break;
                    case LogLevel.INFO:
                        if (log.IsInfoEnabled) log.Info(message);
                        break;
                    case LogLevel.VERBOSE:
                        if (log.IsDebugEnabled) log.Debug(message);
                        break;
                }
            }
        }

        public void Log(Type t, LogLevel level, string message, dynamic Object)
        {
            lock (this)
            {
                switch (level)
                {
                    case LogLevel.FATAL:
                        if (log.IsFatalEnabled) log.Fatal(message);
                        break;
                    case LogLevel.ERROR:
                        if (log.IsErrorEnabled) log.Error(message);
                        break;
                    case LogLevel.WARN:
                        if (log.IsWarnEnabled) log.Warn(message);
                        break;
                    case LogLevel.INFO:
                        if (log.IsInfoEnabled) log.Info(message);
                        break;
                    case LogLevel.VERBOSE:
                        if (log.IsDebugEnabled) log.Debug(message);
                        break;
                }
            }
        }

        public void Log(Type t, LogLevel level, string message, System.Exception exception)
        {

            lock (this)
            {
                switch (level)
                {
                    case LogLevel.FATAL:
                        if (log.IsFatalEnabled) log.Fatal(message, exception);
                        break;
                    case LogLevel.ERROR:
                        if (log.IsErrorEnabled) log.Error(message, exception);
                        break;
                    case LogLevel.WARN:
                        if (log.IsWarnEnabled) log.Warn(message, exception);
                        break;
                    case LogLevel.INFO:
                        if (log.IsInfoEnabled) log.Info(message, exception);
                        break;
                    case LogLevel.VERBOSE:
                        if (log.IsDebugEnabled) log.Debug(message, exception);
                        break;
                }
            }
        }

        public void Log(Type t, LogLevel level, string message, System.Exception exception, dynamic Object)
        {
 
            lock (this)
            {
                switch (level)
                {
                    case LogLevel.FATAL:
                        if (log.IsFatalEnabled) log.Fatal(message, exception);
                        break;
                    case LogLevel.ERROR:
                        if (log.IsErrorEnabled) log.Error(message, exception);
                        break;
                    case LogLevel.WARN:
                        if (log.IsWarnEnabled) log.Warn(message, exception);
                        break;
                    case LogLevel.INFO:
                        if (log.IsInfoEnabled) log.Info(message, exception);
                        break;
                    case LogLevel.VERBOSE:
                        if (log.IsDebugEnabled) log.Debug(message, exception);
                        break;
                }
            }
        }

        /// <summary>
        /// Function is used to log the message
        /// </summary>
        /// <param name="level">LogLevel. Type of log</param>
        /// <param name="ex">Exception: if exception is going to log then pass the exception as parameter.</param>
        /// <param name="providedParameters">Para,meters: All the parametres which is passed to a method</param>
        public void Start(LogLevel level, Exception ex, params Expression<Func<object>>[] providedParameters)
        {
            var currentMethod = new StackTrace().GetFrame(1).GetMethod();
            var message = string.Empty;
            //Set class and current method info
            methodName = String.Format("Class = {0}, Method = {1}", currentMethod.DeclaringType.FullName, currentMethod.Name);

            //Get provided methods parameters
            providedParametars = new List<Tuple<string, object>>();
            if (providedParametars != null && providedParameters != null)
            {
                foreach (var aExpression in providedParameters)
                {
                    var value = aExpression.Compile().Invoke();
                    string name = string.Empty;
                    Expression bodyType = aExpression.Body;
                    if (bodyType is MemberExpression)
                    {
                        name = ((MemberExpression)aExpression.Body).Member.Name;
                    }
                    else if (bodyType is UnaryExpression)
                    {
                        UnaryExpression unaryExpression = (UnaryExpression)aExpression.Body;
                        name = ((MemberExpression)unaryExpression.Operand).Member.Name;
                    }
                    providedParametars.Add(new Tuple<string, object>(name, value));

                }

                foreach (var provParameter in providedParametars)
                {
                    paramaterLog += String.Format(@" ""{0}"":{1},", provParameter.Item1, JsonConvert.SerializeObject(provParameter.Item2, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }));
                }
                message = "Start time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff") + ", " + methodName + ", Data=" + ((paramaterLog != null) ? paramaterLog.Trim(' ', ',') : string.Empty);
            }
            else
            {
                message = "Start time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff") + ", " + methodName + ", Data=" + string.Empty;
            }
            // Log data
            if (ex != null)
                Log(currentMethod.DeclaringType, level, message, ex);
            else
                Log(currentMethod.DeclaringType, level, message);

        }

        /// <summary>
        /// Function is used to log the message when function excecution end. it is optional.
        /// </summary>
        public void End()
        {
            /*Get calling method name and class details */
            var currentMethod = new StackTrace().GetFrame(1).GetMethod();
            methodName = String.Format("Class = {0}, Method = {1}", currentMethod.DeclaringType.FullName, currentMethod.Name);
            //// Create subject message which would be saved.
            string message = "End time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff") + ", " + methodName;
            //// Call method to log the message
            Log(currentMethod.DeclaringType, LogLevel.INFO, message);

        }

        public void Start(LogLevel iNFO, object p1, Func<object> p2, Func<object> p3)
        {
            throw new NotImplementedException();
        }
    }


}
