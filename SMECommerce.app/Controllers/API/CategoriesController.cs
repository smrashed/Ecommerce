using Microsoft.AspNetCore.Mvc;
using SMECommerce.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMECommerce.app.Models.CategoryModels;
using AutoMapper;
using SMECommerce.Models.EntityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace SMECommerce.app.Controllers.API
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Policy = "UserVerify")]
        public IActionResult GetCategories()
        {
            var categories = _categoryService.GetAll();
            if (categories == null)
            {
                return NoContent();
            }
            var categoryResults = _mapper.Map<IList<CategoryResultVm>>(categories);
            return Ok(categoryResults);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int? id)
        {
            if(id == null)
            {
                return BadRequest("Please provide id");
            }

            var category = _categoryService.GetById((int)id);
            if(category == null)
            {
                return NotFound();
            }

            var categoryResult = _mapper.Map<CategoryResultVm>(category);
            return Ok(categoryResult);
        }

        [HttpPost]
        public IActionResult Post([FromBody]CategoryCreate model)
        {
            if (ModelState.IsValid)
            {
                var category = _mapper.Map<Category>(model);

                var isSuccess = _categoryService.Add(category);
                if (isSuccess)
                {
                    return Created($"api/categories/{category.Id}", category);
                }

            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int? id, [FromBody] CategoryEditVm model)
        {
            if(id == null)
            {
                return BadRequest("Please provide id");
            }
            var category = _categoryService.GetById((int)id);
            if(category == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _mapper.Map(model, category);
                bool isSuccess = _categoryService.Update(category);
                if (isSuccess)
                {
                    return Ok(category);
                }
            }
            return BadRequest(ModelState);
        }



    }
}
