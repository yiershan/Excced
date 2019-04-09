using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceed.PageSettings.HomePage
{
    public class HomePageOpenService : ExceedAppServiceBase, IHomePageOpenService
    {
        IRepository<HomePage, int> _homePageRepository;
        public HomePageOpenService(IRepository<HomePage, int> homePageRepository) {
            _homePageRepository = homePageRepository;
        }
        public HomePage GetHomePage()
        {
           return _homePageRepository.GetAll().Where(m => m.PublishType == PublishType.Useing).FirstOrDefault();
        }
    }
}
