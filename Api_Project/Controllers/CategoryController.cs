using Api_Project.DAL;
using Api_Project.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        Context context = new Context();

        [HttpGet]

        public IActionResult CategoryList()
        {
            var values = context.Categories.ToList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddCategory(Category category)
        {

            context.Categories.Add(category);
            context.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]

        public IActionResult GetCategory(int id)
        {
            var values = context.Categories.Find(id);
            return Ok(values);
        }


        [HttpDelete("{id}")]
        public IActionResult DeteleCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IActionResult CategoryUpdate(Category category)
        {
            var values = context.Categories.Find(category.CategoryID);
            values.Name = category.Name;
            values.Description = category.Description;
            values.Status = category.Status;
            context.SaveChanges();
            return Ok();
        }
    }
}
