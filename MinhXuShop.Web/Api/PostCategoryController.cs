using AutoMapper;
using MinhXuShop.Model.Models;
using MinhXuShop.Service;
using MinhXuShop.Web.Infrastructure.Core;
using MinhXuShop.Web.Infrastructure.Extentions;
using MinhXuShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MinhXuShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    [Authorize]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;

        public PostCategoryController (IErrorService errorService , IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                 
                var listCategory = _postCategoryService.GetAll();
                var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(postCategory);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);
                                
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request , PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
           {
               HttpResponseMessage response = null;
               if (ModelState.IsValid)
               {
                   request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
               }
               else
               {
                   PostCategory newPostCategory = new PostCategory();
                   newPostCategory.UpdatePostCategory(postCategoryVm);
                   newPostCategory.CreatedBy = User.Identity.Name;
                   newPostCategory.CreatedDate = DateTime.Now;

                   var category = _postCategoryService.Add(newPostCategory);
                   _postCategoryService.Save();

                   response = request.CreateResponse(HttpStatusCode.Created, category);

               }
               return response;
           });   
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);

                    postCategoryDb.UpdatePostCategory(postCategoryVm);
                    postCategoryDb.UpdatedBy = User.Identity.Name;
                    postCategoryDb.UpdatedDate= DateTime.Now;
                    _postCategoryService.Update(postCategoryDb);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(postCategory.ID);
                    _postCategoryService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }

    }
}