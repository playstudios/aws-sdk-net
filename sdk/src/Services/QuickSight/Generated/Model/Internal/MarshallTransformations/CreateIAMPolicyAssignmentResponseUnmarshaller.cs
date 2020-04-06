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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateIAMPolicyAssignment operation
    /// </summary>  
    public class CreateIAMPolicyAssignmentResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateIAMPolicyAssignmentResponse response = new CreateIAMPolicyAssignmentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssignmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssignmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssignmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssignmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssignmentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssignmentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Identities", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    response.Identities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PolicyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PolicyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            response.Status = (int)context.ResponseData.StatusCode;

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
            {
                return new AccessDeniedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ConcurrentUpdatingException"))
            {
                return new ConcurrentUpdatingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalFailureException"))
            {
                return new InternalFailureException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
            {
                return new InvalidParameterValueException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceExistsException"))
            {
                return new ResourceExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
            {
                return new ThrottlingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonQuickSightException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateIAMPolicyAssignmentResponseUnmarshaller _instance = new CreateIAMPolicyAssignmentResponseUnmarshaller();        

        internal static CreateIAMPolicyAssignmentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIAMPolicyAssignmentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}