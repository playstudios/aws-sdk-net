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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes one or more tags from a specified resource.
    /// </summary>
    public partial class UntagResourceRequest : AmazonRoute53ResolverRequest
    {
        private string _resourceArn;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the resource that you want to remove tags from.
        /// To get the ARN for a resource, use the applicable <code>Get</code> or <code>List</code>
        /// command: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetResolverEndpoint</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetResolverRule</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetResolverRuleAssociation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResolverEndpoints</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResolverRuleAssociations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResolverRules</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The tags that you want to remove to the specified resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}