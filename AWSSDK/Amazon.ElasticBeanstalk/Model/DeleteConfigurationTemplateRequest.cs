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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConfigurationTemplate operation.
    /// Deletes the specified configuration template.
    /// 
    ///       <note>When you launch an environment using a configuration template, the   
    ///      environment         gets a copy of the template. You can delete or modify the
    /// environment's copy of         the template without         affecting the running environment.</note>
    /// </summary>
    public partial class DeleteConfigurationTemplateRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private string _templateName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application to delete the configuration         template
        /// from.      
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteConfigurationTemplateRequest WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to delete.
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }


        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteConfigurationTemplateRequest WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return this;
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}