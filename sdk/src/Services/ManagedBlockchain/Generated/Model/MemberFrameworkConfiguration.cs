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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Configuration properties relevant to a member for the blockchain framework that the
    /// Managed Blockchain network uses.
    /// </summary>
    public partial class MemberFrameworkConfiguration
    {
        private MemberFabricConfiguration _fabric;

        /// <summary>
        /// Gets and sets the property Fabric. 
        /// <para>
        /// Attributes of Hyperledger Fabric for a member on a Managed Blockchain network that
        /// uses Hyperledger Fabric.
        /// </para>
        /// </summary>
        public MemberFabricConfiguration Fabric
        {
            get { return this._fabric; }
            set { this._fabric = value; }
        }

        // Check to see if Fabric property is set
        internal bool IsSetFabric()
        {
            return this._fabric != null;
        }

    }
}