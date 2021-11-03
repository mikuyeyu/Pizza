namespace Pizza.Entities
{
    public class Cat : IAnimal
    {
        public string Name { get; init; }

        public string GetSound()
        {
            return "nya nya";
        }
    }
}
