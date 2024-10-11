namespace Common
{
    public class DbContextSettings
    {
        public const string SectionName = nameof(DbContextSettings);
        public string ConnectionString { get; init; } = string.Empty;
    }
}
