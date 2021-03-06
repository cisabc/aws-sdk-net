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
using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Returns information about the AssumeRoleResult response and response metadata.
    /// </summary>
    public class AssumeRoleResponse : AmazonWebServiceResponse
    {
        private AssumeRoleResult _assumeRoleResult;

        /// <summary>
        /// Gets and sets the AssumeRoleResult property.
        /// Represents the output of a AssumeRole operation.
        /// </summary>
        public AssumeRoleResult AssumeRoleResult
        {
            get
            {
                if(this._assumeRoleResult == null)
                {
                    this._assumeRoleResult = new AssumeRoleResult();
                }
                return this._assumeRoleResult;
            }
            set { this._assumeRoleResult = value; }
        }
    }
}