
namespace tiendaCampus.Entities;
using Newtonsoft.Json;

    public class Producto
    {
        public string IdProducto {get; set;}
        public string NombreProducto {get; set;}
        public int Stock {get; set;}
        public int StockMin {get; set;}
        public int StockMax {get; set;}
        public double ValorVenta {get; set;}
        public double ValorCompra {get; set;}
        public string IdCategoria {get; set;} 

        public Producto()
        {
            if(!File.Exists(Env.FileName))
            {
                File.WriteAllText(Env.FileName, "");
            }
        }

        public static void AddProducto(){
            Producto p = new();
            Console.Clear();
            Console.WriteLine("Ingrese el id producto: ");
            p.IdProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del producto");
            p.NombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el Stock del producto");
            p.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Stock minimo del producto");
            p.StockMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Stock maximo del producto");
            p.StockMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Valor de la venta del producto");
            p.ValorVenta = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Valor de la compra del producto");
            p.ValorCompra = double.Parse(Console.ReadLine());
            Env.ImprimirData("Categorias\n", Env.TiendaCampus.Categorias);
            Console.WriteLine("Ingrese el id de la categoria");
            p.IdCategoria = Console.ReadLine();
            Env.TiendaCampus.Productos.Add(p); 
        }
    }
