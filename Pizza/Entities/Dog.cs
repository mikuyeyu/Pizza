namespace Pizza.Entities
{
    public class Dog : IAnimal
    {
        public string Name { get; init; }

        public string GetSound()
        {
            return "bark bark";
        }
    }
}
