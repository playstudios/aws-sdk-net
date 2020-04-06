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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a virtual service backend for a virtual node.
    /// </summary>
    public partial class VirtualServiceBackend
    {
        private ClientPolicy _clientPolicy;
        private string _virtualServiceName;

        /// <summary>
        /// Gets and sets the property ClientPolicy. 
        /// <para>
        /// A reference to an object that represents the client policy for a backend.
        /// </para>
        /// </summary>
        public ClientPolicy ClientPolicy
        {
            get { return this._clientPolicy; }
            set { this._clientPolicy = value; }
        }

        // Check to see if ClientPolicy property is set
        internal bool IsSetClientPolicy()
        {
            return this._clientPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualServiceName. 
        /// <para>
        /// The name of the virtual service that is acting as a virtual node backend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VirtualServiceName
        {
            get { return this._virtualServiceName; }
            set { this._virtualServiceName = value; }
        }

        // Check to see if VirtualServiceName property is set
        internal bool IsSetVirtualServiceName()
        {
            return this._virtualServiceName != null;
        }

    }
}