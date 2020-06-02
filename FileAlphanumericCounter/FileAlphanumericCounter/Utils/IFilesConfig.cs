namespace FileAlphanumericCounter
{
    public interface IFilesConfig
    {
        public string[] AllowedExtensions { get; set; }
        public string RegexPattern { get; set; }
    }
}