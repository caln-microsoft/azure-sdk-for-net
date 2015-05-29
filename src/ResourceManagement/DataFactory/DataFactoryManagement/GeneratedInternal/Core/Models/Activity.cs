// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.DataFactories.Common.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Models
{
    /// <summary>
    /// A pipeline activity.
    /// </summary>
    public partial class Activity
    {
        private string _description;
        
        /// <summary>
        /// Optional. Activity description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IList<ActivityInput> _inputs;
        
        /// <summary>
        /// Optional. Inputs.
        /// </summary>
        public IList<ActivityInput> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }
        
        private string _linkedServiceName;
        
        /// <summary>
        /// Optional. LinkedService name where the Activity Runs.
        /// </summary>
        public string LinkedServiceName
        {
            get { return this._linkedServiceName; }
            set { this._linkedServiceName = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Activity name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<ActivityOutput> _outputs;
        
        /// <summary>
        /// Optional. Outputs.
        /// </summary>
        public IList<ActivityOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }
        
        private ActivityPolicy _policy;
        
        /// <summary>
        /// Optional. Policy.
        /// </summary>
        public ActivityPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The type of the activity. May be the name of a build-in
        /// ADF type or a type registered by a user and available to the data
        /// factory this pipeline/activity is a member of.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private string _typeProperties;
        
        /// <summary>
        /// Required. The properties specific to the activity type.
        /// </summary>
        public string TypeProperties
        {
            get { return this._typeProperties; }
            set { this._typeProperties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            this.Inputs = new LazyList<ActivityInput>();
            this.Outputs = new LazyList<ActivityOutput>();
        }
        
        /// <summary>
        /// Initializes a new instance of the Activity class with required
        /// arguments.
        /// </summary>
        public Activity(string name, string type, string typeProperties)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (typeProperties == null)
            {
                throw new ArgumentNullException("typeProperties");
            }
            this.Name = name;
            this.Type = type;
            this.TypeProperties = typeProperties;
        }
    }
}
