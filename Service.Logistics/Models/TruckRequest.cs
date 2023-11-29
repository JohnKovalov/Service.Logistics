using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Service.Logistics.Models
{
    /// <summary>
    /// Provides request dto for truck.
    /// </summary>
    public class TruckRequest
    {
        /// <summary>
        /// Gets or sets latitude.
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        [Required(ErrorMessage = "Latitude value is required.")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets longitude.
        /// </summary>
        [JsonProperty(PropertyName = "propertyName")]
        [Required(ErrorMessage = "Longitude value is required.")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets results count.
        /// </summary>
        [JsonProperty(PropertyName = "resultsCount")]
        [Required(ErrorMessage = "Results count can not be null.")]
        public int ResultsCount { get; set; }

        /// <summary>
        /// Gets or sets preffered food.
        /// </summary>
        [JsonProperty(PropertyName = "preferredFood")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "Preffered food must be between 3 and 300 characters.")]
        public string PreferredFood { get; set; }
    }
}
