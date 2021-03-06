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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// When you update status for a pipeline,        Elastic Transcoder returns the values
    /// that you specified in the request.
    /// </summary>
    public partial class UpdatePipelineStatusResult
    {
        private Pipeline _pipeline;


        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// A section of the response body that provides information about the pipeline.
        /// </para>
        /// </summary>
        public Pipeline Pipeline
        {
            get { return this._pipeline; }
            set { this._pipeline = value; }
        }


        /// <summary>
        /// Sets the Pipeline property
        /// </summary>
        /// <param name="pipeline">The value to set for the Pipeline property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdatePipelineStatusResult WithPipeline(Pipeline pipeline)
        {
            this._pipeline = pipeline;
            return this;
        }

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this._pipeline != null;
        }

    }
}