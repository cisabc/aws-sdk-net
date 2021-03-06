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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEvents operation.
    /// Returns events related to clusters, security groups, snapshots, and parameter
    ///        groups for the past 14 days. Events specific to a particular cluster, security
    /// group,        snapshot or parameter group can be obtained by providing the name as
    /// a parameter.        By default, the past hour of events are returned.
    /// </summary>
    public partial class DescribeEventsRequest : AmazonWebServiceRequest
    {
        private int? _duration;
        private DateTime? _endTime;
        private string _marker;
        private int? _maxRecords;
        private string _sourceIdentifier;
        private string _sourceType;
        private DateTime? _startTime;


        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///             The number of minutes prior to the time of the request for which to retrieve
        /// events.         For example, if the request is sent at 18:00 and you specify a duration
        /// of 60,        then only events which have occurred after 17:00 will be returned. 
        ///       
        /// </para>
        ///         
        /// <para>
        /// Default: <code>60</code>
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }


        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithDuration(int duration)
        {
            this._duration = duration;
            return this;
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///         The end of the time interval for which to retrieve events,        specified
        /// in ISO 8601 format. For more information about ISO 8601,         go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a>        
        /// </para>
        ///         
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code>
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }


        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The value to set for the EndTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithEndTime(DateTime endTime)
        {
            this._endTime = endTime;
            return this;
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///             An optional parameter that specifies the starting point to return a set
        /// of response records.             When the results of a <a>DescribeEvents</a> request
        /// exceed the value specified in <code>MaxRecords</code>,             AWS returns a value
        /// in the <code>Marker</code> field of the response. You can retrieve the next set of
        ///             response records by providing the returned marker value in the <code>Marker</code>
        /// parameter and             retrying the request.        
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///             The maximum number of response records to return in each call.       
        ///      If the number of remaining response records exceeds the specified <code>MaxRecords</code>
        /// value,             a value is returned in a <code>marker</code> field of the response.
        ///             You can retrieve the next set of records by retrying the command with
        /// the returned marker value.        
        /// </para>
        ///         
        /// <para>
        /// Default: <code>100</code>
        /// </para>
        ///         
        /// <para>
        /// Constraints: minimum 20, maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }


        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithMaxRecords(int maxRecords)
        {
            this._maxRecords = maxRecords;
            return this;
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        ///         The identifier of the event source for which events        will be returned.
        /// If this parameter is not specified,        then all sources are included in the response.
        ///        
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        ///         
        /// <para>
        /// If <i>SourceIdentifier</i> is supplied, <i>SourceType</i> must also be provided.
        /// </para>
        ///         <ul>            <li>Specify a cluster identifier when <i>SourceType</i> is
        /// <code>cluster</code>.</li>            <li>Specify a cluster security group name when
        /// <i>SourceType</i> is <code>cluster-security-group</code>.</li>            <li>Specify
        /// a cluster parameter group name when <i>SourceType</i> is <code>cluster-parameter-group</code>.</li>
        ///            <li>Specify a cluster snapshot identifier when <i>SourceType</i> is <code>cluster-snapshot</code>.</li>
        ///        </ul>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }


        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The value to set for the SourceIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithSourceIdentifier(string sourceIdentifier)
        {
            this._sourceIdentifier = sourceIdentifier;
            return this;
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        ///         The event source to retrieve events for.        If no value is specified,
        /// all events are returned.        
        /// </para>
        ///         
        /// <para>
        /// Constraints:
        /// </para>
        ///         
        /// <para>
        /// If <i>SourceType</i> is supplied, <i>SourceIdentifier</i> must also be provided.
        /// </para>
        ///         <ul>            <li>Specify <code>cluster</code> when <i>SourceIdentifier</i>
        /// is a cluster identifier.</li>            <li>Specify <code>cluster-security-group</code>
        /// when <i>SourceIdentifier</i> is a cluster security group name.</li>            <li>Specify
        /// <code>cluster-parameter-group</code> when <i>SourceIdentifier</i> is a cluster parameter
        /// group name.</li>            <li>Specify <code>cluster-snapshot</code> when <i>SourceIdentifier</i>
        /// is a cluster snapshot identifier.</li>        </ul>
        /// </summary>
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }


        /// <summary>
        /// Sets the SourceType property
        /// </summary>
        /// <param name="sourceType">The value to set for the SourceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithSourceType(string sourceType)
        {
            this._sourceType = sourceType;
            return this;
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }


        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///         The beginning of the time interval to retrieve events for,        specified
        /// in ISO 8601 format. For more information about ISO 8601,         go to the <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO8601
        /// Wikipedia page.</a>        
        /// </para>
        ///         
        /// <para>
        /// Example: <code>2009-07-08T18:00Z</code>
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }


        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventsRequest WithStartTime(DateTime startTime)
        {
            this._startTime = startTime;
            return this;
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}