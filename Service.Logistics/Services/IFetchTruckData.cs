using Service.Logistics.Models;

namespace Service.Logistics.Services
{
    /// <summary>
    /// Provides methods for fetching data.
    /// </summary>
    public interface IFetchTruckData
    {
        /// <summary>
        /// Fetches truck data.
        /// </summary>
        /// <returns>List of trucks.</returns>
        Task<List<TruckDataModel>> Fetch();
    }
}
