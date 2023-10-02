using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CitiesManager.WebAPI.Entities;

namespace CitiesManager.WebAPI.DTO.Cities
{
    public class CityRes
    {
        [Display(Name = "City Id")]
        public Guid CityId { get; set; }

        [Display(Name = "City Code")]
        public string CityCode { get; set; }

        [Display(Name = "City Name")]
        public string CityName { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        [Display(Name = "Registered At")]
        public DateTime RegAt { get; set; }

        public string? Status { get; set; }

    }

    public static class CityExtension
    {
        public static CityRes ToCityRes(this City city)
        {
            return new CityRes
            {
                CityId = city.CityId,
                CityCode = city.CityCode,
                CityName = city.CityName,
                Latitude = city.Latitude,
                Longitude = city.Longitude,
                RegAt = city.RegAt,
                Status = city.Status
            };
        }
    }

}
