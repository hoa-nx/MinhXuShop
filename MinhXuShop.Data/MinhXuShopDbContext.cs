using Microsoft.AspNet.Identity.EntityFramework;
using MinhXuShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhXuShop.Data
{
    public class MinhXuShopDbContext : IdentityDbContext<ApplicationUser>

    {
        //contructor 
        public MinhXuShopDbContext() : base("MinhXuShopConnection")
        {
            //khi load bang cha thi khong include cac bang con
            this.Configuration.LazyLoadingEnabled = false;

        }
        
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static MinhXuShopDbContext Create()
        {
            return new MinhXuShopDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //base.OnModelCreating(builder);
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId } );
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
