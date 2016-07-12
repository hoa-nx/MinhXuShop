using AutoMapper;
using MinhXuShop.Model.Models;
using MinhXuShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhXuShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
        }
    }
}