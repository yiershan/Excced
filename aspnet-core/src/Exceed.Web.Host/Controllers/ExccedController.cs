using Exceed.Configuration;
using Exceed.Controllers;
using Exceed.PageSettings.ArticlePage;
using Exceed.PageSettings.HomePage;
using Exceed.Web.Host.ViewModels.Excced;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Exceed.Web.Host.Controllers
{
    public class ExccedController: ExceedControllerBase
    {
        private IHomePageOpenService _openService;
        private IArticlePageOpenService _articlePageOpenService;
        private readonly IConfigurationRoot _appConfiguration;
        public ExccedController(IHomePageOpenService openService,
            IArticlePageOpenService articlePageOpenService,
            IHostingEnvironment env) {
            _openService = openService;
            _articlePageOpenService = articlePageOpenService; 
            _appConfiguration = env.GetAppConfiguration();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.AppInfo = JsonConvert.DeserializeObject<AppInfo>(SettingManager.GetSettingValueAsync(AppSettingNames.AppInfo).Result);
            var data = _openService.GetHomePage();
            var result = new HomePageViewModel(data)
            {
                ImgHost = _appConfiguration["App:ImgUrl"]
            };
            return View(result);
        }
        [HttpGet]
        public IActionResult Article(string key) {
            var result = _articlePageOpenService.GetArticlePageByKey(key);
            return View(new ArticlePageViewModel(result));
        }
    }
}
