using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockPostCategoryRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> _listPostCategories;
        [TestInitialize]
        public void Initialize()
        {
            _mockPostCategoryRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork= new Mock<IUnitOfWork>();
            _postCategoryService= new PostCategoryService(_mockPostCategoryRepository.Object,_mockUnitOfWork.Object);
            _listPostCategories= new List<PostCategory>()
            {
                new PostCategory()
                {
                    Id=1,
                    Name = "Post Category service 1",
                    Alias = "post",
                    Status = true
                },
                new PostCategory()
                {
                    Id=2,
                     Name = "Post Category service 2",
                    Alias = "post",
                    Status = false
                },
                new PostCategory()
                {
                    Id = 3,
                       Name = "Post Category service 3",
                    Alias = "post",
                    Status = false
                }
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Set up method,giả lập để trả ra list
            _mockPostCategoryRepository.Setup(m => m.GetAll(null)).Returns(_listPostCategories);
            //call action thực tế
            var result = _postCategoryService.GetAll() as List<PostCategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3,result.Count);

        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "pc1";
            postCategory.Alias = "p-c";
            postCategory.Status = true;
            _mockPostCategoryRepository.Setup(m => m.Add(postCategory)).Returns((PostCategory p) =>
            {
                p.Id = 1;
                return p;

            });
            var result = _postCategoryService.Add(postCategory);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
        }


    }
}
