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
    /// The settings for Automatic Input Failover.
    /// </summary>
    public partial class AutomaticInputFailoverSettings
    {
        private InputPreference _inputPreference;
        private string _secondaryInputId;

        /// <summary>
        /// Gets and sets the property InputPreference. Input preference when deciding which input
        /// to make active when a previously failed input has recovered.
        /// </summary>
        public InputPreference InputPreference
        {
            get { return this._inputPreference; }
            set { this._inputPreference = value; }
        }

        // Check to see if InputPreference property is set
        internal bool IsSetInputPreference()
        {
            return this._inputPreference != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryInputId. The input ID of the secondary input in
        /// the automatic input failover pair.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecondaryInputId
        {
            get { return this._secondaryInputId; }
            set { this._secondaryInputId = value; }
        }

        // Check to see if SecondaryInputId property is set
        internal bool IsSetSecondaryInputId()
        {
            return this._secondaryInputId != null;
        }

    }
}