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
using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListDomainNamesResult Unmarshaller
     /// </summary>
    internal class ListDomainNamesResultUnmarshaller : IUnmarshaller<ListDomainNamesResult, XmlUnmarshallerContext>, IUnmarshaller<ListDomainNamesResult, JsonUnmarshallerContext> 
    {
        public ListDomainNamesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListDomainNamesResult listDomainNamesResult = new ListDomainNamesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("DomainNames/entry", targetDepth))
                    {
                        KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        KeyValuePair<string, string> kvp = unmarshaller.Unmarshall(context);
                        listDomainNamesResult.DomainNames.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listDomainNamesResult;
                }
            }
                        


            return listDomainNamesResult;
        }

        public ListDomainNamesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListDomainNamesResultUnmarshaller instance;

        public static ListDomainNamesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListDomainNamesResultUnmarshaller();

            return instance;
        }
    }
}
    
