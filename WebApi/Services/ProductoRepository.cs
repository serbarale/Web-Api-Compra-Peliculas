using WebApi_D1M.Models;

namespace WebApi_D1M.Services
{
    public class ProductoRepository : IProducto
    {
        public static List<Producto> lst = new List<Producto>()
        {
            new Producto() { id = 1, titulo = "Test", genero_id = 1, duracion = 120, sinopsis = "Prueba", fechaLanzamiento = "15/02/12", precio = 15.20, imagenURL = "urltest"},
            new Producto() { id = 2, titulo = "Test2", genero_id = 2, duracion = 180, sinopsis = "Prueba", fechaLanzamiento = "18/06/22", precio = 19.20, imagenURL = "urltest"},
            new Producto() { id = 3, titulo = "Test3", genero_id = 3, duracion = 240, sinopsis = "Prueba", fechaLanzamiento = "11/05/18", precio = 15.20, imagenURL = "urltest"}
        };

        public IEnumerable<Producto> GetAllProducts()
        {
            return lst;
        }

        public Producto ProductoById(int id)
        {
            return lst.Where(tpro => tpro.id == id).FirstOrDefault();
        }

        public void add(Producto producto)
        {
            lst.Add(producto);
        }

        public void delete(int id)
        {
            var objEncontrado = lst.Where(tpro => tpro.id == id).FirstOrDefault();
            lst.Remove(objEncontrado);
        }

        public void update(Producto p)
        {
            var objEncontrado = lst.Where(tpro => tpro.id == p.id).FirstOrDefault();
            objEncontrado.titulo = p.titulo;
            objEncontrado.genero_id = p.genero_id;
            objEncontrado.duracion = p.duracion;
            objEncontrado.sinopsis = p.sinopsis;
            objEncontrado.fechaLanzamiento = p.fechaLanzamiento;
            objEncontrado.precio = p.precio;
            objEncontrado.imagenURL = p.imagenURL;
        }
    }
}
