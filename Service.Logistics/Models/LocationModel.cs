using Newtonsoft.Json;

namespace Service.Logistics.Models
{
    /// <summary>
    /// Provides model for truck location.
    /// </summary>
    public class LocationModel
    {
        /// <summary>
        /// Gets or sets latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets property longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets truck address.
        /// </summary>
        [JsonProperty("human_address")]
        public string HumanAddress { get; set; }
    }
}
