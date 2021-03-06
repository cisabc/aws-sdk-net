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
    /// A specification identifying an individual configuration option along with
    /// its         current value. For a list of possible option values, go to <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/command-options.html">Option
    /// Values</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
    /// </summary>
    public partial class ConfigurationOptionSetting
    {
        private string _namespace;
        private string _optionName;
        private string _value;


        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        ///          A unique namespace identifying the option's associated AWS resource.        
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }


        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="ns">The value to set for the Namespace property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionSetting WithNamespace(string ns)
        {
            this._namespace = ns;
            return this;
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._namespace != null;
        }


        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        ///          The name of the configuration option.         
        /// </para>
        /// </summary>
        public string OptionName
        {
            get { return this._optionName; }
            set { this._optionName = value; }
        }


        /// <summary>
        /// Sets the OptionName property
        /// </summary>
        /// <param name="optionName">The value to set for the OptionName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionSetting WithOptionName(string optionName)
        {
            this._optionName = optionName;
            return this;
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this._optionName != null;
        }


        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///          The current value for the configuration option.        
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }


        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value to set for the Value property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationOptionSetting WithValue(string value)
        {
            this._value = value;
            return this;
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}