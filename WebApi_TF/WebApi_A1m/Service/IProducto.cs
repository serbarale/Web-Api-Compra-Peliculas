using WebApi_A1m.Model;

namespace WebApi_A1m.Service
{
    public interface IProducto
    {
        IEnumerable<Producto> GetAllProducts();
        Producto ObtenerPorId(int id);
        void add(Producto obj);
        void modificar(Producto obj);
        void eliminar(int id);
    }
}
