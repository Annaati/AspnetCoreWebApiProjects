using CitiesManager.WebAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WebAPI.DTO.Cities
{
    public class CityEditReq
    {
        [Display(Name = "City Code")]
        [Required(ErrorMessage = "City Code cannot be empty")]
        public string CityCode { get; set; }

        [Display(Name = "City Name")]
        [Required(ErrorMessage = "City Name cannot be empty")]
        public string CityName { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public string Status { get; set; }

        public City ToCity()
        {
            return new City()
            {
                CityCode = CityCode,
                CityName = CityName,
                Latitude = Latitude,
                Longitude = Longitude,
                Status = Status
            };
        }
    }
}
