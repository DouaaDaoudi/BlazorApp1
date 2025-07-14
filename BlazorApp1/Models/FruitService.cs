namespace BlazorApp1.Models
{
    public class FruitService
    {
        public Task<List<Fruit>> GetFruitsAsync()
        {
            var fruits = new List<Fruit>
        {
            new Fruit { Name = "Apple", Available = "Yes", Season = "Fall" },
            new Fruit { Name = "Banana", Available = "Yes", Season = "Year-round" },
            new Fruit { Name = "Mango", Available = "No", Season = "Summer" }
        };

            return Task.FromResult(fruits);
        }
}
