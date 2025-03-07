﻿// Copyright (c) 2025, Siemens AG
//
// SPDX-License-Identifier: MIT
using System;

namespace Siemens.Simatic.S7.Webserver.API.Exceptions
{
    /// <summary>
    /// The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources for new applications 
    /// (or structure existing applications using /in resources names).
    /// </summary>
    public class ApiApplicationLimitReachedException : Exception
    {
        private static string message = "The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources " +
            "for new applications (or structure existing applications using /in resources names).";
        /// <summary>
        /// The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources for new applications 
        /// (or structure existing applications using /in resources names).
        /// </summary>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ApiApplicationLimitReachedException(Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources for new applications 
        /// (or structure existing applications using /in resources names).
        /// </summary>
        public ApiApplicationLimitReachedException() : base(message) { }


        /// <summary>
        /// The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources for new applications 
        /// (or structure existing applications using /in resources names).
        /// </summary>
        /// <param name="userMessage">Further information about the error message that explains the reason for the exception.</param>
        public ApiApplicationLimitReachedException(string userMessage) : base(message + Environment.NewLine + userMessage) { }
        /// <summary>
        /// The maximum amount of WebApps is reached. Delete unused or not needed Webapplications in order to free resources for new applications 
        /// (or structure existing applications using /in resources names).
        /// </summary>
        /// <param name="userMessage">Further information about the error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference
        /// (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ApiApplicationLimitReachedException(string userMessage, Exception innerException) : base(message + Environment.NewLine + userMessage, innerException) { }
    }
}
