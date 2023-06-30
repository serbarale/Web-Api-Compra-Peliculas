using Microsoft.AspNetCore.Mvc;
using WebApi_D1M.Models;
using WebApi_D1M.Services;

namespace WebApi_D1M.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        public readonly IProducto _producto;
        public ProductoController(IProducto producto) 
        {
            producto = _producto;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_producto.GetAllProducts()); //Retorna un JSON
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var objEncontrado = _producto.ProductoById(id);
            if (objEncontrado == null)
            {
                var error = NotFound("El codigo (" + id.ToString() + ") no existe!");
                return error;
            }
            return Ok(objEncontrado); //Retorna un JSON dependiendo del ID
        }
        
        [HttpPost("Agregar")]
        public IActionResult Agregar(Producto obj)
        {
            _producto.add(obj);
            return CreatedAtAction(nameof(Agregar), obj);
        }

        [HttpDelete("Eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            _producto.delete(id);
            return NoContent();
        }

        [HttpPut("Modificar")]
        public IActionResult Modificar(Producto obj)
        {
            _producto.update(obj);
            return CreatedAtAction(nameof(Modificar), obj);
        }
    }
}
