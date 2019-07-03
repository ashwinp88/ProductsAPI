using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Products.Core;
using Products.Core.Domain;


namespace ProductsAPI.Controllers
{
    public class ProductsController : ApiController
    {
        //private ProductContext db = new ProductContext();
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        public IHttpActionResult GetProducts()
        {
            var res = _unitOfWork.Products.GetAll();
            return Ok(res);
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            var product = _unitOfWork.Products.Get(id);            
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            if (!ProductExists(id))
            {
                return NotFound();
            }
            else
            {
                var curProduct = _unitOfWork.Products.Get(id);
                curProduct.Description = product.Description;
                curProduct.Name = product.Name;
                curProduct.Price = product.Price;
                curProduct.IsPublished = product.IsPublished;
            }
            _unitOfWork.Complete();
            return Ok();
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
        
            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = _unitOfWork.Products.Get(id);
            if (product == null)
            {
                return NotFound();
            }

            _unitOfWork.Products.Remove(product);
            _unitOfWork.Complete();
            return Ok(product);
        }

        private bool ProductExists(int id)
        {
            var product = _unitOfWork.Products.Get(id);
            return product != null;
        }
    }
}