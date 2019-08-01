﻿// Copyright (c) 2019 connexion OG / Roman Wienicke
using Newtonsoft.Json;

namespace DemoWebsite.Models
{
    /// <summary>
    /// the payload to be sent to wirecard
    /// </summary>
    public class Payload
    {
        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }
    }

}

