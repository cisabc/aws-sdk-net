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
    /// Container for the parameters to the DescribeNotificationConfigurations operation.
    /// Returns a list of notification actions associated with Auto Scaling groups
    ///             for specified events.
    /// </summary>
    public partial class DescribeNotificationConfigurationsRequest : AmazonWebServiceRequest
    {
        private List<string> _autoScalingGroupNames = new List<string>();
        private int? _maxRecords;
        private string _nextToken;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupNames. 
        /// <para>
        ///             The name of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroupNames
        {
            get { return this._autoScalingGroupNames; }
            set { this._autoScalingGroupNames = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupNames property
        /// </summary>
        /// <param name="autoScalingGroupNames">The values to add to the AutoScalingGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeNotificationConfigurationsRequest WithAutoScalingGroupNames(params string[] autoScalingGroupNames)
        {
            foreach (var element in autoScalingGroupNames)
            {
                this._autoScalingGroupNames.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AutoScalingGroupNames property
        /// </summary>
        /// <param name="autoScalingGroupNames">The values to add to the AutoScalingGroupNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeNotificationConfigurationsRequest WithAutoScalingGroupNames(IEnumerable<string> autoScalingGroupNames)
        {
            foreach (var element in autoScalingGroupNames)
            {
                this._autoScalingGroupNames.Add(element);
            }
            return this;
        }
        // Check to see if AutoScalingGroupNames property is set
        internal bool IsSetAutoScalingGroupNames()
        {
            return this._autoScalingGroupNames != null && this._autoScalingGroupNames.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Maximum number of records to be returned.        
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
        public DescribeNotificationConfigurationsRequest WithMaxRecords(int maxRecords)
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
        public DescribeNotificationConfigurationsRequest WithNextToken(string nextToken)
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