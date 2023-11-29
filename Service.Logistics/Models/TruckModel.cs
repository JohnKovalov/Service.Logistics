namespace Service.Logistics.Models
{
    /// <summary>
    /// Provides model for truck.
    /// </summary>
    public class TruckModel
    {
        /// <summary>
        /// Gets or sets latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets results count.
        /// </summary>
        public int ResultsCount { get; set; }

        /// <summary>
        /// Gets or sets preffered food.
        /// </summary>
        public string PreferredFood { get; set; }
    }
}
