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

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Playlist Object
    /// </summary>  
    public class PlaylistUnmarshaller : IUnmarshaller<Playlist, XmlUnmarshallerContext>, IUnmarshaller<Playlist, JsonUnmarshallerContext>
    {
        Playlist IUnmarshaller<Playlist, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Playlist Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new Playlist();
            unmarshalledObject.OutputKeys = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Format", targetDepth))
                    {
                        unmarshalledObject.Format = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        unmarshalledObject.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OutputKeys", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.OutputKeys =  null;
                            continue;
                        }
                        unmarshalledObject.OutputKeys = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.OutputKeys.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        unmarshalledObject.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusDetail", targetDepth))
                    {
                        unmarshalledObject.StatusDetail = StringUnmarshaller.GetInstance().Unmarshall(context);
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


        private static PlaylistUnmarshaller instance;
        public static PlaylistUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new PlaylistUnmarshaller();
            }
            return instance;
        }

    }
}