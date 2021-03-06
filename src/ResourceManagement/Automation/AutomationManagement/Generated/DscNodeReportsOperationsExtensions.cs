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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class DscNodeReportsOperationsExtensions
    {
        /// <summary>
        /// Retrieve the Dsc node report data by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='nodeId'>
        /// Required. The Dsc node id.
        /// </param>
        /// <param name='reportId'>
        /// Required. The report id.
        /// </param>
        /// <returns>
        /// The response model for the get dsc node report operation.
        /// </returns>
        public static DscNodeReportGetResponse Get(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, Guid nodeId, Guid reportId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscNodeReportsOperations)s).GetAsync(resourceGroupName, automationAccount, nodeId, reportId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the Dsc node report data by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='nodeId'>
        /// Required. The Dsc node id.
        /// </param>
        /// <param name='reportId'>
        /// Required. The report id.
        /// </param>
        /// <returns>
        /// The response model for the get dsc node report operation.
        /// </returns>
        public static Task<DscNodeReportGetResponse> GetAsync(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, Guid nodeId, Guid reportId)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, nodeId, reportId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the Dsc node reports by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='nodeId'>
        /// Required. The Dsc node id.
        /// </param>
        /// <param name='reportId'>
        /// Required. The report id.
        /// </param>
        /// <returns>
        /// The response model for the get node report content operation.
        /// </returns>
        public static DscNodeReportGetContentResponse GetContent(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, Guid nodeId, Guid reportId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscNodeReportsOperations)s).GetContentAsync(resourceGroupName, automationAccount, nodeId, reportId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the Dsc node reports by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='nodeId'>
        /// Required. The Dsc node id.
        /// </param>
        /// <param name='reportId'>
        /// Required. The report id.
        /// </param>
        /// <returns>
        /// The response model for the get node report content operation.
        /// </returns>
        public static Task<DscNodeReportGetContentResponse> GetContentAsync(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, Guid nodeId, Guid reportId)
        {
            return operations.GetContentAsync(resourceGroupName, automationAccount, nodeId, reportId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the Dsc node report list by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list operation.
        /// </param>
        /// <returns>
        /// The response model for the list dsc nodes operation.
        /// </returns>
        public static DscNodeReportListResponse List(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, DscNodeReportListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscNodeReportsOperations)s).ListAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the Dsc node report list by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list operation.
        /// </param>
        /// <returns>
        /// The response model for the list dsc nodes operation.
        /// </returns>
        public static Task<DscNodeReportListResponse> ListAsync(this IDscNodeReportsOperations operations, string resourceGroupName, string automationAccount, DscNodeReportListParameters parameters)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the Dsc node report list by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list dsc nodes operation.
        /// </returns>
        public static DscNodeReportListResponse ListNext(this IDscNodeReportsOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDscNodeReportsOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the Dsc node report list by node id and report id.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IDscNodeReportsOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list dsc nodes operation.
        /// </returns>
        public static Task<DscNodeReportListResponse> ListNextAsync(this IDscNodeReportsOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}
