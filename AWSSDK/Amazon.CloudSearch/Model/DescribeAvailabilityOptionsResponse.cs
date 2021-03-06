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

using Amazon.Runtime;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Returns information about the  DescribeAvailabilityOptionsResult response and response metadata.
    /// </summary>
    public class DescribeAvailabilityOptionsResponse : AmazonWebServiceResponse
    {
        private DescribeAvailabilityOptionsResult describeAvailabilityOptionsResult;

        /// <summary>
        /// Gets and sets the DescribeAvailabilityOptionsResult property.
        /// The result of a DescribeAvailabilityOptions request. Indicates whether or not the Multi-AZ option is enabled for the domain specified in the
        /// request.
        /// </summary>
        public DescribeAvailabilityOptionsResult DescribeAvailabilityOptionsResult
        {
            get
            {
                if(this.describeAvailabilityOptionsResult == null)
                {
                    this.describeAvailabilityOptionsResult = new DescribeAvailabilityOptionsResult();
                }

                return this.describeAvailabilityOptionsResult;
            }
            set { this.describeAvailabilityOptionsResult = value; }
        }
    }
}
    
