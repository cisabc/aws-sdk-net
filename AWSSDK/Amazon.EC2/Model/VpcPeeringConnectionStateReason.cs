/*******************************************************************************
 * Copyright 2008-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the status of a VPC peering connection.</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpcPeeringConnectionStateReason
    {
        private string codeField;
        private string messageField;

        /// <summary>
        /// The status of the VPC peering connection.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }
        
        /// <summary>
        /// Sets the Code
        /// <param name="code">The Code.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnectionStateReason WithCode(string code)
        {
            this.codeField = code;
            return this;
        }
        
        /// <summary>
        /// Checks if Code is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }

        /// <summary>
        /// A message that provides more information about the status, if applicable.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }
        
        /// <summary>
        /// Sets the Message
        /// <param name="message">The Message.</param>
        /// </summary>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpcPeeringConnectionStateReason WithMessage(string message)
        {
            this.messageField = message;
            return this;
        }
        
        /// <summary>
        /// Checks if Message is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }
        
    }
}
