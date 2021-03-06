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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a list of all verified identities for the AWS Account.
    /// </summary>
    public partial class ListIdentitiesResult
    {
        private List<string> _identities = new List<string>();
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// A list of identities.
        /// </para>
        /// </summary>
        public List<string> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        /// <summary>
        /// Sets the Identities property
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListIdentitiesResult WithIdentities(params string[] identities)
        {
            foreach (var element in identities)
            {
                this._identities.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Identities property
        /// </summary>
        /// <param name="identities">The values to add to the Identities collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListIdentitiesResult WithIdentities(IEnumerable<string> identities)
        {
            foreach (var element in identities)
            {
                this._identities.Add(element);
            }
            return this;
        }
        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && this._identities.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used for pagination.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }


        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListIdentitiesResult WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}