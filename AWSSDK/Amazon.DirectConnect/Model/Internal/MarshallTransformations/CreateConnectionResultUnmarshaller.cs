/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System.IO;
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// CreateConnectionResultUnmarshaller
      /// </summary>
      internal class CreateConnectionResultUnmarshaller : IUnmarshaller<CreateConnectionResult, XmlUnmarshallerContext>, IUnmarshaller<CreateConnectionResult, JsonUnmarshallerContext>
      {
        CreateConnectionResult IUnmarshaller<CreateConnectionResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CreateConnectionResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            CreateConnectionResult createConnectionResult = new CreateConnectionResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("OwnerAccount", targetDepth))
              {
                createConnectionResult.OwnerAccount = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionId", targetDepth))
              {
                createConnectionResult.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionName", targetDepth))
              {
                createConnectionResult.ConnectionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ConnectionState", targetDepth))
              {
                createConnectionResult.ConnectionState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                createConnectionResult.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Location", targetDepth))
              {
                createConnectionResult.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Bandwidth", targetDepth))
              {
                createConnectionResult.Bandwidth = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Vlan", targetDepth))
              {
                createConnectionResult.Vlan = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("PartnerName", targetDepth))
              {
                createConnectionResult.PartnerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return createConnectionResult;
                }
            }
          

            return createConnectionResult;
        }

        private static CreateConnectionResultUnmarshaller instance;
        public static CreateConnectionResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CreateConnectionResultUnmarshaller();
            return instance;
        }
    }
}
  
