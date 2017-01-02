using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory _dbFactory;
        private IPostCategoryRepository _objRepository;
        private IUnitOfWork _unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _objRepository = new PostCategoryRepository(_dbFactory);
            _unitOfWork= new UnitOfWork(_dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory postcategory = new PostCategory()
            {
                Name = "I understood about dbfactory",
                Alias = "post-category",
                Status = false
            };
           var result= _objRepository.Add(postcategory);
            _unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Id);

        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = _objRepository.GetAll().ToList();
            Assert.AreEqual(6,list.Count());
        }

    }
}
