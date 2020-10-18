/* 
 * Xero Projects API
 *
 * This is the Xero Projects API
 *
 * The version of the OpenAPI document: 2.3.6
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Project
{
    /// <summary>
    /// Can be &#x60;TIME&#x60;, &#x60;FIXED&#x60; or &#x60;NON_CHARGEABLE&#x60;, defines how the task will be charged. Use &#x60;TIME&#x60; when you want to charge per hour and &#x60;FIXED&#x60; to charge as a fixed amount. If the task will not be charged use &#x60;NON_CHARGEABLE&#x60;.
    /// </summary>
    /// <value>Can be &#x60;TIME&#x60;, &#x60;FIXED&#x60; or &#x60;NON_CHARGEABLE&#x60;, defines how the task will be charged. Use &#x60;TIME&#x60; when you want to charge per hour and &#x60;FIXED&#x60; to charge as a fixed amount. If the task will not be charged use &#x60;NON_CHARGEABLE&#x60;.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChargeType
    {
        /// <summary>
        /// Enum TIME for value: TIME
        /// </summary>
        [EnumMember(Value = "TIME")]
        TIME = 1,

        /// <summary>
        /// Enum FIXED for value: FIXED
        /// </summary>
        [EnumMember(Value = "FIXED")]
        FIXED = 2,

        /// <summary>
        /// Enum NONCHARGEABLE for value: NON_CHARGEABLE
        /// </summary>
        [EnumMember(Value = "NON_CHARGEABLE")]
        NONCHARGEABLE = 3

    }

}
