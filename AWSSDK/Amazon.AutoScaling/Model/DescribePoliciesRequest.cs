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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePolicies operation.
    /// Returns descriptions of what each policy does.            This action
    /// supports pagination. If the response includes a token,             there are more
    /// records available. To get the additional records, repeat            the request with
    /// the response token as the <code>NextToken</code> parameter.
    /// </summary>
    public partial class DescribePoliciesRequest : AmazonWebServiceRequest
    {
        private string _autoScalingGroupName;
        private int? _maxRecords;
        private string _nextToken;
        private List<string> _policyNames = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///             The name of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///             The maximum number of policies that will be described            with
        /// each call.        
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///             A string that is used to mark the start of the next            batch of
        /// returned results for pagination.        
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
        public DescribePoliciesRequest WithNextToken(string nextToken)
        {
            this._nextToken = nextToken;
            return this;
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }


        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        ///             A list of policy names or policy ARNs to be            described. If this
        /// list is omitted, all policy names            are described. If an auto scaling group
        /// name is            provided, the results are limited to that group. The          
        ///  list of requested policy names cannot contain more            than 50 items. If unknown
        /// policy names are            requested, they are ignored with no error.        
        /// </para>
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        /// <summary>
        /// Sets the PolicyNames property
        /// </summary>
        /// <param name="policyNames">The values to add to the PolicyNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesRequest WithPolicyNames(params string[] policyNames)
        {
            foreach (var element in policyNames)
            {
                this._policyNames.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the PolicyNames property
        /// </summary>
        /// <param name="policyNames">The values to add to the PolicyNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribePoliciesRequest WithPolicyNames(IEnumerable<string> policyNames)
        {
            foreach (var element in policyNames)
            {
                this._policyNames.Add(element);
            }
            return this;
        }
        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && this._policyNames.Count > 0; 
        }

    }
}