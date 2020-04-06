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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the ListRegexPatternSets operation.
    /// </summary>
    public partial class ListRegexPatternSetsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<RegexPatternSetSummary> _regexPatternSets = new List<RegexPatternSetSummary>();

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <code>Limit</code> setting, if the number
        /// of objects that are still available for retrieval exceeds the limit, AWS WAF returns
        /// a <code>NextMarker</code> value in the response. To retrieve the next batch of objects,
        /// provide the marker from the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property RegexPatternSets.
        /// </summary>
        public List<RegexPatternSetSummary> RegexPatternSets
        {
            get { return this._regexPatternSets; }
            set { this._regexPatternSets = value; }
        }

        // Check to see if RegexPatternSets property is set
        internal bool IsSetRegexPatternSets()
        {
            return this._regexPatternSets != null && this._regexPatternSets.Count > 0; 
        }

    }
}