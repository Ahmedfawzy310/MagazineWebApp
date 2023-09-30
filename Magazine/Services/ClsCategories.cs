using Bl.IServices;
using Magazine.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class ClsCategories:ICategories
    {
        private readonly MagazineDbContext context;
        public ClsCategories(MagazineDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            return context.Categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
               .OrderBy(c => c.Text).ToList();
        }
    }
}
