namespace DocumentFactory
{
    public class Page
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"#{Number} -> {Name}";
        }
    }
}