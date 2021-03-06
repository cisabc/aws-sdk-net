/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInterconnects operation.
    /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
    /// particular interconnect.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeInterconnects"/>
    public class DescribeInterconnectsRequest : AmazonWebServiceRequest
    {
        private string interconnectId;

        /// <summary>
        /// The ID of the interconnect. Example: dxcon-abc123
        ///  
        /// </summary>
        public string InterconnectId
        {
            get { return this.interconnectId; }
            set { this.interconnectId = value; }
        }

        /// <summary>
        /// Sets the InterconnectId property
        /// </summary>
        /// <param name="interconnectId">The value to set for the InterconnectId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInterconnectsRequest WithInterconnectId(string interconnectId)
        {
            this.interconnectId = interconnectId;
            return this;
        }
            

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this.interconnectId != null;
        }
    }
}
    
