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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the ListEventSubscriptions operation.
    /// </summary>
    public partial class ListEventSubscriptionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Subscription> _subscriptions = new List<Subscription>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  When a response is generated, if there is more data to be listed, this parameter
        /// is present in the response and contains the value to use for the <b>nextToken</b>
        /// parameter in a subsequent pagination request. If there is no more data to be listed,
        /// this parameter is set to null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// Details of the returned event subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<Subscription> Subscriptions
        {
            get { return this._subscriptions; }
            set { this._subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this._subscriptions != null && this._subscriptions.Count > 0; 
        }

    }
}