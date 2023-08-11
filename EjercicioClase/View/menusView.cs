namespace tiendaCampus.View;

    public class menusView
    {
        public static int MenuPrincipal(){
            Console.Clear();
            Console.WriteLine("1.registro de Productos");
            Console.WriteLine("2.registro de Categorias");
            Console.WriteLine("3.Mostrar");
            Console.WriteLine("4.Salir");
            return int.Parse(Console.ReadLine());
        }
    }
