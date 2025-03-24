namespace BlazorApp1.Services
{
    public class NumberService : INumberService
    {
        public int Number1 { get; private set; }

        public int Number2 { get; private set; }

        public NumberService()
        {
            Number1 = Random.Shared.Next(1, 1000);
            Number2 = Random.Shared.Next(1, 1000);
        }
    }
}
