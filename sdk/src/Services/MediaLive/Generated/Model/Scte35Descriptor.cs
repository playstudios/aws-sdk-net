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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Holds one set of SCTE-35 Descriptor Settings.
    /// </summary>
    public partial class Scte35Descriptor
    {
        private Scte35DescriptorSettings _scte35DescriptorSettings;

        /// <summary>
        /// Gets and sets the property Scte35DescriptorSettings. SCTE-35 Descriptor Settings.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35DescriptorSettings Scte35DescriptorSettings
        {
            get { return this._scte35DescriptorSettings; }
            set { this._scte35DescriptorSettings = value; }
        }

        // Check to see if Scte35DescriptorSettings property is set
        internal bool IsSetScte35DescriptorSettings()
        {
            return this._scte35DescriptorSettings != null;
        }

    }
}