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
    /// The <code>PolicyARNType</code> data type.
    /// </summary>
    public partial class PutScalingPolicyResult
    {
        private string _policyARN;


        /// <summary>
        /// Gets and sets the property PolicyARN. 
        /// <para>
        ///             A policy's Amazon Resource Name (ARN).        
        /// </para>
        /// </summary>
        public string PolicyARN
        {
            get { return this._policyARN; }
            set { this._policyARN = value; }
        }


        /// <summary>
        /// Sets the PolicyARN property
        /// </summary>
        /// <param name="policyARN">The value to set for the PolicyARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutScalingPolicyResult WithPolicyARN(string policyARN)
        {
            this._policyARN = policyARN;
            return this;
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this._policyARN != null;
        }

    }
}