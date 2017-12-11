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

    public partial class IdentityUserLogin
    {
        /// <summary>
        /// Initializes a new instance of the IdentityUserLogin class.
        /// </summary>
        public IdentityUserLogin() { }

        /// <summary>
        /// Initializes a new instance of the IdentityUserLogin class.
        /// </summary>
        public IdentityUserLogin(string loginProvider = default(string), string providerKey = default(string), string userId = default(string))
        {
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
            UserId = userId;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LoginProvider")]
        public string LoginProvider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProviderKey")]
        public string ProviderKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

    }
}
