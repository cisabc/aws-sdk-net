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
    /// Container for the parameters to the ModifyClusterParameterGroup operation.
    /// Modifies the parameters of a parameter group.         
    /// 
    ///         
    /// <para>
    /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyClusterParameterGroupRequest : AmazonWebServiceRequest
    {
        private string _parameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();


        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        ///         The name of the parameter group to be modified.        
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterParameterGroupRequest WithParameterGroupName(string parameterGroupName)
        {
            this._parameterGroupName = parameterGroupName;
            return this;
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///             An array of parameters to be modified.              A maximum of 20 parameters
        /// can be modified in a single request.        
        /// </para>
        ///         
        /// <para>
        ///             For each parameter to be modified, you must supply at least the parameter
        /// name        and parameter value; other name-value pairs of the parameter are optional.
        ///        
        /// </para>
        ///         
        /// <para>
        ///             For the workload management (WLM) configuration,             you must
        /// supply all the name-value pairs in the wlm_json_configuration parameter.        
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        /// <summary>
        /// Sets the Parameters property
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterParameterGroupRequest WithParameters(params Parameter[] parameters)
        {
            foreach (var element in parameters)
            {
                this._parameters.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Parameters property
        /// </summary>
        /// <param name="parameters">The values to add to the Parameters collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterParameterGroupRequest WithParameters(IEnumerable<Parameter> parameters)
        {
            foreach (var element in parameters)
            {
                this._parameters.Add(element);
            }
            return this;
        }
        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}