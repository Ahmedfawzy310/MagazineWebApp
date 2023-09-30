using Magazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.IServices
{
    public interface IArticle
    {
        Task Create(CreateFormViewModel model);
        TbArticle? GetById(int id);
        IEnumerable<TbArticle> GetArticlesByCategory(int id);
        IEnumerable<TbCategory> ListCategories();
        TbArticle? Update(EditFormViewModel model);
        bool Delete(int id);
    }
}
