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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHostedZone operation.
    /// <para>This action deletes a hosted zone. To delete a hosted zone, send a <c>DELETE</c> request to the <c>2013-04-01/hostedzone/hosted zone
    /// ID </c> resource.</para> <para>For more information about deleting a hosted zone, see <a
    /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html" >Deleting a Hosted Zone</a> in the <i>Amazon Route 53
    /// Developer Guide</i> .</para> <para><b>IMPORTANT:</b> You can delete a hosted zone only if there are no resource record sets other than the
    /// default SOA record and NS resource record sets. If your hosted zone contains other resource record sets, you must delete them before you can
    /// delete your hosted zone. If you try to delete a hosted zone that contains other resource record sets, Route 53 will deny your request with a
    /// HostedZoneNotEmpty error. For information about deleting records from your hosted zone, see ChangeResourceRecordSets.</para>
    /// </summary>
    /// <seealso cref="Amazon.Route53.AmazonRoute53.DeleteHostedZone"/>
    public class DeleteHostedZoneRequest : AmazonWebServiceRequest
    {
        private string id;

        /// <summary>
        /// The ID of the request. Include this ID in a call to <a>GetChange</a> to track when the change has propagated to all Route 53 DNS servers.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteHostedZoneRequest WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }
    }
}
    
