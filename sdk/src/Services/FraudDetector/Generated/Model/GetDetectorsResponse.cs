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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// This is the response object from the GetDetectors operation.
    /// </summary>
    public partial class GetDetectorsResponse : AmazonWebServiceResponse
    {
        private List<Detector> _detectors = new List<Detector>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Detectors. 
        /// <para>
        /// The detectors.
        /// </para>
        /// </summary>
        public List<Detector> Detectors
        {
            get { return this._detectors; }
            set { this._detectors = value; }
        }

        // Check to see if Detectors property is set
        internal bool IsSetDetectors()
        {
            return this._detectors != null && this._detectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next page token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}