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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterElasticIp operation.
    /// Deregisters a specified Elastic IP address. The address can then be registered by
    /// another stack.  For more information, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html">Resource
    /// Management</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DeregisterElasticIpRequest : AmazonWebServiceRequest
    {
        private string _elasticIp;


        /// <summary>
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string ElasticIp
        {
            get { return this._elasticIp; }
            set { this._elasticIp = value; }
        }


        /// <summary>
        /// Sets the ElasticIp property
        /// </summary>
        /// <param name="elasticIp">The value to set for the ElasticIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeregisterElasticIpRequest WithElasticIp(string elasticIp)
        {
            this._elasticIp = elasticIp;
            return this;
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this._elasticIp != null;
        }

    }
}