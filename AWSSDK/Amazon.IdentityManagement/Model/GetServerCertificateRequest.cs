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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetServerCertificate operation.
    /// Retrieves information about the specified server certificate.
    /// </summary>
    public partial class GetServerCertificateRequest : AmazonWebServiceRequest
    {
        private string _serverCertificateName;


        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name of the server certificate you want to retrieve information about.
        /// </para>
        /// </summary>
        public string ServerCertificateName
        {
            get { return this._serverCertificateName; }
            set { this._serverCertificateName = value; }
        }


        /// <summary>
        /// Sets the ServerCertificateName property
        /// </summary>
        /// <param name="serverCertificateName">The value to set for the ServerCertificateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetServerCertificateRequest WithServerCertificateName(string serverCertificateName)
        {
            this._serverCertificateName = serverCertificateName;
            return this;
        }

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this._serverCertificateName != null;
        }

    }
}