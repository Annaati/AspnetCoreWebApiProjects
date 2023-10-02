using CitiesManager.WebAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace CitiesManager.WebAPI.DTO.Cities
{
    public class CityAddReq
    {
        [Display(Name = "City Code")]
        [Required(ErrorMessage = "City Code cannot be empty")]
        public string CityCode { get; set; }

        [Display(Name = "City Name")]
        [Required(ErrorMessage = "City Name cannot be empty")]
        public string CityName { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public City ToCity()
        {
            return new City()
            {
                CityId = Guid.NewGuid(),
                CityCode = CityCode,
                CityName = CityName,
                Latitude = Latitude,
                Longitude = Longitude,
                //RegAt = DateTime.Now,
                Status = "active"
            };
        }
    }
}
