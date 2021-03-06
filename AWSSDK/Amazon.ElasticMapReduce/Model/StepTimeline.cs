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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The timeline of the cluster step lifecycle.
    /// </summary>
    public partial class StepTimeline
    {
        private DateTime? _creationDateTime;
        private DateTime? _endDateTime;
        private DateTime? _startDateTime;


        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the cluster step was created.      
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }


        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StepTimeline WithCreationDateTime(DateTime creationDateTime)
        {
            this._creationDateTime = creationDateTime;
            return this;
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time when the cluster step execution completed or failed.      
        /// </para>
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }


        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">The value to set for the EndDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StepTimeline WithEndDateTime(DateTime endDateTime)
        {
            this._endDateTime = endDateTime;
            return this;
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time when the cluster step execution started.      
        /// </para>
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }


        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">The value to set for the StartDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StepTimeline WithStartDateTime(DateTime startDateTime)
        {
            this._startDateTime = startDateTime;
            return this;
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

    }
}