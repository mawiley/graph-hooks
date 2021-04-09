// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Newtonsoft.Json;
using System;

namespace graph_hooks.Models
{
  public class MembersDelta
  {
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }
  }

}