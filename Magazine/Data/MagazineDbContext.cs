using Domains;
using Magazine.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Magazine.Data
{
    public class MagazineDbContext : IdentityDbContext<ApplicationUser>
    {
        public MagazineDbContext(DbContextOptions<MagazineDbContext> options)
            : base(options)
        {
        }
        public DbSet<TbArticle> Articles { get; set; }
        public DbSet<TbImageForArticle> Images { get; set; }
        public DbSet<TbCategory> Categories { get; set; }
        public DbSet<TbTargetGender> TargetGenders { get; set; }
        public DbSet<TbTargetAudience> TargetAudiences { get; set; }
        public DbSet<TbTargetAudienceFK> Audinces { get; set; }
        public DbSet<TbHomeSlider> HomeSlider { get; set; }
        public DbSet<TbSetting> Settings { get; set; }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TbTargetAudienceFK>()
        .HasKey(ata => new { ata.ArticleId, ata.TargetId });

            builder.Entity<TbTargetAudienceFK>()
                .HasOne(ata => ata.Article)
                .WithMany(a => a.TargetAudience)
                .HasForeignKey(ata => ata.ArticleId);

            builder.Entity<TbTargetAudienceFK>()
                .HasOne(ata => ata.TargetAudience)
                .WithMany(ta => ta.TargetAudiences)
                .HasForeignKey(ata => ata.TargetId);

           

            builder.Entity<TbCategory>().HasData(new TbCategory[]
            {
                new TbCategory{Id=1,Name="Sports"},
                new TbCategory{Id=2,Name="Politics"},
                new TbCategory{Id=3,Name="Religious"},
                new TbCategory{Id=4,Name="Art"},
                new TbCategory{Id=5,Name="Health"},
                new TbCategory{Id=6,Name="Cooking"},
                new TbCategory{Id=7,Name="Education"},
                new TbCategory{Id=8,Name="Entertainment"}
            });

            builder.Entity<TbTargetGender>().HasData(new TbTargetGender[]
            {
                new TbTargetGender{Id=1,Name="Male"},
                new TbTargetGender{Id=2,Name="Female"},
                new TbTargetGender{Id=3,Name="Both"}
            });

            builder.Entity<TbTargetAudience>().HasData(new TbTargetAudience[]
            {
                new TbTargetAudience{Id=1,Name="athletes"},
                new TbTargetAudience{Id=2,Name="politicians"},
                new TbTargetAudience{Id=3,Name="businessmen"},
                new TbTargetAudience{Id=4,Name="patients"},
                new TbTargetAudience{Id=5,Name="students"},
                new TbTargetAudience{Id=6,Name="farmers"},
                new TbTargetAudience{Id=7,Name="the poor"},
                new TbTargetAudience{Id=8,Name="elderly"},
                new TbTargetAudience{Id=9,Name="youth"},
            });

            builder.Entity<TbSetting>().HasData(new TbSetting[]
           {
                new TbSetting{Id=1,FacebookLink="https://www.facebook.com/ahmed.ragp.129"
                ,GithupLink="https://github.com/Ahmedfawzy310",
                TwiterLink="https://github.com/Ahmedfawzy310",
                InstagramLink="https://github.com/Ahmedfawzy310",
                LinkedinLink="https://github.com/Ahmedfawzy310"}
               
           });

           

            base.OnModelCreating(builder);
        }
    }
}
