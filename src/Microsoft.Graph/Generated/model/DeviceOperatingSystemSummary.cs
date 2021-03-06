// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceOperatingSystemSummary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceOperatingSystemSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceOperatingSystemSummary"/> class.
        /// </summary>
        public DeviceOperatingSystemSummary()
        {
            this.ODataType = "microsoft.graph.deviceOperatingSystemSummary";
        }

        /// <summary>
        /// Gets or sets androidCount.
        /// Number of android device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "androidCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AndroidCount { get; set; }
    
        /// <summary>
        /// Gets or sets iosCount.
        /// Number of iOS device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iosCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IosCount { get; set; }
    
        /// <summary>
        /// Gets or sets macOSCount.
        /// Number of Mac OS X device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "macOSCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MacOSCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknownCount.
        /// Number of unknown device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownCount { get; set; }
    
        /// <summary>
        /// Gets or sets windowsCount.
        /// Number of Windows device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WindowsCount { get; set; }
    
        /// <summary>
        /// Gets or sets windowsMobileCount.
        /// Number of Windows mobile device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsMobileCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? WindowsMobileCount { get; set; }
    
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
