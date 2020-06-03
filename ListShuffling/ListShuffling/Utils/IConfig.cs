namespace ListShuffling
{
    public interface IConfig
    {
        public FileHandlerConfig FileNames { get; set; }
        public ShufflerConfig ShuffleType { get; set; }
    }
}