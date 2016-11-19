namespace MinhXuShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MinhXuShop.Data.MinhXuShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MinhXuShop.Data.MinhXuShopDbContext context)
        {
            CreateProductCategorySample(context);

            //  This method will be called after migrating to the latest version.

            //    var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new MinhXuShopDbContext()));

            //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new MinhXuShopDbContext()));

            //    var user = new ApplicationUser()
            //    {
            //        UserName = "xuanhoa",
            //        Email = "xuanhoa97@gmail.com",
            //        EmailConfirmed = true,
            //        BirthDay = DateTime.Now,
            //        FullName = "Technology Education"

            //    };

            //    manager.Create(user, "Abc12345");

            //    if (!roleManager.Roles.Any())
            //    {
            //        roleManager.Create(new IdentityRole { Name = "Admin" });
            //        roleManager.Create(new IdentityRole { Name = "User" });
            //    }

            //    var adminUser = manager.FindByEmail("xuanhoa97@gmail.com");

            //    manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }

        private void CreateProductCategorySample(MinhXuShop.Data.MinhXuShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory(){Name = "Điện lạnh", Alias ="điện lạnh",Status = true},
                    new ProductCategory(){Name = "Viễn thông", Alias ="viễn thông",Status = true},
                    new ProductCategory(){Name = "Đồ gia dụng", Alias ="đồ gia dụng",Status = true},
                    new ProductCategory(){Name = "Mỹ phẩm", Alias ="mỹ phẩm",Status = true},

                };
                    context.ProductCategories.AddRange(listProductCategory);
                    context.SaveChanges();
            }
            

        }
    }
}
