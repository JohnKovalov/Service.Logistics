using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Service.Logistics.Models
{
    /// <summary>
    /// Provides request DTO for a truck.
    /// </summary>
    public class TruckRequest
    {
        /// <summary>
        /// Gets or sets latitude.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets longitude.
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets results count.
        /// </summary>
        [JsonProperty(PropertyName = "resultsCount")]
        [Range(1, int.MaxValue, ErrorMessage = "Results count must be a positive integer.")]
        public int ResultsCount { get; set; }

        /// <summary>
        /// Gets or sets preferred food.
        /// </summary>
        [JsonProperty(PropertyName = "preferredFood")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "Preferred food must be between 3 and 300 characters.")]
        public string PreferredFood { get; set; }
    }
}
