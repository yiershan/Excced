using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceed.PageSettings.ArticlePage
{
    public interface IArticlePageOpenService : IApplicationService
    {
        ArticlePage GetArticlePageByKey(string key);
    }
}
