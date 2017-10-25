namespace WebScrape.Buisness
{
    public class Url
    {
        public int Level { get; set; } 
        public string Name { get; set; }
        public Url Parent { get; set; }
    }
}
