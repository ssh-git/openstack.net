﻿using Newtonsoft.Json;
using OpenStack.Compute.v2_1.Serialization;

namespace OpenStack.Compute.v2_1
{
    /// <summary />
    [JsonConverter(typeof(KeyPairConverter))]
    public class KeyPairDefinition
    {
        /// <summary />
        public KeyPairDefinition(string name, string publicKey)
        {
            Name = name;
            PublicKey = publicKey;
        }

        /// <summary />
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary />
        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
    }
}