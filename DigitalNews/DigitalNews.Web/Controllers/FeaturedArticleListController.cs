using DigitalNews.Repository.DTO;
using DigitalNews.Web.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalNews.Web.Controllers
{
    public class FeaturedArticleListController : GlassController
    {
        /// <summary>
        /// Fetches all the articles from datasource and performs operations to determine most recent and popular articles
        /// </summary>
        /// <returns>Returns object of type FeaturedArticles that contains Recent and Popular articles</returns>
        public ActionResult GetArticles()
        {
            string id = RenderingContextWrapper.GetDataSource();
            Guid guid;
            var featuredarticles = new FeaturedArticles();
            if (!string.IsNullOrEmpty(id) && Guid.TryParse(id, out guid))
            {
                var datasourceitem = SitecoreContext.GetItem<ArticlesCollection>(guid);
                if (datasourceitem.ArticleList.Any())
                {
                    featuredarticles.RecentArticles = datasourceitem.ArticleList.OrderByDescending(x => x.ArticleCreatedDate).Take(datasourceitem.NumberOfArticles);
                    featuredarticles.MostPopularArticles = datasourceitem.ArticleList.OrderByDescending(x => x.NumberOfViews).Take(datasourceitem.NumberOfArticles);
                }
            }
            return View(featuredarticles);
        }

       

    }
}
