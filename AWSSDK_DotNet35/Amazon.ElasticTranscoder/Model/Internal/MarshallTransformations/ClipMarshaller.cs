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

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Clip Marshaller
    /// </summary>       
    public class ClipMarshaller : IRequestMarshaller<Clip, JsonMarshallerContext> 
    {
        public void Marshall(Clip requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetTimeSpan())
            {
                context.Writer.WritePropertyName("TimeSpan");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSpanMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSpan, context);

                context.Writer.WriteObjectEnd();
            }

        }

        public readonly static ClipMarshaller Instance = new ClipMarshaller();

    }
}