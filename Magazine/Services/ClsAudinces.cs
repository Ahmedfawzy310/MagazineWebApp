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
    public class ClsAudinces:IAudinces
    {
        private readonly MagazineDbContext context;
        public ClsAudinces(MagazineDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetAudinces()
        {
            return context.TargetAudiences.Select(e => new SelectListItem { Value = e.Id.ToString(), Text = e.Name })
                 .OrderBy(e => e.Text).ToList();
        }
    }
}
