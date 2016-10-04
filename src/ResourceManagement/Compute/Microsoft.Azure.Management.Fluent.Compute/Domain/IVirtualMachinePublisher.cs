// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Fluent.Compute
{

    using Microsoft.Azure.Management.Fluent.Resource.Core;
    /// <summary>
    /// Represents a virtual machine image publisher.
    /// </summary>
    public interface IVirtualMachinePublisher 
    {
        /// <returns>the region where virtual machine images from this publisher are available</returns>
        Microsoft.Azure.Management.Fluent.Resource.Core.Region Region { get; }

        /// <returns>the name of the publisher</returns>
        string Name { get; }

        /// <returns>the offers from this publisher</returns>
        Microsoft.Azure.Management.Fluent.Compute.IVirtualMachineOffers Offers { get; }

        /// <returns>the virtual machine image extensions from this publisher</returns>
        Microsoft.Azure.Management.Fluent.Compute.IVirtualMachineExtensionImageTypes ExtensionTypes { get; }

    }
}