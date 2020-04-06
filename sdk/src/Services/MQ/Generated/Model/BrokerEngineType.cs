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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Types of broker engines.
    /// </summary>
    public partial class BrokerEngineType
    {
        private EngineType _engineType;
        private List<EngineVersion> _engineVersions = new List<EngineVersion>();

        /// <summary>
        /// Gets and sets the property EngineType. The type of broker engine.
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersions. The list of engine versions.
        /// </summary>
        public List<EngineVersion> EngineVersions
        {
            get { return this._engineVersions; }
            set { this._engineVersions = value; }
        }

        // Check to see if EngineVersions property is set
        internal bool IsSetEngineVersions()
        {
            return this._engineVersions != null && this._engineVersions.Count > 0; 
        }

    }
}