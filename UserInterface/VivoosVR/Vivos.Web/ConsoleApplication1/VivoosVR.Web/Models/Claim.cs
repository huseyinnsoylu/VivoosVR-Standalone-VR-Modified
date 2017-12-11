﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsoleApplication1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Claim
    {
        /// <summary>
        /// Initializes a new instance of the Claim class.
        /// </summary>
        public Claim() { }

        /// <summary>
        /// Initializes a new instance of the Claim class.
        /// </summary>
        public Claim(Guid? id = default(Guid?), string roleCode = default(string), string resource = default(string), bool? available = default(bool?), Role role = default(Role))
        {
            Id = id;
            RoleCode = roleCode;
            Resource = resource;
            Available = available;
            Role = role;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RoleCode")]
        public string RoleCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Resource")]
        public string Resource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Available")]
        public bool? Available { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Role")]
        public Role Role { get; set; }

    }
}
