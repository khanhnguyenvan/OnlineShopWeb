﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
  public  interface IPostCategoryService
  {
        PostCategory Add(PostCategory postCategory);
      void Update(PostCategory postCategory);
      void Delete(int id);
      IEnumerable<PostCategory> GetAll();
      IEnumerable<PostCategory> GetAllByParentId(int parentId);
      PostCategory GetById(int id);
  }
   public class PostCategoryService : IPostCategoryService
   {
       private readonly IPostCategoryRepository _postCategoryRepository;
       private readonly IUnitOfWork _unitOfWork;

       public PostCategoryService(IPostCategoryRepository postCategoryRepository,IUnitOfWork unitOfWork)
       {
           _postCategoryRepository = postCategoryRepository;
           _unitOfWork = unitOfWork;

       }
        public PostCategory Add(PostCategory postCategory)
        {
       return   _postCategoryRepository.Add(postCategory);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }

        public void Delete(int id)
        {
          _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentId == parentId);
        }


       public PostCategory GetById(int id)
       {
           return _postCategoryRepository.GetSingleById(id);
       }
   }
}
