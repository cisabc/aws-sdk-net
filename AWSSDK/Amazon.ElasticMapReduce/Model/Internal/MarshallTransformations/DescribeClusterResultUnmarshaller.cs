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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeCluster Object
    /// </summary>  
    public class DescribeClusterResultUnmarshaller : IUnmarshaller<DescribeClusterResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeClusterResult, JsonUnmarshallerContext>
    {
        DescribeClusterResult IUnmarshaller<DescribeClusterResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public DescribeClusterResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new DescribeClusterResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Cluster", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.Cluster = null;
                            continue;
                        }
                        unmarshalledObject.Cluster = ClusterUnmarshaller.GetInstance().Unmarshall(context);
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


        private static DescribeClusterResultUnmarshaller instance;
        public static DescribeClusterResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new DescribeClusterResultUnmarshaller();
            }
            return instance;
        }

    }
}