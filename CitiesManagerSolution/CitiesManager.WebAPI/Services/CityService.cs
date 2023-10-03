using CitiesManager.WebAPI.Data;
using CitiesManager.WebAPI.DTO.Cities;
using CitiesManager.WebAPI.DTO.ViewModels;
using CitiesManager.WebAPI.Entities;
using CitiesManager.WebAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.Services
{
    public class CityService : ICityService
    {

        #region DI Section

        private readonly MsSqlDbContext _dbContext;

        public CityService(MsSqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion


        #region Records Section

        public async Task<ApiResponseVM<IEnumerable<CityRes>>> GetAllCitiesAsync()
        {
            var cities = await _dbContext.Cities.Select(c => c.ToCityRes()).ToListAsync();

            return new ApiResponseVM<IEnumerable<CityRes>>(true, 200, "success", "Cities Fetched Successfully", cities);
        }


        
        public async Task<ApiResponseVM<CityRes>> GetCityByIdAsync(Guid? cityId)
        {
            var city = await _dbContext.Cities.Select(c => c.ToCityRes()).Where(c=>c.CityId==cityId).FirstOrDefaultAsync();

            //var city = _dbContext.Cities.Select(c => c.ToCityRes()).FirstOrDefaultAsync(city=>city.CityId==cityId);

            //city = await _dbContext.Cities.Where(c => c.CityId == cityId).FirstOrDefaultAsync();
            

            return new ApiResponseVM<CityRes>(true, 200, "success", "Cities Fetched Successfully", city);
        }

        #endregion


        #region Actions Section

        public async Task<ApiResponseVM<City>> AddCityAsync(CityAddReq? req)
        {
            if(req == null)
                throw new ArgumentNullException("Provide All required Data", nameof(req));

            var city = req.ToCity();

            await _dbContext.Cities.AddAsync(city);
            var result = _dbContext.SaveChanges();

            if (result < 1) return new ApiResponseVM<City>(false, 500, "error", "Couldn't save City details", null); //throw new BadHttpRequestException("Could not Save record", 500);

            return new ApiResponseVM<City>(true, 201, "success", "City Created Successfuly", city);
        }

        
        
        public async Task<ApiResponseVM<City>> UpdateCityAsync(Guid? cityId, CityEditReq? req)
        {
            if (cityId == null) throw new ArgumentNullException(nameof(cityId), "City id cannot be empty");

            if(req == null) throw new ArgumentNullException (nameof(req), "Please Provide all required data");

            var existingCity = await _dbContext.Cities.FirstOrDefaultAsync(c=>c.CityId==cityId) 
                ?? throw new BadHttpRequestException("No City Record Matching the the specified City id was found", 404);

            existingCity.CityCode = req.CityCode;
            existingCity.CityName = req.CityName;
            existingCity.Latitude = req.Latitude;
            existingCity.Longitude = req.Longitude;
            existingCity.Status = req.Status;

            //_dbContext.Cities.Update(existingCity);
            var result = await _dbContext.SaveChangesAsync();

            if (result < 1) return new ApiResponseVM<City>(false, 500, "error", "Couldn't update City details", null);

            return new ApiResponseVM<City>(true, 204, "success", "City details updated successfully", existingCity);
        }
        
        
        
        public async Task<ApiResponseVM<City>> DeleteCityAsync(Guid? cityId)
        {
            if (cityId == null) throw new ArgumentNullException(nameof(cityId), "City id cannot be empty");

            var city = await _dbContext.Cities.FirstOrDefaultAsync(c=>c.CityId==cityId) 
                ?? throw new BadHttpRequestException("No City record with the specified city id was found", 404);

             _dbContext.Cities.Remove(city);

            var result = await _dbContext.SaveChangesAsync();

            if (result < 1) return new ApiResponseVM<City>(false, 500, "error", "Couldn't delete city record", null);

            return new ApiResponseVM<City>(true, 204, "success", "City record deleted successfully", null);
        }

        #endregion




        #region ReUsable Methods Section

        #endregion


    }
}
