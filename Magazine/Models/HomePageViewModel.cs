namespace Magazine.Models
{
    public class HomePageViewModel
    {
       
        public List<SliderViewModel> FirstSlider { get; set; }=new List<SliderViewModel>();
        public List<SliderViewModel> ZweiSlider { get; set; }=new List<SliderViewModel>();
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public List<ListArticles> Articles { get; set; } = new List<ListArticles>();


    }
}
