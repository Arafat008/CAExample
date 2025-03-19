using CAExample.Domain.Entities;

namespace CAExample.Application.Cities
{
    public interface ICityService
    {
        Task<IList<CityVM>> GetAllCitiesAsync();
        Task AddCityAsync(CityVM city);
        Task UpdateCityAsync(int id, CityVM city);
        Task DeleteCityAsync(int id);
        Task<CityVM> GetCityByIdAsync(int id);
        Task<CityVM> GetCityByNameAsync(String name);
    }
}
