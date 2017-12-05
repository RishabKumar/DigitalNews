using DigitalNews.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalNews.Web.Models
{
    public class FeaturedArticles
    {
        public IEnumerable<Article> RecentArticles { get; set; }

        public IEnumerable<Article> MostPopularArticles { get; set; }

        public int NumberOfArticles { get; set; }

    }
}