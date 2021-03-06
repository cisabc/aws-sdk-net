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
    /// Describes the properties of an application.
    /// </summary>
    public partial class ApplicationDescription
    {
        private string _applicationName;
        private List<string> _configurationTemplates = new List<string>();
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _description;
        private List<string> _versions = new List<string>();


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
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
        public ApplicationDescription WithApplicationName(string applicationName)
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
        /// Gets and sets the property ConfigurationTemplates. 
        /// <para>
        ///          The names of the configuration templates associated with this         application.    
        ///  
        /// </para>
        /// </summary>
        public List<string> ConfigurationTemplates
        {
            get { return this._configurationTemplates; }
            set { this._configurationTemplates = value; }
        }

        /// <summary>
        /// Sets the ConfigurationTemplates property
        /// </summary>
        /// <param name="configurationTemplates">The values to add to the ConfigurationTemplates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithConfigurationTemplates(params string[] configurationTemplates)
        {
            foreach (var element in configurationTemplates)
            {
                this._configurationTemplates.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ConfigurationTemplates property
        /// </summary>
        /// <param name="configurationTemplates">The values to add to the ConfigurationTemplates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithConfigurationTemplates(IEnumerable<string> configurationTemplates)
        {
            foreach (var element in configurationTemplates)
            {
                this._configurationTemplates.Add(element);
            }
            return this;
        }
        // Check to see if ConfigurationTemplates property is set
        internal bool IsSetConfigurationTemplates()
        {
            return this._configurationTemplates != null && this._configurationTemplates.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the application was created.
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }


        /// <summary>
        /// Sets the DateCreated property
        /// </summary>
        /// <param name="dateCreated">The value to set for the DateCreated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithDateCreated(DateTime dateCreated)
        {
            this._dateCreated = dateCreated;
            return this;
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when the application was last modified.
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
            set { this._dateUpdated = value; }
        }


        /// <summary>
        /// Sets the DateUpdated property
        /// </summary>
        /// <param name="dateUpdated">The value to set for the DateUpdated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithDateUpdated(DateTime dateUpdated)
        {
            this._dateUpdated = dateUpdated;
            return this;
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User-defined description of the application.
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
        public ApplicationDescription WithDescription(string description)
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
        /// Gets and sets the property Versions. 
        /// <para>
        /// The names of the versions for this application.
        /// </para>
        /// </summary>
        public List<string> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        /// <summary>
        /// Sets the Versions property
        /// </summary>
        /// <param name="versions">The values to add to the Versions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithVersions(params string[] versions)
        {
            foreach (var element in versions)
            {
                this._versions.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Versions property
        /// </summary>
        /// <param name="versions">The values to add to the Versions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ApplicationDescription WithVersions(IEnumerable<string> versions)
        {
            foreach (var element in versions)
            {
                this._versions.Add(element);
            }
            return this;
        }
        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && this._versions.Count > 0; 
        }

    }
}