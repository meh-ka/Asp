using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using model_binding_attributes.Models;

namespace model_binding_attributes.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index([Bind("name,family,age")]Person person )
        {
            person.Id= 202;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
                
            }
            return Ok(person);
        }

     

        public IActionResult Index2(int id, string name, string family,[BindRequired] int age)
        {
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            return Ok("ok");
        }

        public IActionResult Index3(Person person)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            return Ok("ok");
        }
    }
}
