using EjercicioClase.View;
using Newtonsoft.Json;
using tiendaCampus;
using tiendaCampus.Entities;
using tiendaCampus.View;

internal class Program
{
    private static void Main()
    {
        int opcion;
        int opcionBusqueda;
        if (Env.ValidarFile(Env.FileName) == false)
        {
            File.WriteAllText(Env.FileName, "");
        }else{
            Env.LoadDataProductos(Env.FileName);
        }
        Env.ImprimirData("Categorias\n", Env.TiendaCampus.Categorias);
        Env.ImprimirData("Productos\n", Env.TiendaCampus.Productos);

        do
        {
            opcion = menusView.MenuPrincipal();
            switch (opcion)
            {
                case 1:
                    Producto.AddProducto();
                    string jsonProducto = JsonConvert.SerializeObject(Env.TiendaCampus, Formatting.Indented);
                    File.WriteAllText(Env.FileName, jsonProducto);
                    break;
                case 2:
                    Categoria.AddCategoria();
                    string jsonCategoria = JsonConvert.SerializeObject(Env.TiendaCampus, Formatting.Indented);
                    File.WriteAllText(Env.FileName, jsonCategoria);
                    break;
                case 3:
                    opcionBusqueda = menuBuscar.MenuBusqueda();
                    switch (opcionBusqueda)
                    {
                        case 1:
                            Env.ImprimirData("Productos\n", Env.TiendaCampus.Productos);
                            break;
                        case 2:
                            Env.ImprimirData("Categorias\n", Env.TiendaCampus.Categorias);
                            break;
                    }
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }
}