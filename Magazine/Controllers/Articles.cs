

using Domains;
using System.Xml.Linq;

namespace _1STArticle.Controllers
{
    public class Articles : Controller
    {
        ICategories oCategories;
        IArticle oarticle;
        IGender ogender;
        IAudinces oaudinces;
        public Articles(ICategories Categories, IArticle article, IGender gender, IAudinces audinces)
        {
            oCategories = Categories;
            oaudinces = audinces;
            oarticle = article;
            ogender = gender;
        }
        public IActionResult Details(int id)
        {
            var game = oarticle.GetById(id);

            if (game is null)
                return NotFound();

            return View(game);
        }

        public IActionResult FormAddition()
        {
            CreateFormViewModel model = new CreateFormViewModel()
            {
                Categories = oCategories.GetCategories(),
                Genders = ogender.GetGender(),
                TargetAudinces = oaudinces.GetAudinces()
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FormAddition(CreateFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = oCategories.GetCategories();
                model.Genders = ogender.GetGender();
                model.TargetAudinces = oaudinces.GetAudinces();
            }
            await oarticle.Create(model);
            return Redirect("/Home/Index");

        }
        public IActionResult News(int id)
        {
            NewsPageViewModel model = new()
            {
                Articles = oarticle.GetArticlesByCategory(id)
            };
            if (model is null) return NotFound();

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var Article=oarticle.GetById(id);

            if(Article is null) 
                return NotFound();

            EditFormViewModel model = new()
            {
                Id=Article.Id,
                Title=Article.Title,
                Description=Article.Description,
                CategoryId=Article.CategoryId,
                GenderId=Article.GenderId,
                SelectedAudinces = Article.TargetAudience.Select(d => d.TargetId).ToList(),
                TargetAudinces =oaudinces.GetAudinces(),
                Categories = oCategories.GetCategories(),
                Genders = ogender.GetGender(),

            };


            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = oCategories.GetCategories();
                model.TargetAudinces = oaudinces.GetAudinces();
                return View(model);
            }

            var article =  oarticle.Update(model);

            if (article is null)
                return BadRequest();

            return RedirectToAction(nameof(News));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = oarticle.Delete(id);

            return isDeleted ? Ok() : BadRequest();
        }

    }

}
