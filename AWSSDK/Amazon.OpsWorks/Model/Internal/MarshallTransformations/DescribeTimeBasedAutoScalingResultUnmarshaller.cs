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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeTimeBasedAutoScaling Object
    /// </summary>  
    public class DescribeTimeBasedAutoScalingResultUnmarshaller : IUnmarshaller<DescribeTimeBasedAutoScalingResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTimeBasedAutoScalingResult, JsonUnmarshallerContext>
    {
        DescribeTimeBasedAutoScalingResult IUnmarshaller<DescribeTimeBasedAutoScalingResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public DescribeTimeBasedAutoScalingResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new DescribeTimeBasedAutoScalingResult();
            unmarshalledObject.TimeBasedAutoScalingConfigurations = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("TimeBasedAutoScalingConfigurations", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.TimeBasedAutoScalingConfigurations =  null;
                            continue;
                        }
                        unmarshalledObject.TimeBasedAutoScalingConfigurations = new List<TimeBasedAutoScalingConfiguration>();
                        var unmarshaller = TimeBasedAutoScalingConfigurationUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.TimeBasedAutoScalingConfigurations.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }   
                           
            return unmarshalledObject;
        }


        private static DescribeTimeBasedAutoScalingResultUnmarshaller instance;
        public static DescribeTimeBasedAutoScalingResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new DescribeTimeBasedAutoScalingResultUnmarshaller();
            }
            return instance;
        }

    }
}