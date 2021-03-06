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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationSettingsDescription Object
    /// </summary>  
    public class ConfigurationSettingsDescriptionUnmarshaller : IUnmarshaller<ConfigurationSettingsDescription, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationSettingsDescription, JsonUnmarshallerContext>
    {
        public ConfigurationSettingsDescription Unmarshall(XmlUnmarshallerContext context)
        {
            ConfigurationSettingsDescription unmarshalledObject = new ConfigurationSettingsDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.DateCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.DateUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeploymentStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.DeploymentStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OptionSettings/member", targetDepth))
                    {
                        var unmarshaller = ConfigurationOptionSettingUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.OptionSettings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.SolutionStackName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.TemplateName = unmarshaller.Unmarshall(context);
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

        public ConfigurationSettingsDescription Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ConfigurationSettingsDescriptionUnmarshaller instance;
        public static ConfigurationSettingsDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ConfigurationSettingsDescriptionUnmarshaller();
            }
            return instance;
        }

    }
}