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
    /// Container for the parameters to the DescribePrefixLists operation.
    /// Describes available AWS services in a prefix list format, which includes the prefix
    /// list name and prefix list ID of the service and the IP address range for the service.
    /// A prefix list ID is required for creating an outbound security group rule that allows
    /// traffic from a VPC to access an AWS service through a gateway VPC endpoint. Currently,
    /// the services that support this action are Amazon S3 and Amazon DynamoDB.
    /// </summary>
    public partial class DescribePrefixListsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _prefixListIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>prefix-list-id</code>: The ID of a prefix list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>prefix-list-name</code>: The name of a prefix list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
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

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// One or more prefix list IDs.
        /// </para>
        /// </summary>
        public List<string> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && this._prefixListIds.Count > 0; 
        }

    }
}