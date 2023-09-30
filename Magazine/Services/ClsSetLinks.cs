namespace Magazine.Services
{
    public class ClsSetLinks: ISetLinks
    {
        MagazineDbContext context;
        public ClsSetLinks(MagazineDbContext context)
        {
            this.context = context;
        }


        public TbSetting Get()
        {
            return context.Settings.FirstOrDefault();
        }

        public bool Save(TbSetting set)
        {
            if (set.Id == 0)
            {
                context.Settings.Add(set);
            }
            else
            {
                context.Entry(set).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            context.SaveChanges();
            return true;
        }
    }
}
