
using CitiesManager.WebAPI.DTO.Cities;
using CitiesManager.WebAPI.DTO.ViewModels;
using CitiesManager.WebAPI.Entities;
using CitiesManager.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CitiesManager.WebAPI.Controllers
{
    public class CityController : ApiBaseController
    {

        #region DI Section

        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        #endregion



        #region Records Section

        [HttpGet]
        [ProducesResponseType(typeof(ApiResponseVM<IEnumerable<CityRes>>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ApiResponseVM<IEnumerable<CityRes>>>> GetAllCities()
        {
            var result = await _cityService.GetAllCitiesAsync();

            if (result.Data == null)
                return NotFound(result);

            return Ok(result);
        }


        [HttpGet("{cityId}")]
        [ProducesResponseType(typeof(ApiResponseVM<CityRes>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ApiResponseVM<CityRes>>> GetCityById(Guid? cityId)
        {
            var result = await _cityService.GetCityByIdAsync(cityId);

            if (result.Data == null)
                return NotFound(result);

            return Ok(result);
        }


        #endregion



        #region Actions Section

        [HttpPost]
        [ProducesResponseType(typeof(ApiResponseVM<City>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ApiResponseVM<City>>> AddCity(CityAddReq req)
        {
            var result = await _cityService.AddCityAsync(req);

            Response.StatusCode = result.StatusCode;

            if (result.Success == true)
                return CreatedAtAction("", new { cityId = result?.Data?.CityId }, req);

            return result;
        }


        [HttpPut("{cityId}")]
        [ProducesResponseType(typeof(ApiResponseVM<City>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ApiResponseVM<City>>> UpdateCity(Guid? cityId, [FromBody]CityEditReq req)
        {
            var result = await _cityService.UpdateCityAsync(cityId, req);

            Response.StatusCode = result.StatusCode;

            if (result.Success == true)
                return Ok(result);

            return result;
        }


        [HttpDelete("{cityId}")]
        [ProducesResponseType(typeof(ApiResponseVM<City>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ApiResponseVM<City>>> DeleteCity(Guid? cityId)
        {
            var result = await _cityService.DeleteCityAsync(cityId);

            Response.StatusCode = result.StatusCode;

            if (result.Success == true)
                return Ok(result);

            return result;
        }


        #endregion





    }
}
