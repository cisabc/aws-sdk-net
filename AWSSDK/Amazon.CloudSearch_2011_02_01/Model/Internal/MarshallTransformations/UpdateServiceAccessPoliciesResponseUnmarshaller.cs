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
using System.Net;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for UpdateServiceAccessPolicies operation
    /// </summary>
    internal class UpdateServiceAccessPoliciesResponseUnmarshaller : XmlResponseUnmarshaller
    {

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            UpdateServiceAccessPoliciesResponse response = new UpdateServiceAccessPoliciesResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)                
                {
                    if(context.TestExpression("UpdateServiceAccessPoliciesResult", 2))
                    {
                        response.UpdateServiceAccessPoliciesResult = UpdateServiceAccessPoliciesResultUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }
                 
                        
            return response;
        }

        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("BaseException"))
            {
                return new BaseException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFound"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceeded"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalException"))
            {
                return new InternalException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidType"))
            {
                return new InvalidTypeException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonCloudSearchException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static UpdateServiceAccessPoliciesResponseUnmarshaller instance;

        public static UpdateServiceAccessPoliciesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new UpdateServiceAccessPoliciesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
