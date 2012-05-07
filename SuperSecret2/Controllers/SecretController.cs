using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Caching;
using SuperSecret2;
using SuperSecret2.Models;
using SuperSecret2.Infrastructure;
using Raven.Json.Linq;

namespace SuperSecret2.Controllers
{
    public class SecretController : Controller
    {
        //
        // GET: /Secret/

        public ActionResult Index(string key)
        {
            using (var db = RavenUtil.OpenSession())
            {
                var secret = db.Query<Secret>().SingleOrDefault(x => x.Key == key);
                if (secret != null)
                {
                    ViewBag.Secret = secret.View();
                    db.SaveChanges();
                }
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Secret secret, int lifetime)
        {
            secret.SetExpiration(lifetime);

            using (var db = RavenUtil.OpenSession())
            {
                db.Store(secret);
                db.Advanced.GetMetadataFor(secret)["Raven-Expiration-Date"] = RavenJToken.FromObject(secret.Expires);
                db.SaveChanges();
            }

            ViewBag.URL = Config.BaseUrl + secret.Key;

            return View();
        }
    }
}