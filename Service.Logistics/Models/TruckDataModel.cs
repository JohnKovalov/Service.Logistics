using Newtonsoft.Json;

namespace Service.Logistics.Models
{
    public class TruckDataModel
    {
        public string ObjectID { get; set; }

        public string Applicant { get; set; }

        public string FacilityType { get; set; }

        public string CNN { get; set; }

        public string LocationDescription { get; set; }

        public string Address { get; set; }

        public string BlockLot { get; set; }

        public string Block { get; set; }

        public string Lot { get; set; }

        public string Permit { get; set; }

        public string Status { get; set; }

        public string FoodItems { get; set; }

        public string X { get; set; }

        public string Y { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string Schedule { get; set; }

        public DateTime Approved { get; set; }

        public string Received { get; set; }

        public string PriorPermit { get; set; }

        public DateTime ExpirationDate { get; set; }

        public LocationModel Location { get; set; }

        [JsonProperty(":@computed_region_yftq_j783")]
        public string ComputedRegionYftqJ783 { get; set; }

        [JsonProperty(":@computed_region_p5aj_wyqh")]
        public string ComputedRegionP5ajWyqh { get; set; }

        [JsonProperty(":@computed_region_rxqg_mtj9")]
        public string ComputedRegionRxqgMtj9 { get; set; }

        [JsonProperty(":@computed_region_bh8s_q3mv")]
        public string ComputedRegionBh8sQ3mv { get; set; }

        [JsonProperty(":@computed_region_fyvs_ahh9")]
        public string ComputedRegionFyvsAhh9 { get; set; }
    }
}
