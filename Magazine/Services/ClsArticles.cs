

namespace Bl.Services
{
    public class ClsArticles:IArticle
    {
        private readonly MagazineDbContext context;
       
        public ClsArticles(MagazineDbContext context)
        {
            this.context = context;
            
        }

        public async Task Create(CreateFormViewModel model)
        {


            var artice = new TbArticle
            {
               Title= model.Title,
               Description= model.Description,
               CategoryId=model.CategoryId,
               GenderId=model.GenderId,
               CreatedDate=DateTime.Now,
               TargetAudience = model.SelectedAudinces.Select(e => new TbTargetAudienceFK { TargetId = e }).ToList(),
               Images=new List<TbImageForArticle>()
            };
            context.Articles.Add(artice);
            await context.SaveChangesAsync();

            string filepath=string.Empty;
            switch (artice.CategoryId)
            {
                case 1:
                    
                    filepath = "wwwroot/images/sports";    break;
                case 2:
                    filepath = "wwwroot/images/Politics";  break;
                case 3:
                    filepath = "wwwroot/images/Religious"; break;
                case 4:
                    filepath = "wwwroot/images/Art";       break;
                case 5:
                    filepath = "wwwroot/images/Health";    break;
                case 6:
                    filepath = "wwwroot/images/Cooking";   break;
                case 7:
                    filepath = "wwwroot/images/Education"; break;
                case 8:
                    filepath = "wwwroot/images/Entertainment"; break;
                default:
                    filepath = "wwwroot/images";            break;

            }

            foreach (var imageFile in model.Images)
            {
                var image = new TbImageForArticle();
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(filepath, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(fileStream);
                    image.ImageTitle = fileName;
                    artice.Images.Add(image);
                }

            }
            await context.SaveChangesAsync();
        }


        

        public IEnumerable<TbCategory> ListCategories()
        {
            return context.Categories.Include(a => a.Articles).ThenInclude(a=>a.Images).ToList();
        }

        public TbArticle? GetById(int id)
        {
            return context.Articles
                .Include(g => g.Category)
                .Include(g => g.Images)
                .AsNoTracking()
                .SingleOrDefault(g => g.Id == id);
        }

       

        public IEnumerable<TbArticle> GetArticlesByCategory(int id)
        {


            return context.Articles.
               Include(c => c.Category).
               Include(i => i.Images).
               Where(c => c.CategoryId==id)
               .AsNoTracking().ToList();
                
        }


        public TbArticle? Update(EditFormViewModel model)
        {
            var article=context.Articles
                .Include(i=>i.Images).SingleOrDefault(a=>a.Id==model.Id);

            if (article is null)
                return null;

           

            article.Title= model.Title;
            article.Description= model.Description;
            article.CategoryId= model.CategoryId;
            article.GenderId= model.GenderId;
            article.TargetAudience = model.SelectedAudinces.Select(a => new TbTargetAudienceFK { TargetId = a }).ToList();
            

            return article;
            
        }


        public bool Delete(int id)
        {
            var isDeleted = false;

            var article = context.Articles.Find(id);

            if (article is null)
                return isDeleted;

            context.Remove(article);
            var effectedRows = context.SaveChanges();

            if (effectedRows > 0)
            {
                isDeleted = true;

                foreach (var image in article.Images)
                {
                    var cover = Path.Combine(image.ImageTitle);
                    File.Delete(cover);
                }
            }

            return isDeleted;
        }


       
    }
}
