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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Result message containing a list of environment resource         descriptions.
    /// </summary>
    public partial class DescribeEnvironmentResourcesResult
    {
        private EnvironmentResourceDescription _environmentResources;


        /// <summary>
        /// Gets and sets the property EnvironmentResources. 
        /// <para>
        ///          A list of         <a>EnvironmentResourceDescription</a>.      
        /// </para>
        /// </summary>
        public EnvironmentResourceDescription EnvironmentResources
        {
            get { return this._environmentResources; }
            set { this._environmentResources = value; }
        }


        /// <summary>
        /// Sets the EnvironmentResources property
        /// </summary>
        /// <param name="environmentResources">The value to set for the EnvironmentResources property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentResourcesResult WithEnvironmentResources(EnvironmentResourceDescription environmentResources)
        {
            this._environmentResources = environmentResources;
            return this;
        }

        // Check to see if EnvironmentResources property is set
        internal bool IsSetEnvironmentResources()
        {
            return this._environmentResources != null;
        }

    }
}