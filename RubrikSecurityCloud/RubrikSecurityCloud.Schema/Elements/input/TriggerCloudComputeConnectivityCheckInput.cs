// TriggerCloudComputeConnectivityCheckInput.cs
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
    #region TriggerCloudComputeConnectivityCheckInput

    public class TriggerCloudComputeConnectivityCheckInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldCheckCloudConnectivityForCloudOut
        // GraphQL -> shouldCheckCloudConnectivityForCloudOut: Boolean (scalar)
        [JsonProperty("shouldCheckCloudConnectivityForCloudOut")]
        public System.Boolean? ShouldCheckCloudConnectivityForCloudOut { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? ShouldCheckCloudConnectivityForCloudOn
        // GraphQL -> shouldCheckCloudConnectivityForCloudOn: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldCheckCloudConnectivityForCloudOn")]
        public System.Boolean? ShouldCheckCloudConnectivityForCloudOn { get; set; }


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

    } // class TriggerCloudComputeConnectivityCheckInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types