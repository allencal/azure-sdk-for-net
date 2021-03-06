// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class JwtClaimChecks : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the JwtClaimChecks class.
        /// </summary>
        public JwtClaimChecks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JwtClaimChecks class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        public JwtClaimChecks(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IList<string> allowedGroups = default(IList<string>), IList<string> allowedClientApplications = default(IList<string>))
            : base(id, name, kind, type)
        {
            AllowedGroups = allowedGroups;
            AllowedClientApplications = allowedClientApplications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedGroups")]
        public IList<string> AllowedGroups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedClientApplications")]
        public IList<string> AllowedClientApplications { get; set; }

    }
}
