// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type VpnTrafficRule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class VpnTrafficRule
    {

        /// <summary>
        /// Gets or sets name.
        /// Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets protocols.
        /// Protocols (0-255). Valid values 0 to 255
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocols", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Protocols { get; set; }
    
        /// <summary>
        /// Gets or sets localPortRanges.
        /// Local port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localPortRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<NumberRange> LocalPortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets remotePortRanges.
        /// Remote port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remotePortRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<NumberRange> RemotePortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets localAddressRanges.
        /// Local address range. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localAddressRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IPv4Range> LocalAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets remoteAddressRanges.
        /// Remote address range. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteAddressRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IPv4Range> RemoteAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets appId.
        /// App identifier, if this traffic rule is triggered by an app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets appType.
        /// App type, if this traffic rule is triggered by an app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appType", Required = Newtonsoft.Json.Required.Default)]
        public VpnTrafficRuleAppType? AppType { get; set; }
    
        /// <summary>
        /// Gets or sets routingPolicyType.
        /// When app triggered, indicates whether to enable split tunneling along this route.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routingPolicyType", Required = Newtonsoft.Json.Required.Default)]
        public VpnTrafficRuleRoutingPolicyType? RoutingPolicyType { get; set; }
    
        /// <summary>
        /// Gets or sets claims.
        /// Claims associated with this traffic rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "claims", Required = Newtonsoft.Json.Required.Default)]
        public string Claims { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}