using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client;
using Raven.Client.Embedded;

namespace SuperSecret2.Infrastructure
{
    public static class RavenUtil
    {
        static IDocumentStore _docStore;

        static RavenUtil()
        {
            _docStore = new EmbeddableDocumentStore() { RunInMemory = true, UseEmbeddedHttpServer = true }.Initialize();
        }

        public static void Initialize() { }

        public static IDocumentSession OpenSession()
        {
            return _docStore.OpenSession();
        }
    }
}