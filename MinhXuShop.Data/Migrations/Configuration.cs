namespace MinhXuShop.Data.Migrations
{
    using Common;
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
            CreateSlide(context);
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

        private void CreateUser(MinhXuShopDbContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

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
    

        private void CreateProductCategorySample(MinhXuShopDbContext context)
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

        private void CreateFooter(MinhXuShopDbContext context)
        {
            if(context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId)==0)
            {
                string content = "";
            }
        }

        private void CreateSlide(MinhXuShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {

                        Name = "Slide1" ,
                        DisplayOrder =1 ,
                        Status =true ,
                        Url ="#",
                        Image ="/Assets/client/images/bag.jpg" ,
                        Content=@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>"},
                    new Slide() {
                        Name = "Slide2" ,
                        DisplayOrder =2 ,
                        Status =true ,
                        Url ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                        Content=@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>"}

                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }


    }
}
