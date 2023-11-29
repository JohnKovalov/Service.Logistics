using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Logistics.Models;
using Service.Logistics.Services;

namespace Service.Logistics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : Controller
    {
        private readonly ILocationService locationService;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationController"/> class.
        /// </summary>
        /// <param name="locationService">The location service.</param>
        /// <param name="mapper">The mapper.</param>
        public LocationController(
            ILocationService locationService,
            IMapper mapper)
        {
            this.locationService = locationService;
            this.mapper = mapper;
        }

        /// <summary>
        /// Finds nearby trucks.
        /// </summary>
        /// <param name="request">The request to trucks data.</param>
        /// <returns>
        /// The list of nearby trucks.
        /// </returns>
        [HttpPost]
        [Route("FindTruck")]
        public async Task<IReadOnlyCollection<TruckResponseDto>> FindTruck([FromBody] TruckRequest request)
        {
            return await locationService.FindTrucks(this.mapper.Map<TruckModel>(request));
        }
    }
}
