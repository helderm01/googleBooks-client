using Raven.Client.Documents;
using Raven.Client.Documents.Conventions;

namespace GoogleBooks.RavenDB
{
    public class RavenDocumentStore : DocumentStore
    {
        public RavenDocumentStore(Config conf) : base()
        {
            Urls = new[] { conf.DB.Url };
            Database = conf.DB.Database;
            Conventions = new DocumentConventions
            {
                SaveEnumsAsIntegers = true,
            };
            Initialize();
        }
    }
}