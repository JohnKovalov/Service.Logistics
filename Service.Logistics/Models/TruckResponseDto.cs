namespace Service.Logistics.Models
{
    /// <summary>
    /// Provides request dto for truck responce.
    /// </summary>
    public class TruckResponseDto
    {
        /// <summary>
        /// Gets or sets truck id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets truck name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets preffered food.
        /// </summary>
        public string FoodItems { get; set; }
    }
}
