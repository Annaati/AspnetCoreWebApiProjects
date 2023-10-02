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

            if (result < 1) throw new BadHttpRequestException("Could not Save record", 500);

            return new ApiResponseVM<City>(true, 201, "Success", "City Created Successfuly", city );
        }

        
        
        public Task<ApiResponseVM<City>> UpdateCityAsync(Guid? cityId, CityEditReq? req)
        {
            throw new NotImplementedException();
        }
        
        
        
        public Task<ApiResponseVM<City>> DeleteCityAsync(Guid? cityId)
        {
            throw new NotImplementedException();
        }

        #endregion




        #region ReUsable Methods Section

        #endregion


    }
}
