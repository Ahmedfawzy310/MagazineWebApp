using Magazine.IServices;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Magazine.Services
{
    public class ClsSlider : ISlider
    {
        MagazineDbContext context;
        public ClsSlider(MagazineDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TbHomeSlider> Main()
        {
            var slide = context.HomeSlider.OrderBy(a => a.Id).Take(3).ToList();
            return slide;
        }

        public IEnumerable<TbHomeSlider> Second()
        {
            var slide = context.HomeSlider.OrderBy(a => a.Id).Skip(3).ToList();
            return slide;
        }

      

    }
}
