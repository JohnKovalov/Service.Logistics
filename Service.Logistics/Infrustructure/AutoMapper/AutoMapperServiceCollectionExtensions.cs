using AutoMapper;

namespace Service.Logistics.Infrustructure.AutoMapper
{

    /// <summary>
    /// Provides extension methods for <see cref="IServiceCollection"/> for AutoMapper configuration.
    /// </summary>
    public static class AutoMapperServiceCollectionExtensions
    {
        /// <summary>
        /// Adds AutoMapper and mapping profiles.
        /// </summary>
        /// <param name="services">The service collection.</param>
        public static void AddCustomAutoMapper(this IServiceCollection services)
        {
            services.AddSingleton(provider => CreateMapperConfiguration(provider).CreateMapper())
                .AddSingleton<Profile>(_ => new TruckRequestProfile());
        }

        private static MapperConfiguration CreateMapperConfiguration(IServiceProvider provider)
        {
            return new MapperConfiguration(c => c.AddProfiles(provider.GetServices<Profile>()));
        }
    }
}
