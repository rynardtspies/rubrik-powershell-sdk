// UpdateDnsServersAndSearchDomainsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateDnsServersAndSearchDomainsInput

    public class UpdateDnsServersAndSearchDomainsInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Servers
        // GraphQL -> servers: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("servers")]
        public List<System.String>? Servers { get; set; }

        //      C# -> List<System.String>? Domains
        // GraphQL -> domains: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("domains")]
        public List<System.String>? Domains { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class UpdateDnsServersAndSearchDomainsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types