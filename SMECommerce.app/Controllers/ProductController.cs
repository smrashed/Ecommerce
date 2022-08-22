using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMECommerce.app.Models.ProductModels;
using SMECommerce.Models.EntityModels;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.app.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IWebHostEnvironment webHostEnvironment,
            IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Create()
        {
            ProductCreate model = new ProductCreate();
            //model.ManufacturerDate = DateTime.Now;
            ICollection<Category> categoryList = _categoryService.GetAll();
            model.Categories = new SelectList(categoryList, "Id", "Name");
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ProductCreate model)
        {
            if (model.Name != null)
            {
                if(model.ProductPhoto != null)
                {
                    string folder = "image/product/";
                    model.ProductPhotoUrl = UploadImage(folder, model.ProductPhoto);
                }

                var product = new Item()
                {
                    Name = model.Name,
                    Price = model.Price,
                    ManufacturerDate = model.ManufacturerDate,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                    ImageName = model.ProductPhotoUrl
                };
                var isAdded = _productService.Add(product);
                if (isAdded)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }
        public IActionResult List()
        {
            var productList = _productService.GetAll();

            var productListVm = new ProductListVm()
            {
                Title = "Product Overview",
                Description = "You can perform crud operations here...",
                ProductList = productList.ToList()
            };
            return View(productListVm);

        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("List");
            }
            var product = _productService.GetById((int)Id);
            ICollection<Category> categoryList = _categoryService.GetAll();
            if (product == null)
            {
                return RedirectToAction("List");
            }
           
            var productEditVm = new ProductEditVm()
            {
                //Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ManufacturerDate = product.ManufacturerDate,
                Description = product.Description,
                CategoryId = product.CategoryId,
                Categories = new SelectList(categoryList, "Id", "Name"),
                ProductPhotoUrl = product.ImageName,
                 
            };
            
            return View(productEditVm);            
        }
        [HttpPost]
        public IActionResult Edit(ProductEditVm model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProductPhoto != null)
                {
                    string folder = "image/product/";
                    model.ProductPhotoUrl = UploadImage(folder, model.ProductPhoto);
                }
                var product = new Item()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Price = model.Price,
                    ManufacturerDate = model.ManufacturerDate,
                    Description = model.Description,
                    CategoryId = model.CategoryId,
                    ImageName = model.ProductPhotoUrl
                };

                bool isUpdated = _productService.Update(product);
                if (isUpdated)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }

            var product = _productService.GetById((int)id);
            if (product == null)
            {
                return RedirectToAction("List");
            }

            bool isRemoved = _productService.Remove(product);
            if (isRemoved)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("List");
            }
            var product = _productService.GetById((int)id);
            var category = _categoryService.CategoryName((int)product.CategoryId);
            if (product == null)
            {
                return RedirectToAction("List");
            }
            var productDetails = new ProductDetails()
            {           
                Name = product.Name,
                Price = product.Price,
                ManufactureDate = product.ManufacturerDate,
                Description = product.Description,
                CategoryId = product.CategoryId,
                CategoryName = category.Name,
                ProductPhotoUrl = product.ImageName
            };
            return View(productDetails);
        }
        public string UploadImage(string folderPath, IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        } 
    }
}
