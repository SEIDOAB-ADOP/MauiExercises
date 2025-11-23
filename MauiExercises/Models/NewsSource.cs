using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExercises.Models
{
    public class NewsSource
    {
        public string Name { private set; get; }

        public string Url { private set; get; }

        public static IEnumerable<NewsSource> All { private set; get; }

        // Note the static constructor to initialize all Static members, int this case property All
        static NewsSource()
        {
            List<NewsSource> all = new List<NewsSource>();
            all.Add(new NewsSource { Name = "Svd", Url = "https://www.svd.se" });
            all.Add(new NewsSource { Name = "DN", Url = "https://www.dn.se" });
            all.Add(new NewsSource { Name = "CNN", Url = "https://www.cnn.com" });
            all.Add(new NewsSource { Name = "BBC", Url = "https://www.bbc.com" });

            All = all;
        }
    }
}
