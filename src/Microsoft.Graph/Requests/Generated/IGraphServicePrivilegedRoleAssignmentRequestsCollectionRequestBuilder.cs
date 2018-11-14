// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedRoleAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedRoleAssignmentRequestRequestBuilder"/> for the specified PrivilegedRoleAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedRoleAssignmentRequest.</param>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentRequestRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentRequestRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrivilegedRoleAssignmentRequestMy.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentRequestMyRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentRequestMyRequestBuilder My();
    }
}