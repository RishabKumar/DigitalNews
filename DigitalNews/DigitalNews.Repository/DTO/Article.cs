using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNews.Repository.DTO
{
    [SitecoreType(AutoMap = true)]
    public class Article
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual string Title { get; set; }

        [SitecoreField]
        public virtual string Body { get; set; }

        [SitecoreField(FieldName = "Article Created Date")]
        public virtual DateTime ArticleCreatedDate { get; set; }

        [SitecoreField(FieldName = "Number Of Views")]
        public virtual int NumberOfViews { get; set; }

        [SitecoreField(FieldName = "Author Name")]
        public virtual string AuthorName { get; set; }
    }
}
