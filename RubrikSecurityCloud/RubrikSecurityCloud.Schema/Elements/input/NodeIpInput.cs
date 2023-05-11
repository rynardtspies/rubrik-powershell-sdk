// NodeIpInput.cs
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
    #region NodeIpInput

    public class NodeIpInput: IInput
    {
        #region members

        //      C# -> System.String? Ip
        // GraphQL -> ip: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ip")]
        public System.String? Ip { get; set; }

        //      C# -> System.String? Node
        // GraphQL -> node: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("node")]
        public System.String? Node { get; set; }


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

    } // class NodeIpInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types