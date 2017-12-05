using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNews.Repository.DTO
{
    [SitecoreType(AutoMap = true)]
    public class ArticlesCollection
    {
        public virtual IEnumerable<Article> ArticleList { get; set; }

        [SitecoreField]
        public int NumberOfArticles { get; set; }
    }
}
