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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FlinkApplicationConfiguration Marshaller
    /// </summary>       
    public class FlinkApplicationConfigurationMarshaller : IRequestMarshaller<FlinkApplicationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FlinkApplicationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCheckpointConfiguration())
            {
                context.Writer.WritePropertyName("CheckpointConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = CheckpointConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CheckpointConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonitoringConfiguration())
            {
                context.Writer.WritePropertyName("MonitoringConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = MonitoringConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitoringConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParallelismConfiguration())
            {
                context.Writer.WritePropertyName("ParallelismConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ParallelismConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParallelismConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FlinkApplicationConfigurationMarshaller Instance = new FlinkApplicationConfigurationMarshaller();

    }
}