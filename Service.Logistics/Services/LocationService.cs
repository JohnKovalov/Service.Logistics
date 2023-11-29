using AutoMapper;
using Service.Logistics.Extensions;
using Service.Logistics.Models;

namespace Service.Logistics.Services
{
    /// <inheritdoc/>
    public class LocationService : ILocationService
    {
        private readonly IFetchTruckData truckDataFetcher;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instane of the < see cref="LocationService"/> class
        /// </summary>
        /// <param name="truckDataFetcher">Data fetcher service.</param>
        /// <param name="mapper">Mapper.</param>
        public LocationService(
            IFetchTruckData truckDataFetcher,
            IMapper mapper)
        {
            this.truckDataFetcher = truckDataFetcher;
            this.mapper = mapper;
        }

        /// <inheritdoc/>
        public async Task<IReadOnlyCollection<TruckResponseDto>> FindTrucks(TruckModel request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Request parameter cannot be null.");
            }

            var truckData = await truckDataFetcher.Fetch();

            if (truckData == null || !truckData.Any())
            {
                return new List<TruckResponseDto>();
            }

            truckData = truckData
                .Where(t => t.FoodItems != null && t.FoodItems.ToLower().Contains(request.PreferredFood.ToLower()))
                .OrderBy(t => GeoCalculator.CalculateHaversineDistance(t.Location.Latitude, t.Location.Longitude, request.Latitude, request.Longitude))
                .Take(request.ResultsCount)
                .ToList();

            return truckData.Select(t => mapper.Map<TruckResponseDto>(t)).ToList();
        }
    }
}
