using Exceed.PageSettings.ArticlePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceed.Web.Host.ViewModels.Excced
{
    public class ArticlePageViewModel
    {
        public int ScanCount { get; set; }
        public int LikeCount { get; set; }
        public int UnLikeCount { get; set; }


        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public string Article { get; set; }

        public ArticlePageViewModel(ArticlePage articlePage) {
            ScanCount = articlePage.ScanCount;
            LikeCount = articlePage.LikeCount;
            UnLikeCount = articlePage.UnLikeCount;
            Title = articlePage.Title;
            Desc = articlePage.Desc;
            Image = articlePage.Image;
            Article = articlePage.Article;
        }
    }
}
