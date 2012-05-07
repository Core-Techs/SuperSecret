using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;

namespace SuperSecret2.Models
{
    public class Secret
    {
        public string Key { get; set; }
        public string Content { get; set; }
        public DateTime Expires { get; set; }
        public Person Creator { get; set; }
        public Person Recipient { get; set; }
        public DateTime? Viewed { get; set; }

        public Secret()
        {
            Key = Guid.NewGuid().ToString("n");            
        }

        public void SetExpiration(int lifetimeMinutes)
        {
            Expires = DateTime.UtcNow.AddMinutes(lifetimeMinutes);
        }

        public string View()
        {
            if (DateTime.UtcNow >= Expires)
            {
                Content = null;
                return null;
            }

            string secret = Content;
            Content = null;
            Viewed = DateTime.UtcNow;
            return secret;
        }
    }
}