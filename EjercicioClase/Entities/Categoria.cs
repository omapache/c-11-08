namespace tiendaCampus.Entities;

    public class Categoria
    {
        private int id;
        private string description;
        public int Id 
        {
            get{return this.id;}
            set{this.id = value;} 
        }
        public string Description 
        {
            get{return this.description;}
            set{this.description = value;} 
        }
        public static void AddCategoria(){
            Categoria cat = new Categoria();
            Console.Write("Ingrese el id de la categoria :");
            cat.Id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el Nombre de la categoria :");
            cat.Description = Console.ReadLine();
            Env.TiendaCampus.Categorias.Add(cat);
        }

        public IEnumerable<Categoria> ListaCategorias(){
            return from cat in Env.TiendaCampus.Categorias
                select cat;
        }
    }
