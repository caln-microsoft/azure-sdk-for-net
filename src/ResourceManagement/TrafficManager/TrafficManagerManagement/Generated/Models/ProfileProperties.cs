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
using Microsoft.Azure.Management.TrafficManager.Models;

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    /// <summary>
    /// Represents the properties of the zone.
    /// </summary>
    public partial class ProfileProperties
    {
        private DnsConfig _dnsConfig;
        
        /// <summary>
        /// Required. Gets or sets the dns config of the profile.
        /// </summary>
        public DnsConfig DnsConfig
        {
            get { return this._dnsConfig; }
            set { this._dnsConfig = value; }
        }
        
        private IList<Endpoint> _endpoints;
        
        /// <summary>
        /// Optional. Gets or sets the list of endpoints in a profile.
        /// </summary>
        public IList<Endpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }
        
        private MonitorConfig _monitorConfig;
        
        /// <summary>
        /// Required. Gets or sets the monitor config of the profile.
        /// </summary>
        public MonitorConfig MonitorConfig
        {
            get { return this._monitorConfig; }
            set { this._monitorConfig = value; }
        }
        
        private string _profileStatus;
        
        /// <summary>
        /// Optional. Gets or sets the status of the profile.
        /// </summary>
        public string ProfileStatus
        {
            get { return this._profileStatus; }
            set { this._profileStatus = value; }
        }
        
        private string _trafficRoutingMethod;
        
        /// <summary>
        /// Required. Gets or sets the load balancing method of the profile.
        /// </summary>
        public string TrafficRoutingMethod
        {
            get { return this._trafficRoutingMethod; }
            set { this._trafficRoutingMethod = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfileProperties class.
        /// </summary>
        public ProfileProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ProfileProperties class with
        /// required arguments.
        /// </summary>
        public ProfileProperties(string trafficRoutingMethod, DnsConfig dnsConfig, MonitorConfig monitorConfig)
            : this()
        {
            if (trafficRoutingMethod == null)
            {
                throw new ArgumentNullException("trafficRoutingMethod");
            }
            if (dnsConfig == null)
            {
                throw new ArgumentNullException("dnsConfig");
            }
            if (monitorConfig == null)
            {
                throw new ArgumentNullException("monitorConfig");
            }
            this.TrafficRoutingMethod = trafficRoutingMethod;
            this.DnsConfig = dnsConfig;
            this.MonitorConfig = monitorConfig;
        }
    }
}
