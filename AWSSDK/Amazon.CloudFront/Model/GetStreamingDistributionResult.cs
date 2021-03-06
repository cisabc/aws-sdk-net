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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The returned result of the corresponding request.
    /// </summary>
    public partial class GetStreamingDistributionResult
    {
        private string _eTag;
        private StreamingDistribution _streamingDistribution;


        /// <summary>
        /// Gets and sets the property ETag. The current version of the streaming distribution's
        /// information. For example: E2QWRUHAPOMQZL.
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }


        /// <summary>
        /// Sets the ETag property
        /// </summary>
        /// <param name="eTag">The value to set for the ETag property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStreamingDistributionResult WithETag(string eTag)
        {
            this._eTag = eTag;
            return this;
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }


        /// <summary>
        /// Gets and sets the property StreamingDistribution. The streaming distribution's information.
        /// </summary>
        public StreamingDistribution StreamingDistribution
        {
            get { return this._streamingDistribution; }
            set { this._streamingDistribution = value; }
        }


        /// <summary>
        /// Sets the StreamingDistribution property
        /// </summary>
        /// <param name="streamingDistribution">The value to set for the StreamingDistribution property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStreamingDistributionResult WithStreamingDistribution(StreamingDistribution streamingDistribution)
        {
            this._streamingDistribution = streamingDistribution;
            return this;
        }

        // Check to see if StreamingDistribution property is set
        internal bool IsSetStreamingDistribution()
        {
            return this._streamingDistribution != null;
        }

    }
}