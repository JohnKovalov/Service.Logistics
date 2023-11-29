using Service.Logistics.Infrustructure.AutoMapper;
using Service.Logistics.Services;

namespace Service.Logistics
{
    public class Startup
    {
        /// <summary>
        /// Gets or sets the application configuration.
        /// </summary>
        public IConfiguration Configuration { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Startup" /> class.
        /// </summary>
        /// <param name="configuration">The current configuration..</param>
        /// <param name="environment">The current environment variable.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = new ConfigurationBuilder()
                .AddConfiguration(configuration)
                .Build();
        }

        /// <summary>
        /// Configures the application services.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IFetchTruckData, FetchTruckData>();
            services.AddCustomAutoMapper();
        }
    }
}
