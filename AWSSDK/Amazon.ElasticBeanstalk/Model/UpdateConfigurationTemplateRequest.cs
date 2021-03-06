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
    /// Container for the parameters to the UpdateConfigurationTemplate operation.
    /// Updates the specified configuration template to have the specified      
    ///   properties or configuration option values.      
    /// 
    ///       <note>         If a property (for example,         <code>ApplicationName</code>)
    /// is not provided, its         value remains unchanged. To clear such         properties,
    /// specify an empty string.      </note>      
    /// <para>
    /// Related Topics
    /// </para>
    ///       <ul>         <li>            <a>DescribeConfigurationOptions</a>         </li>
    ///      </ul>
    /// </summary>
    public partial class UpdateConfigurationTemplateRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private string _description;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _templateName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with the configuration template         to
        /// update.
        /// </para>
        ///       
        /// <para>
        ///          If no application is found with this name, <code>UpdateConfigurationTemplate</code>
        /// returns an         <code>InvalidParameterValue</code>         error.      
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
        public UpdateConfigurationTemplateRequest WithApplicationName(string applicationName)
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the configuration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateRequest WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        ///          A list of configuration option settings to update with the new specified
        ///         option value.        
        /// </para>
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        /// <summary>
        /// Sets the OptionSettings property
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateRequest WithOptionSettings(params ConfigurationOptionSetting[] optionSettings)
        {
            foreach (var element in optionSettings)
            {
                this._optionSettings.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the OptionSettings property
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateRequest WithOptionSettings(IEnumerable<ConfigurationOptionSetting> optionSettings)
        {
            foreach (var element in optionSettings)
            {
                this._optionSettings.Add(element);
            }
            return this;
        }
        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && this._optionSettings.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        ///          A list of configuration options to remove from the configuration set.        
        /// </para>
        ///       
        /// <para>
        ///          Constraint: You can remove only <code>UserDefined</code>         configuration
        /// options.      
        /// </para>
        /// </summary>
        public List<OptionSpecification> OptionsToRemove
        {
            get { return this._optionsToRemove; }
            set { this._optionsToRemove = value; }
        }

        /// <summary>
        /// Sets the OptionsToRemove property
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateRequest WithOptionsToRemove(params OptionSpecification[] optionsToRemove)
        {
            foreach (var element in optionsToRemove)
            {
                this._optionsToRemove.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the OptionsToRemove property
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateRequest WithOptionsToRemove(IEnumerable<OptionSpecification> optionsToRemove)
        {
            foreach (var element in optionsToRemove)
            {
                this._optionsToRemove.Add(element);
            }
            return this;
        }
        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this._optionsToRemove != null && this._optionsToRemove.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the configuration template to update.
        /// </para>
        ///       
        /// <para>
        ///          If no configuration template is found with this name, <code>UpdateConfigurationTemplate</code>
        /// returns an         <code>InvalidParameterValue</code>         error.      
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
        public UpdateConfigurationTemplateRequest WithTemplateName(string templateName)
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