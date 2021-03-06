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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Parameter Object
    /// </summary>  
    public class ParameterUnmarshaller : IUnmarshaller<Parameter, XmlUnmarshallerContext>, IUnmarshaller<Parameter, JsonUnmarshallerContext>
    {
        public Parameter Unmarshall(XmlUnmarshallerContext context)
        {
            Parameter unmarshalledObject = new Parameter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.AllowedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.DataType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.IsModifiable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinimumEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.MinimumEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ParameterName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ParameterValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Source", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public Parameter Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ParameterUnmarshaller instance;
        public static ParameterUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ParameterUnmarshaller();
            }
            return instance;
        }

    }
}