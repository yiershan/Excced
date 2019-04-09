using Exceed.PageSettings.HomePage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceed.Web.Host.ViewModels.Excced
{
    public class AppInfo {
        public string Name { get; set; }
        public string Desc { get; set; }
    }
    public class SliderImg
    {
        public string ImgUrl { get; set; }
        public string Desc { get; set; }
    }
    public class PetNav
    {
        public string Icon { get; set; }
        public string ClassStyle { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string LinkUrl { get; set; }
    }
    public class Examples {
        public string Title { get; set; }
        public string Desc { get; set; }
        public IList<PetNav> Items { get; set; }
    }
    public class HomePageViewModel
    {
        public string ImgHost { get; set; }

        public IList<SliderImg> SliderImgs { get; set; }
        public IList<PetNav> PetCircleNavs { get; set; }
        public IList<PetNav> PetMoreNavs { get; set; }
        public IList<PetNav> ImgCircleNavs { get; set; }
        public Examples Examples { get; set; }
        public IList<Examples> Activities { get; set; }

        public HomePageViewModel(HomePage homePage)
        {
            this.SliderImgs = JsonConvert.DeserializeObject<List<SliderImg>>(homePage == null ? "[]" : homePage.SliderImgs ?? "[]");
            this.PetCircleNavs = JsonConvert.DeserializeObject<List<PetNav>>(homePage == null ? "[]" : homePage.PetCircleNavs ?? "[]");
            this.PetMoreNavs = JsonConvert.DeserializeObject<List<PetNav>>(homePage == null ? "[]" : homePage.PetMoreNavs ?? "[]");
            this.ImgCircleNavs = JsonConvert.DeserializeObject<List<PetNav>>(homePage == null ? "[]" : homePage.ImgCircleNavs ?? "[]");
            this.Examples = JsonConvert.DeserializeObject<Examples>(homePage == null ? "{}" : homePage.Examples ?? "{}");
            if(this.Examples.Items == null)this.Examples.Items = new List<PetNav>();
            this.Activities = JsonConvert.DeserializeObject<IList<Examples>>(homePage == null ? "{}" : homePage.Activities ?? "{}");
        }
    }
}
