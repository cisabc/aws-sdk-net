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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAccountLimits Request Marshaller
    /// </summary>       
    public class DescribeAccountLimitsRequestMarshaller : IMarshaller<IRequest, DescribeAccountLimitsRequest>
    {
        public IRequest Marshall(DescribeAccountLimitsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "DescribeAccountLimits");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
            }
            return request;
        }
    }
}