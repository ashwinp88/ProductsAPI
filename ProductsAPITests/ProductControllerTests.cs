using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Products.Core;
using ProductsAPI.Controllers;
using System.Web.Http.Results;
using Products.Core.Repositories;
using Products.Core.Domain;

namespace ProductsAPITests
{
    [TestFixture]
    class ProductControllerTests
    {
        [Test]
        public void GetProducts_WhenCalled_ReturnsOK()
        {
            //Arrange
            var unitOfWork = new Mock<IUnitOfWork>();
            var productsRepository = new Mock<IProductRepository>();
            unitOfWork.Setup(m => m.Products).Returns(productsRepository.Object);
            var controller = new ProductsController(unitOfWork.Object);

            //Act
            var result = controller.GetProducts();

            //Assert           
            unitOfWork.Verify(u => u.Products.GetAll());
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<IEnumerable<Product>>>());
        }
    }
}
