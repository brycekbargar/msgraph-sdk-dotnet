// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type UserOauth2PermissionGrantsCollectionWithReferencesPage.
    /// </summary>
    public partial class UserOauth2PermissionGrantsCollectionWithReferencesPage : CollectionPage<OAuth2PermissionGrant>, IUserOauth2PermissionGrantsCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IUserOauth2PermissionGrantsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IUserOauth2PermissionGrantsCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new UserOauth2PermissionGrantsCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
