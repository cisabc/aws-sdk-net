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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Returns information about the  ListHealthChecksResult response and response metadata.
    /// </summary>
    public class ListHealthChecksResponse : AmazonWebServiceResponse
    {
        private ListHealthChecksResult listHealthChecksResult;

        /// <summary>
        /// Gets and sets the ListHealthChecksResult property.
        /// A complex type that contains the response for the request.
        /// </summary>
        public ListHealthChecksResult ListHealthChecksResult
        {
            get
            {
                if(this.listHealthChecksResult == null)
                {
                    this.listHealthChecksResult = new ListHealthChecksResult();
                }

                return this.listHealthChecksResult;
            }
            set { this.listHealthChecksResult = value; }
        }
    }
}
    
