using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.IServices
{
    public interface IAudinces
    {
        public IEnumerable<SelectListItem> GetAudinces();
    }
}
