using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Common.Models
{
   public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string[] Groups { get; set; }
    }
}
