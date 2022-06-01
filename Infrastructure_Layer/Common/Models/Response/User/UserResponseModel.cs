using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Common.Models.Response.User
{
    public class UserResponseModel
    {
        [JsonPropertyName("id")] public string Id { get; set; }
        [JsonPropertyName("username")] public string UserName { get; set; }
        [JsonPropertyName("groups")] public string[] Groups { get; set; }

    }
}
