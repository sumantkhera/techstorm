// <copyright file="ILogger.cs" company="TechStorm">
//     Copyright (c) TechStorm. All rights reserved.
// </copyright>
namespace Customer.Logging
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Logging interface
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Function is used to log the message
        /// </summary>
        /// <param name="level">LogLevel. Type of log</param>
        /// <param name="ex">Exception: if exception is going to log then pass the exception as parameter.</param>
        /// <param name="providedParameters">Para,meters: All the parametres which is passed to a method</param>
        void Start(LogLevel level, Exception ex, params Expression<Func<object>>[] providedParameters);

        /// <summary>
        /// Function is used to log the message when function excecution end. it is optional.
        /// </summary>
        void End();
        void Log(Type t, LogLevel level, string message);
        void Log(Type t, LogLevel level, string message, dynamic Object);
        void Log(Type t, LogLevel level, string message, System.Exception exception);
        void Log(Type t, LogLevel level, string message, System.Exception exception, dynamic Object);
        void Start(LogLevel iNFO, object p1, Func<object> p2, Func<object> p3);
    }
}