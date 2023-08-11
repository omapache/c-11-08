namespace EjercicioClase.View;

    public class menuBuscar
    {
        public static int MenuBusqueda(){
            Console.Clear();
            Console.WriteLine("1.mirar Productos");
            Console.WriteLine("2.mirar Categorias");
            Console.WriteLine("3.Salir");
            return int.Parse(Console.ReadLine());
        }
    }
