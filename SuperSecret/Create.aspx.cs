using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Caching;

namespace SuperSecret
{
    public partial class Create : System.Web.UI.Page
    {
        private int _maxSecretLength;

        protected void Page_Load(object sender, EventArgs e)
        {
            _maxSecretLength = int.Parse(ConfigurationManager.AppSettings["MaxSecretLength"]);
            txtSecret.MaxLength = _maxSecretLength;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            var id = Guid.NewGuid().ToString("n");

            int secretLifeMinutes = int.Parse(ConfigurationManager.AppSettings["SecretLifeMinutes"]);
            var expireTime = DateTime.Now.AddMinutes(secretLifeMinutes);
            Cache.Add(id, txtSecret.Text.Truncate(_maxSecretLength), null, expireTime, Cache.NoSlidingExpiration, CacheItemPriority.Default, null);

            secretUrl.Text = ConfigurationManager.AppSettings["BaseUrl"] + id;
            lblExpires.Text = String.Format("This URL can be visited only once before it's expiration time of {0} UTC.", expireTime.ToUniversalTime());
        }
    }
}