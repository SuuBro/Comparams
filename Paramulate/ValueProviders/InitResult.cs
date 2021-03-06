﻿using System.Collections.Generic;

namespace Paramulate.ValueProviders
{
    /// <summary>
    /// This class is returned by an IValueProvider's Init method, and is used to indicate the results
    /// of the Init. This includes unrecognised keys for which the value provider has values for, which
    /// could indicate an error in the input keys.
    /// </summary>
    public sealed class InitResult
    {
        private InitResult(IList<UnrecognisedParameter> unrecognisedParameters, bool helpWasRequested)
        {
            UnrecognisedParameters = unrecognisedParameters;
            HelpWasRequested = helpWasRequested;
        }

        /// <summary>
        /// The unrecognised parameters
        /// </summary>
        public IList<UnrecognisedParameter> UnrecognisedParameters { get; }
        
        /// <summary>
        /// The inputs provided indicate the used wants information about the possible
        /// parameters instead of normal execution of the application.
        /// </summary>
        public bool HelpWasRequested { get; }

        public static InitResult Ok()
        {
            return new InitResult(new UnrecognisedParameter[0], false);
        }
        
        public static InitResult HelpRequested()
        {
            return new InitResult(new UnrecognisedParameter[0], true);
        }

        public static InitResult UnrecognisedParams(IList<UnrecognisedParameter> unrecognisedParameters)
        {
            return new InitResult(unrecognisedParameters, false);
        }
    }
}