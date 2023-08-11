using tiendaCampus.Entities;
namespace tiendaCampus;
using System.Text.Json;
    public class Env
    {
        private static string fileName = "TiendaCampus.json";
        private static TiendaCampus tiendaCampus = new();

        public static string FileName { get => fileName; set => fileName = value; }
        public static TiendaCampus TiendaCampus { get => tiendaCampus; set => tiendaCampus = value; }

        public static void LoadDataProductos(string nombreArchivo)
        {
            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                string json = reader.ReadToEnd();
                Env.TiendaCampus = JsonSerializer.Deserialize<TiendaCampus>(json, new JsonSerializerOptions() 
                { PropertyNameCaseInsensitive = true }) ?? new TiendaCampus();
            }
        }
        public static bool ValidarFile(string fileName){
            if(!File.Exists(fileName)){
                return false;
            }
            return true;
        }
        public static void ImprimirData<T>(string titulo, IEnumerable<T> lista){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n{titulo,-30}");
            foreach(var elemento in lista){
                Type tipoClase = elemento.GetType();
                var propiedades = tipoClase.GetProperties();
                foreach(var propiedad in propiedades){
                    Console.WriteLine($"    {propiedad.Name}: {propiedad.GetValue(elemento)}");
                }
            Console.WriteLine($"*******************************************");
            }
            
            Console.ReadKey();
        }
    }
