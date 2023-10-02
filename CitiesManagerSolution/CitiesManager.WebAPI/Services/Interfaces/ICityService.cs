using CitiesManager.WebAPI.DTO.Cities;
using CitiesManager.WebAPI.DTO.ViewModels;
using CitiesManager.WebAPI.Entities;

namespace CitiesManager.WebAPI.Services.Interfaces
{
    /// <summary>
    /// Represents Intreacting/Manipulating City Entity
    /// </summary>
    public interface ICityService
    {

        /// <summary>
        /// Gets All the existing Cities
        /// </summary>
        /// <returns>All Cities as ApiResponseVM of CityRes Object List </returns>
        Task<ApiResponseVM<IEnumerable<CityRes>>> GetAllCitiesAsync();



        /// <summary>
        /// Gets City By City Id
        /// </summary>
        /// <param name="cityId">The City id to be return</param>
        /// <returns>The City that matches the specified City Id as APiResponseVm of Of CityRes Object</returns>
        Task<ApiResponseVM<CityRes>> GetCityByIdAsync(Guid? cityId);



        /// <summary>
        /// Adds a new City to the existing Cities
        /// </summary>
        /// <param name="req">the new City to be added</param>
        /// <returns>APiResponseVM of CityAddReq containing true/false, StatusCode, Title, Message and CityRes Object</returns>
        Task<ApiResponseVM<City>> AddCityAsync(CityAddReq? req);



        /// <summary>
        /// Updates a City
        /// </summary>
        /// <param name="cityId">The Id of the City to be updated</param>
        /// <param name="req">The new City Object to Update to</param>
        /// <returns>APiResponseVM of CityAddReq containing true/false, StatusCode, Title, Message and CityRes Object</returns>
        Task<ApiResponseVM<City>> UpdateCityAsync(Guid? cityId, CityEditReq? req);



        /// <summary>
        /// Deletes a City 
        /// </summary>
        /// <param name="cityId">The Id of the City to be deleted</param>
        /// <returns>APiResponseVM of CityAddReq containing true/false, StatusCode, Title, Message and Null Data</returns>
        Task<ApiResponseVM<City>> DeleteCityAsync(Guid? cityId);



    }
}
