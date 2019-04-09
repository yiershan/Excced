using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceed.PageSettings.ArticlePage
{
    public class ArticlePageOpenService: ExceedAppServiceBase, IArticlePageOpenService
    {
        IRepository<ArticlePage, int> _articlePageRepository;
        public ArticlePageOpenService(IRepository<ArticlePage, int> articlePageRepository) {
            _articlePageRepository = articlePageRepository;
        }

        public ArticlePage GetArticlePageByKey(string key)
        {
            return _articlePageRepository.GetAll().Where(m => m.Key == key).FirstOrDefault();
        }
    }
}
