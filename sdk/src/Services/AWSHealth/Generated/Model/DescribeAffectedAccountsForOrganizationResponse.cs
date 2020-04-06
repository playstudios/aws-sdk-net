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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeAffectedAccountsForOrganization operation.
    /// </summary>
    public partial class DescribeAffectedAccountsForOrganizationResponse : AmazonWebServiceResponse
    {
        private List<string> _affectedAccounts = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AffectedAccounts. 
        /// <para>
        /// A JSON set of elements of the affected accounts.
        /// </para>
        /// </summary>
        public List<string> AffectedAccounts
        {
            get { return this._affectedAccounts; }
            set { this._affectedAccounts = value; }
        }

        // Check to see if AffectedAccounts property is set
        internal bool IsSetAffectedAccounts()
        {
            return this._affectedAccounts != null && this._affectedAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <code>nextToken</code> pagination token is returned in the response. To retrieve
        /// the next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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