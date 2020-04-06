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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyVpcTenancy operation.
    /// </summary>
    public partial class ModifyVpcTenancyResponse : AmazonWebServiceResponse
    {
        private bool? _returnValue;

        /// <summary>
        /// Gets and sets the property ReturnValue. 
        /// <para>
        /// Returns <code>true</code> if the request succeeds; otherwise, returns an error.
        /// </para>
        /// </summary>
        public bool ReturnValue
        {
            get { return this._returnValue.GetValueOrDefault(); }
            set { this._returnValue = value; }
        }

        // Check to see if ReturnValue property is set
        internal bool IsSetReturnValue()
        {
            return this._returnValue.HasValue; 
        }

    }
}