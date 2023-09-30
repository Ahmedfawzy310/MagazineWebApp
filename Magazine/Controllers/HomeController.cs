
namespace Magazine.Controllers
{
    public class HomeController : Controller
    {
        ISlider slider;
        IArticle article;
        public HomeController(ISlider slider, IArticle article)
        {

            this.slider = slider;
            this.article = article;
        }

        public IActionResult Index()
        {
            var MainSlider = slider.Main();
            var SecondSlider=slider.Second();
            var categories = article.ListCategories();
            var model=new List<HomePageViewModel>();

            foreach (var category in categories)
            {
                var viewModel = new HomePageViewModel()
                {
                    
                    CategoryId = category.Id,
                    CategoryName = category.Name,
                    Articles = category.Articles.Select(a => new ListArticles
                    {
                        ImageTitles = a.Images.Select(i => i.ImageTitle).ToList()
                    }).ToList(),
                   FirstSlider=MainSlider.Select(a=>new SliderViewModel
                   {
                       ImageMain=a.Name
                       
                   }).ToList(),
                    ZweiSlider = SecondSlider.Select(a => new SliderViewModel
                    {
                        ImageSecond = a.Name

                    }).ToList()

                };
               model.Add(viewModel);
            }
            

            

            return View(model);
        }

        
    }
}
