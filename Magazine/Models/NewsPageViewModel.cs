namespace Magazine.Models
{
    public class NewsPageViewModel
    {
        public IEnumerable<TbArticle> Articles { get; set; } = Enumerable.Empty<TbArticle>();
        
    }
}
