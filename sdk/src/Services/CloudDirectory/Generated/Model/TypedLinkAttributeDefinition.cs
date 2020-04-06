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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// A typed link attribute definition.
    /// </summary>
    public partial class TypedLinkAttributeDefinition
    {
        private TypedAttributeValue _defaultValue;
        private bool? _isImmutable;
        private string _name;
        private RequiredAttributeBehavior _requiredBehavior;
        private Dictionary<string, Rule> _rules = new Dictionary<string, Rule>();
        private FacetAttributeType _type;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the attribute (if configured).
        /// </para>
        /// </summary>
        public TypedAttributeValue DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property IsImmutable. 
        /// <para>
        /// Whether the attribute is mutable or not.
        /// </para>
        /// </summary>
        public bool IsImmutable
        {
            get { return this._isImmutable.GetValueOrDefault(); }
            set { this._isImmutable = value; }
        }

        // Check to see if IsImmutable property is set
        internal bool IsSetIsImmutable()
        {
            return this._isImmutable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the typed link attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=230)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredBehavior. 
        /// <para>
        /// The required behavior of the <code>TypedLinkAttributeDefinition</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequiredAttributeBehavior RequiredBehavior
        {
            get { return this._requiredBehavior; }
            set { this._requiredBehavior = value; }
        }

        // Check to see if RequiredBehavior property is set
        internal bool IsSetRequiredBehavior()
        {
            return this._requiredBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Validation rules that are attached to the attribute definition.
        /// </para>
        /// </summary>
        public Dictionary<string, Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FacetAttributeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}