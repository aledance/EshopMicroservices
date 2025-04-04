namespace CatalogApi.Modls
{
    public class Product
    {
        public Guid Id { get; set; } // el tipo guid es un tipo de dato que se utiliza para identificar de manera única un objeto o entidad en un sistema.
        public string Name { get; set; } = default!;
        public List<string> Category { get; set; } = new();
        public string Description { get; set; } = default!; // el operador de asignación de valor por defecto (default!) se utiliza para indicar que la propiedad no puede ser nula, pero no se le asigna un valor inicial.
        public string ImageFile { get; set; } = default!;

        public decimal Price { get; set; }

    }
}
