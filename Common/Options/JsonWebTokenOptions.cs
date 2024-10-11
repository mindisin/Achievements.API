namespace Common.Options
{
    public class JsonWebTokenOptions
    {
        public string SecretKey { get; set; } = String.Empty;
        public int ExpiresHours { get; set; }
    }
}
