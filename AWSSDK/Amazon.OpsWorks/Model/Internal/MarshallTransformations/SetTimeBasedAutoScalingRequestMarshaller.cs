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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetTimeBasedAutoScaling Request Marshaller
    /// </summary>       
    public class SetTimeBasedAutoScalingRequestMarshaller : IMarshaller<IRequest, SetTimeBasedAutoScalingRequest> 
    {
        public IRequest Marshall(SetTimeBasedAutoScalingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.SetTimeBasedAutoScaling";
            request.Headers["X-Amz-Target"] = target;

            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest != null && publicRequest.IsSetAutoScalingSchedule())
                {
                    writer.WritePropertyName("AutoScalingSchedule");
                    writer.WriteObjectStart();
                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetFriday() && publicRequest.AutoScalingSchedule.Friday.Count > 0)
                    {
                        writer.WritePropertyName("Friday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleFridayKvp in publicRequest.AutoScalingSchedule.Friday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleFridayKvp.Key);
                            var publicRequestAutoScalingScheduleFridayValue = publicRequestAutoScalingScheduleFridayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleFridayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetMonday() && publicRequest.AutoScalingSchedule.Monday.Count > 0)
                    {
                        writer.WritePropertyName("Monday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleMondayKvp in publicRequest.AutoScalingSchedule.Monday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleMondayKvp.Key);
                            var publicRequestAutoScalingScheduleMondayValue = publicRequestAutoScalingScheduleMondayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleMondayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetSaturday() && publicRequest.AutoScalingSchedule.Saturday.Count > 0)
                    {
                        writer.WritePropertyName("Saturday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleSaturdayKvp in publicRequest.AutoScalingSchedule.Saturday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleSaturdayKvp.Key);
                            var publicRequestAutoScalingScheduleSaturdayValue = publicRequestAutoScalingScheduleSaturdayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleSaturdayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetSunday() && publicRequest.AutoScalingSchedule.Sunday.Count > 0)
                    {
                        writer.WritePropertyName("Sunday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleSundayKvp in publicRequest.AutoScalingSchedule.Sunday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleSundayKvp.Key);
                            var publicRequestAutoScalingScheduleSundayValue = publicRequestAutoScalingScheduleSundayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleSundayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetThursday() && publicRequest.AutoScalingSchedule.Thursday.Count > 0)
                    {
                        writer.WritePropertyName("Thursday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleThursdayKvp in publicRequest.AutoScalingSchedule.Thursday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleThursdayKvp.Key);
                            var publicRequestAutoScalingScheduleThursdayValue = publicRequestAutoScalingScheduleThursdayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleThursdayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetTuesday() && publicRequest.AutoScalingSchedule.Tuesday.Count > 0)
                    {
                        writer.WritePropertyName("Tuesday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleTuesdayKvp in publicRequest.AutoScalingSchedule.Tuesday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleTuesdayKvp.Key);
                            var publicRequestAutoScalingScheduleTuesdayValue = publicRequestAutoScalingScheduleTuesdayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleTuesdayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    if(publicRequest.AutoScalingSchedule != null && publicRequest.AutoScalingSchedule.IsSetWednesday() && publicRequest.AutoScalingSchedule.Wednesday.Count > 0)
                    {
                        writer.WritePropertyName("Wednesday");
                        writer.WriteObjectStart();
                        foreach (var publicRequestAutoScalingScheduleWednesdayKvp in publicRequest.AutoScalingSchedule.Wednesday)
                        {
                            writer.WritePropertyName(publicRequestAutoScalingScheduleWednesdayKvp.Key);
                            var publicRequestAutoScalingScheduleWednesdayValue = publicRequestAutoScalingScheduleWednesdayKvp.Value;

                            writer.Write(publicRequestAutoScalingScheduleWednesdayValue);
                        }
                        writer.WriteObjectEnd();
                    }

                    writer.WriteObjectEnd();
                }

                if(publicRequest != null && publicRequest.IsSetInstanceId())
                {
                    writer.WritePropertyName("InstanceId");
                    writer.Write(publicRequest.InstanceId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            return request;
        }


    }
}