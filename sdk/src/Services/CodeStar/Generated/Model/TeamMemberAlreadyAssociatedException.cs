/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Net;
using Amazon.Runtime;

namespace Amazon.CodeStar.Model
{
    ///<summary>
    /// CodeStar exception
    /// </summary>
#if !PCL && !NETSTANDARD
    [Serializable]
#endif
    public class TeamMemberAlreadyAssociatedException : AmazonCodeStarException 
    {
        /// <summary>
        /// Constructs a new TeamMemberAlreadyAssociatedException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public TeamMemberAlreadyAssociatedException(string message) 
            : base(message) {}
          
        /// <summary>
        /// Construct instance of TeamMemberAlreadyAssociatedException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public TeamMemberAlreadyAssociatedException(string message, Exception innerException) 
            : base(message, innerException) {}
            
        /// <summary>
        /// Construct instance of TeamMemberAlreadyAssociatedException
        /// </summary>
        /// <param name="innerException"></param>
        public TeamMemberAlreadyAssociatedException(Exception innerException) 
            : base(innerException) {}
            
        /// <summary>
        /// Construct instance of TeamMemberAlreadyAssociatedException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public TeamMemberAlreadyAssociatedException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of TeamMemberAlreadyAssociatedException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public TeamMemberAlreadyAssociatedException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !PCL && !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the TeamMemberAlreadyAssociatedException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected TeamMemberAlreadyAssociatedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

#endif
    }
}