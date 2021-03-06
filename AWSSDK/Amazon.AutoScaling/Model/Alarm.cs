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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The Alarm data type.
    /// </summary>
    public partial class Alarm
    {
        private string _alarmARN;
        private string _alarmName;


        /// <summary>
        /// Gets and sets the property AlarmARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm.
        /// </para>
        /// </summary>
        public string AlarmARN
        {
            get { return this._alarmARN; }
            set { this._alarmARN = value; }
        }


        /// <summary>
        /// Sets the AlarmARN property
        /// </summary>
        /// <param name="alarmARN">The value to set for the AlarmARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Alarm WithAlarmARN(string alarmARN)
        {
            this._alarmARN = alarmARN;
            return this;
        }

        // Check to see if AlarmARN property is set
        internal bool IsSetAlarmARN()
        {
            return this._alarmARN != null;
        }


        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }


        /// <summary>
        /// Sets the AlarmName property
        /// </summary>
        /// <param name="alarmName">The value to set for the AlarmName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Alarm WithAlarmName(string alarmName)
        {
            this._alarmName = alarmName;
            return this;
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

    }
}