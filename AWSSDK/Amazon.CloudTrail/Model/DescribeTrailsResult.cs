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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// <para>Returns the objects or data listed below if successful. Otherwise, returns an error.</para>
    /// </summary>
    public partial class DescribeTrailsResult
    {
        
        private List<Trail> trailList = new List<Trail>();

        /// <summary>
        /// An array of <a>Trail</a> objects.
        ///  
        /// </summary>
        public List<Trail> TrailList
        {
            get { return this.trailList; }
            set { this.trailList = value; }
        }
        /// <summary>
        /// Adds elements to the TrailList collection
        /// </summary>
        /// <param name="trailList">The values to add to the TrailList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrailsResult WithTrailList(params Trail[] trailList)
        {
            foreach (Trail element in trailList)
            {
                this.trailList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the TrailList collection
        /// </summary>
        /// <param name="trailList">The values to add to the TrailList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeTrailsResult WithTrailList(IEnumerable<Trail> trailList)
        {
            foreach (Trail element in trailList)
            {
                this.trailList.Add(element);
            }

            return this;
        }

        // Check to see if TrailList property is set
        internal bool IsSetTrailList()
        {
            return this.trailList.Count > 0;
        }
    }
}
