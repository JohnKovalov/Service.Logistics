using Newtonsoft.Json;
using Service.Logistics.Constants;
using Service.Logistics.Models;

namespace Service.Logistics.Services
{
    /// <inheritdoc/>
    public class FetchTruckData : IFetchTruckData
    {
        /// <inheritdoc/>
        public async Task<List<TruckDataModel>> Fetch()
        {
            try
            {
                var httpClient = new HttpClient();
                var response = await httpClient.GetStringAsync(RequestContstants.DataUrl);
                if (string.IsNullOrEmpty(response))
                {
                    Console.WriteLine("Response is null or empty.");
                    return new List<TruckDataModel>();
                }

                var truckData = JsonConvert.DeserializeObject<List<TruckDataModel>>(response);

                if (truckData == null)
                {
                    Console.WriteLine("Deserialization resulted in null data.");
                    return new List<TruckDataModel>();
                }

                return truckData;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP request error: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON deserialization error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }
    }
}
