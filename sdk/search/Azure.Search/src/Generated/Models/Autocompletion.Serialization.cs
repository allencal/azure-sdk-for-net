// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class Autocompletion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            writer.WritePropertyName("queryPlusText");
            writer.WriteStringValue(QueryPlusText);
            writer.WriteEndObject();
        }
        internal static Autocompletion DeserializeAutocompletion(JsonElement element)
        {
            Autocompletion result = new Autocompletion();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryPlusText"))
                {
                    result.QueryPlusText = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}