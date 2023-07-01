using Microsoft.AspNetCore.Mvc;
using WebApi_A1m.Model;
using WebApi_A1m.Service;

namespace WebApi_A1m.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProducto _producto;
        public ProductoController(IProducto producto) 
        {
            _producto= producto;    
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_producto.GetAllProducts());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var obj = _producto.ObtenerPorId(id);
            if (obj == null)
            {
                var error = NotFound("El producto(" + id.ToString() + ") no existe");
                return error;
            }
            else
            { 
                return Ok(obj);
            }
        }
        [HttpPost("agregar")]
        public IActionResult add(Producto obj)
        {
            _producto.add(obj);
            return CreatedAtAction(nameof(add), obj);
        }
        [HttpDelete("eliminar/{id}")]
        public IActionResult delete(int id) 
        { 
            _producto.eliminar(id);
            return NoContent();
        }
        [HttpPut("modificar")]
        public IActionResult put(Producto obj)
        {
            _producto.modificar(obj);
            return CreatedAtAction(nameof(put), obj);
        }
    }
}
