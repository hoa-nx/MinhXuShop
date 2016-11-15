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
            
            /*
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Source();
            var dest = mapper.Map<Source, Dest>(source);
            */
        }
    }
}