namespace Save__Your__Apps
{
    public class DBconnect
    {
        public static IConfiguration Configuration { get; set; }
        public static void Init()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("DBconnect.json", optional: false);
            Configuration = builder.Build();
        }
    }
}
