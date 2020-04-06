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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceUpdate Object
    /// </summary>  
    public class ServiceUpdateUnmarshaller : IUnmarshaller<ServiceUpdate, XmlUnmarshallerContext>, IUnmarshaller<ServiceUpdate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceUpdate Unmarshall(XmlUnmarshallerContext context)
        {
            ServiceUpdate unmarshalledObject = new ServiceUpdate();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoUpdateAfterRecommendedApplyByDate", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AutoUpdateAfterRecommendedApplyByDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedUpdateTime", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EstimatedUpdateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateEndDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateEndDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateRecommendedApplyByDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateRecommendedApplyByDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateReleaseDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateReleaseDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateSeverity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateSeverity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceUpdateType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ServiceUpdateType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ServiceUpdate Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ServiceUpdateUnmarshaller _instance = new ServiceUpdateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceUpdateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}