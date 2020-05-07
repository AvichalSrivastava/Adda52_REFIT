using System;
using Newtonsoft.Json;

namespace Adda52_REFIT.Model
{
    public class User
    {
        [JsonProperty(PropertyName = "login")]
        public string userName { get; set; }

        public override string ToString()
        {
            return userName;
        }
    }
}
