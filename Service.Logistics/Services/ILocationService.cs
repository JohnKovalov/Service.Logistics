using Service.Logistics.Models;

namespace Service.Logistics.Services
{
    /// <summary>
    /// Provides methods for truck location.
    /// </summary>
    public interface ILocationService
    {
        /// <summary>
        /// Finds nearby trucks.
        /// </summary>
        /// <param name="request">The truck request.</param>
        /// <returns>Collection of nearby trucks.</returns>
        Task<IReadOnlyCollection<TruckResponseDto>> FindTrucks(TruckModel request);
    }
}
