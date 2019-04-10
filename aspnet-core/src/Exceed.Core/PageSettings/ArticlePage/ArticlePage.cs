using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceed.PageSettings.ArticlePage
{
    public class ArticlePage : Entity, IHasCreationTime, IHasModificationTime, ICreationAudited
    {
        public int ScanCount { get; set; }
        public int LikeCount { get; set; }
        public int UnLikeCount { get; set; }
        /// <summary>
        /// 文章分类
        /// </summary>
        public int ArticleClass { get; set; }
        /// <summary>
        /// 文章类型
        /// </summary>
        public int ArticleType { get; set; }
        /// <summary>
        /// guid,用于查找代替主键
        /// </summary>
        public string FindKey { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Image { get; set; }
        public string Article { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
