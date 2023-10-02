using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CitiesManager.WebAPI.Entities
{
    [Table("tblCities", Schema="CitiesManagerDb")]
    public class City
    {
        [Key]
        [Column("cityId")]
        public Guid CityId { get; set; }

        [Column("cityCode")]
        public string CityCode { get; set; }

        [Column("cityName")]
        public string CityName { get; set; }

        [Column("latitude")]
        [DataType("decimal(18,18)")]
        public decimal? Latitude { get; set; }

        [Column("longitude")]
        [DataType("decimal(18,18)")]
        public decimal? Longitude { get; set; }

        [Column("regAt")]
        public DateTime RegAt { get; set; }

        [Column("status")]
        public string Status { get; set; }

    }
}
