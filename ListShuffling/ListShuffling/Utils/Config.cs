namespace ListShuffling
{
    public class Config : IConfig
    {
        public FileHandlerConfig FileNames { get; set; }
        public ShufflerConfig ShuffleType { get; set; }
    }
}