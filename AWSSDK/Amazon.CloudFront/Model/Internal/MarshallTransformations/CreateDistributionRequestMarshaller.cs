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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDistribution Request Marshaller
    /// </summary>       
    public class CreateDistributionRequestMarshaller : IMarshaller<IRequest, CreateDistributionRequest> 
    {
        public IRequest Marshall(CreateDistributionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            var uriResourcePath = "/2014-05-31/distribution";

            request.ResourcePath = uriResourcePath;

            
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter);
            xmlWriter.Namespaces = true;

            using (xmlWriter)
            {   
                xmlWriter.WriteStartElement("DistributionConfig", "http://cloudfront.amazonaws.com/doc/2014-05-31/");                                
                
                if (publicRequest.DistributionConfig.Aliases != null) 
                {
                    xmlWriter.WriteStartElement("Aliases", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    var publicRequestDistributionConfigAliasesItems = publicRequest.DistributionConfig.Aliases.Items;
                    if (publicRequestDistributionConfigAliasesItems != null && publicRequestDistributionConfigAliasesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                        foreach (var publicRequestDistributionConfigAliasesItemsValue in publicRequestDistributionConfigAliasesItems) 
                        {
                            xmlWriter.WriteStartElement("CNAME", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                            xmlWriter.WriteValue(publicRequestDistributionConfigAliasesItemsValue);
                            xmlWriter.WriteEndElement();
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.Aliases.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Aliases.Quantity.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.CacheBehaviors != null) 
                {
                    xmlWriter.WriteStartElement("CacheBehaviors", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    var publicRequestDistributionConfigCacheBehaviorsItems = publicRequest.DistributionConfig.CacheBehaviors.Items;
                    if (publicRequestDistributionConfigCacheBehaviorsItems != null && publicRequestDistributionConfigCacheBehaviorsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValue in publicRequestDistributionConfigCacheBehaviorsItems) 
                        {
                        
                        if (publicRequestDistributionConfigCacheBehaviorsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("CacheBehavior", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods != null) 
                            {
                                xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Items;
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                    foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItems) 
                                    {
                                        xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueAllowedMethodsItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.AllowedMethods.Quantity.ToString());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues != null) 
                            {
                                xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies != null) 
                                {
                                    xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.IsSetForward())
                                        xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.Forward.ToString());                 
                    
                                    
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames != null) 
                                    {
                                        xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                        var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Items;
                                        if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                        {                        
                                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                            foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItems) 
                                            {
                                                xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                                xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesCookiesWhitelistedNamesItemsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Cookies.WhitelistedNames.Quantity.ToString());                 
                        
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers != null) 
                                {
                                    xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                    var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Items;
                                    if (publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems.Count > 0) 
                                    {                        
                                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                        foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItems) 
                                        {
                                            xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                            xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueForwardedValuesHeadersItemsValue);
                                            xmlWriter.WriteEndElement();
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.IsSetQuantity())
                                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.Headers.Quantity.ToString());                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.IsSetQueryString())
                                    xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.ForwardedValues.QueryString.ToString().ToLower());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetMinTTL())
                                xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.MinTTL.ToString());                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetPathPattern())
                                xmlWriter.WriteElementString("PathPattern", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.PathPattern.ToString());                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetSmoothStreaming())
                                xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.SmoothStreaming.ToString().ToLower());                 
            
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetTargetOriginId())
                                xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.TargetOriginId.ToString());                 
            
                            
                            if (publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners != null) 
                            {
                                xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetEnabled())
                                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Enabled.ToString().ToLower());                 
                
                                var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems = publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Items;
                                if (publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems != null && publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                    foreach (var publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue in publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItems) 
                                    {
                                        xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigCacheBehaviorsItemsValueTrustedSignersItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.TrustedSigners.Quantity.ToString());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigCacheBehaviorsItemsValue.IsSetViewerProtocolPolicy())
                                xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCacheBehaviorsItemsValue.ViewerProtocolPolicy.ToString());                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.CacheBehaviors.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.CacheBehaviors.Quantity.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetCallerReference())
                    xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.CallerReference.ToString());                    

                if(publicRequest.DistributionConfig.IsSetComment())
                    xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Comment.ToString());                    

                
                if (publicRequest.DistributionConfig.CustomErrorResponses != null) 
                {
                    xmlWriter.WriteStartElement("CustomErrorResponses", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    var publicRequestDistributionConfigCustomErrorResponsesItems = publicRequest.DistributionConfig.CustomErrorResponses.Items;
                    if (publicRequestDistributionConfigCustomErrorResponsesItems != null && publicRequestDistributionConfigCustomErrorResponsesItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                        foreach (var publicRequestDistributionConfigCustomErrorResponsesItemsValue in publicRequestDistributionConfigCustomErrorResponsesItems) 
                        {
                        
                        if (publicRequestDistributionConfigCustomErrorResponsesItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("CustomErrorResponse", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCachingMinTTL())
                                xmlWriter.WriteElementString("ErrorCachingMinTTL", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCachingMinTTL.ToString());                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetErrorCode())
                                xmlWriter.WriteElementString("ErrorCode", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCustomErrorResponsesItemsValue.ErrorCode.ToString());                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponseCode())
                                xmlWriter.WriteElementString("ResponseCode", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponseCode.ToString());                 
            
                            if(publicRequestDistributionConfigCustomErrorResponsesItemsValue.IsSetResponsePagePath())
                                xmlWriter.WriteElementString("ResponsePagePath", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigCustomErrorResponsesItemsValue.ResponsePagePath.ToString());                 
            
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.CustomErrorResponses.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.CustomErrorResponses.Quantity.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.DefaultCacheBehavior != null) 
                {
                    xmlWriter.WriteStartElement("DefaultCacheBehavior", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods != null) 
                    {
                        xmlWriter.WriteStartElement("AllowedMethods", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                        var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems = publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Items;
                        if (publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems != null && publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                            foreach (var publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItems) 
                            {
                                xmlWriter.WriteStartElement("Method", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorAllowedMethodsItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.AllowedMethods.Quantity.ToString());                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues != null) 
                    {
                        xmlWriter.WriteStartElement("ForwardedValues", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies != null) 
                        {
                            xmlWriter.WriteStartElement("Cookies", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.IsSetForward())
                                xmlWriter.WriteElementString("Forward", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.Forward.ToString());                 
            
                            
                            if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames != null) 
                            {
                                xmlWriter.WriteStartElement("WhitelistedNames", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Items;
                                if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems.Count > 0) 
                                {                        
                                    xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                    foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItems) 
                                    {
                                        xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                        xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesCookiesWhitelistedNamesItemsValue);
                                        xmlWriter.WriteEndElement();
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.IsSetQuantity())
                                    xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Cookies.WhitelistedNames.Quantity.ToString());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        
                        if (publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers != null) 
                        {
                            xmlWriter.WriteStartElement("Headers", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                            var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Items;
                            if (publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                foreach (var publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItems) 
                                {
                                    xmlWriter.WriteStartElement("Name", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                    xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorForwardedValuesHeadersItemsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.Headers.Quantity.ToString());                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.IsSetQueryString())
                            xmlWriter.WriteElementString("QueryString", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.ForwardedValues.QueryString.ToString().ToLower());                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetMinTTL())
                        xmlWriter.WriteElementString("MinTTL", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.MinTTL.ToString());                 
    
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetSmoothStreaming())
                        xmlWriter.WriteElementString("SmoothStreaming", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.SmoothStreaming.ToString().ToLower());                 
    
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetTargetOriginId())
                        xmlWriter.WriteElementString("TargetOriginId", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.TargetOriginId.ToString());                 
    
                    
                    if (publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners != null) 
                    {
                        xmlWriter.WriteStartElement("TrustedSigners", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetEnabled())
                            xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Enabled.ToString().ToLower());                 
        
                        var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems = publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Items;
                        if (publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems != null && publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                            foreach (var publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue in publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItems) 
                            {
                                xmlWriter.WriteStartElement("AwsAccountNumber", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigDefaultCacheBehaviorTrustedSignersItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.TrustedSigners.Quantity.ToString());                 
        
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.DistributionConfig.DefaultCacheBehavior.IsSetViewerProtocolPolicy())
                        xmlWriter.WriteElementString("ViewerProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultCacheBehavior.ViewerProtocolPolicy.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetDefaultRootObject())
                    xmlWriter.WriteElementString("DefaultRootObject", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.DefaultRootObject.ToString());                    

                if(publicRequest.DistributionConfig.IsSetEnabled())
                    xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Enabled.ToString().ToLower());                    

                
                if (publicRequest.DistributionConfig.Logging != null) 
                {
                    xmlWriter.WriteStartElement("Logging", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    if(publicRequest.DistributionConfig.Logging.IsSetBucket())
                        xmlWriter.WriteElementString("Bucket", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Logging.Bucket.ToString());                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Logging.Enabled.ToString().ToLower());                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetIncludeCookies())
                        xmlWriter.WriteElementString("IncludeCookies", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Logging.IncludeCookies.ToString().ToLower());                 
    
                    if(publicRequest.DistributionConfig.Logging.IsSetPrefix())
                        xmlWriter.WriteElementString("Prefix", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Logging.Prefix.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.Origins != null) 
                {
                    xmlWriter.WriteStartElement("Origins", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    var publicRequestDistributionConfigOriginsItems = publicRequest.DistributionConfig.Origins.Items;
                    if (publicRequestDistributionConfigOriginsItems != null && publicRequestDistributionConfigOriginsItems.Count > 0) 
                    {                        
                        xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                        foreach (var publicRequestDistributionConfigOriginsItemsValue in publicRequestDistributionConfigOriginsItems) 
                        {
                        
                        if (publicRequestDistributionConfigOriginsItemsValue != null) 
                        {
                            xmlWriter.WriteStartElement("Origin", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                            
                            if (publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig != null) 
                            {
                                xmlWriter.WriteStartElement("CustomOriginConfig", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPPort())
                                    xmlWriter.WriteElementString("HTTPPort", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPPort.ToString());                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetHTTPSPort())
                                    xmlWriter.WriteElementString("HTTPSPort", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.HTTPSPort.ToString());                 
                
                                if(publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.IsSetOriginProtocolPolicy())
                                    xmlWriter.WriteElementString("OriginProtocolPolicy", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.CustomOriginConfig.OriginProtocolPolicy.ToString());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestDistributionConfigOriginsItemsValue.IsSetDomainName())
                                xmlWriter.WriteElementString("DomainName", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.DomainName.ToString());                 
            
                            if(publicRequestDistributionConfigOriginsItemsValue.IsSetId())
                                xmlWriter.WriteElementString("Id", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.Id.ToString());                 
            
                            
                            if (publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig != null) 
                            {
                                xmlWriter.WriteStartElement("S3OriginConfig", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                                if(publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.IsSetOriginAccessIdentity())
                                    xmlWriter.WriteElementString("OriginAccessIdentity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequestDistributionConfigOriginsItemsValue.S3OriginConfig.OriginAccessIdentity.ToString());                 
                
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        }            
                        xmlWriter.WriteEndElement();            
                    }
                    if(publicRequest.DistributionConfig.Origins.IsSetQuantity())
                        xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Origins.Quantity.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.DistributionConfig.IsSetPriceClass())
                    xmlWriter.WriteElementString("PriceClass", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.PriceClass.ToString());                    

                
                if (publicRequest.DistributionConfig.Restrictions != null) 
                {
                    xmlWriter.WriteStartElement("Restrictions", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    
                    if (publicRequest.DistributionConfig.Restrictions.GeoRestriction != null) 
                    {
                        xmlWriter.WriteStartElement("GeoRestriction", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                        var publicRequestDistributionConfigRestrictionsGeoRestrictionItems = publicRequest.DistributionConfig.Restrictions.GeoRestriction.Items;
                        if (publicRequestDistributionConfigRestrictionsGeoRestrictionItems != null && publicRequestDistributionConfigRestrictionsGeoRestrictionItems.Count > 0) 
                        {                        
                            xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                            foreach (var publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue in publicRequestDistributionConfigRestrictionsGeoRestrictionItems) 
                            {
                                xmlWriter.WriteStartElement("Location", "http://cloudfront.amazonaws.com/doc/2014-05-31/");
                                xmlWriter.WriteValue(publicRequestDistributionConfigRestrictionsGeoRestrictionItemsValue);
                                xmlWriter.WriteEndElement();
                            }            
                            xmlWriter.WriteEndElement();            
                        }
                        if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetQuantity())
                            xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Restrictions.GeoRestriction.Quantity.ToString());                 
        
                        if(publicRequest.DistributionConfig.Restrictions.GeoRestriction.IsSetRestrictionType())
                            xmlWriter.WriteElementString("RestrictionType", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.Restrictions.GeoRestriction.RestrictionType.ToString());                 
        
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                
                if (publicRequest.DistributionConfig.ViewerCertificate != null) 
                {
                    xmlWriter.WriteStartElement("ViewerCertificate", "http://cloudfront.amazonaws.com/doc/2014-05-31/");            
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetCloudFrontDefaultCertificate())
                        xmlWriter.WriteElementString("CloudFrontDefaultCertificate", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.ViewerCertificate.CloudFrontDefaultCertificate.ToString().ToLower());                 
    
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetIAMCertificateId())
                        xmlWriter.WriteElementString("IAMCertificateId", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.ViewerCertificate.IAMCertificateId.ToString());                 
    
                    if(publicRequest.DistributionConfig.ViewerCertificate.IsSetSSLSupportMethod())
                        xmlWriter.WriteElementString("SSLSupportMethod", "http://cloudfront.amazonaws.com/doc/2014-05-31/", publicRequest.DistributionConfig.ViewerCertificate.SSLSupportMethod.ToString());                 
    
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }

        
    }    
}