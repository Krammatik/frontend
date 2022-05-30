using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_Layer.Common.Models.Request.User
{
   public class UserRequest: RestRequest
    {
        public UserRequest(string token): base(EndPoint.UserUrl,Method.Get)
        {
            this.AddHeader("Accept", "application/json");
            this.AddHeader("Content-Type", "application/json");
            this.AddHeader("Authorization", $"Bearer {token}");
        }
    }
}
