using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceed.PageSettings.HomePage
{
    public class HomePage : Entity, IHasCreationTime, IHasModificationTime, ICreationAudited
    {
        /// <summary>
        /// json格式
        /// </summary>
        public string Activities { get; set; }
        /// <summary>
        /// 案例列表
        /// json格式
        /// </summary>
        public string Examples { get; set; }
        /// <summary>
        /// 图片快捷导航列表
        /// json格式
        /// </summary>
        public string ImgCircleNavs { get; set; }
        /// <summary>
        /// 头部导航菜单列表
        /// json格式
        /// </summary>
        public string PetCircleNavs { get; set; }
        /// <summary>
        /// 影藏菜单列表
        /// json格式
        /// </summary>
        public string PetMoreNavs { get; set; }
        /// <summary>
        /// 顶部滚动图片列表
        /// json格式
        /// </summary>
        public string SliderImgs { get; set; }
        /// <summary>
        /// 页面发布状态
        /// </summary>
        public PublishType PublishType { get; set; }
        public DateTime CreationTime { get; set ; }
        public DateTime? LastModificationTime { get; set; }
        public long? CreatorUserId { get; set; }
    }
}
