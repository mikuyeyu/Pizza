namespace Pizza.Entities
{
    public class Cow : IAnimal
    {
        public string Name { get; init; }
        public string GetSound() => "Moo Moo";
    }
}