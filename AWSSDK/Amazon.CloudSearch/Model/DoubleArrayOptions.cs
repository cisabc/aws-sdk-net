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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>Options for a field that contains an array of double-precision 64-bit floating point values. Present if <c>IndexFieldType</c>
    /// specifies the field is of type <c>double-array</c> . All options are enabled by default.</para>
    /// </summary>
    public partial class DoubleArrayOptions
    {
        
        private double? defaultValue;
        private string sourceFields;
        private bool? facetEnabled;
        private bool? searchEnabled;
        private bool? returnEnabled;

        /// <summary>
        /// A value to use for the field if the field isn't specified for a document.
        ///  
        /// </summary>
        public double DefaultValue
        {
            get { return this.defaultValue ?? default(double); }
            set { this.defaultValue = value; }
        }

        /// <summary>
        /// Sets the DefaultValue property
        /// </summary>
        /// <param name="defaultValue">The value to set for the DefaultValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DoubleArrayOptions WithDefaultValue(double defaultValue)
        {
            this.defaultValue = defaultValue;
            return this;
        }
            

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this.defaultValue.HasValue;
        }

        /// <summary>
        /// A list of source fields to map to the field.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>\s*[a-z][a-z0-9_]*\s*(,\s*[a-z][a-z0-9_]*\s*)*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SourceFields
        {
            get { return this.sourceFields; }
            set { this.sourceFields = value; }
        }

        /// <summary>
        /// Sets the SourceFields property
        /// </summary>
        /// <param name="sourceFields">The value to set for the SourceFields property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DoubleArrayOptions WithSourceFields(string sourceFields)
        {
            this.sourceFields = sourceFields;
            return this;
        }
            

        // Check to see if SourceFields property is set
        internal bool IsSetSourceFields()
        {
            return this.sourceFields != null;
        }

        /// <summary>
        /// Whether facet information can be returned for the field.
        ///  
        /// </summary>
        public bool FacetEnabled
        {
            get { return this.facetEnabled ?? default(bool); }
            set { this.facetEnabled = value; }
        }

        /// <summary>
        /// Sets the FacetEnabled property
        /// </summary>
        /// <param name="facetEnabled">The value to set for the FacetEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DoubleArrayOptions WithFacetEnabled(bool facetEnabled)
        {
            this.facetEnabled = facetEnabled;
            return this;
        }
            

        // Check to see if FacetEnabled property is set
        internal bool IsSetFacetEnabled()
        {
            return this.facetEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field are searchable.
        ///  
        /// </summary>
        public bool SearchEnabled
        {
            get { return this.searchEnabled ?? default(bool); }
            set { this.searchEnabled = value; }
        }

        /// <summary>
        /// Sets the SearchEnabled property
        /// </summary>
        /// <param name="searchEnabled">The value to set for the SearchEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DoubleArrayOptions WithSearchEnabled(bool searchEnabled)
        {
            this.searchEnabled = searchEnabled;
            return this;
        }
            

        // Check to see if SearchEnabled property is set
        internal bool IsSetSearchEnabled()
        {
            return this.searchEnabled.HasValue;
        }

        /// <summary>
        /// Whether the contents of the field can be returned in the search results.
        ///  
        /// </summary>
        public bool ReturnEnabled
        {
            get { return this.returnEnabled ?? default(bool); }
            set { this.returnEnabled = value; }
        }

        /// <summary>
        /// Sets the ReturnEnabled property
        /// </summary>
        /// <param name="returnEnabled">The value to set for the ReturnEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DoubleArrayOptions WithReturnEnabled(bool returnEnabled)
        {
            this.returnEnabled = returnEnabled;
            return this;
        }
            

        // Check to see if ReturnEnabled property is set
        internal bool IsSetReturnEnabled()
        {
            return this.returnEnabled.HasValue;
        }
    }
}
