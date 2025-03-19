using AutoMapper;
using CAExample.Application.Repository;
using CAExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAExample.Application.Cities
{
    public class CityService : ICityService
    {
        private readonly IBaseRepository<City> _cityRepository;
        private readonly IMapper _mapper;

        public CityService(IBaseRepository<City> cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }

        public async Task AddCityAsync(CityVM city)
        {
            var cityToCreate = _mapper.Map<City>(city);   

            await _cityRepository.AddAsync(cityToCreate);
        }

        public Task DeleteCityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CityVM>> GetAllCitiesAsync()
        {
            var cities = await _cityRepository.GetAllAsync();

            return _mapper.Map<List<CityVM>>(cities);
        }

        public Task<CityVM> GetCityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CityVM> GetCityByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCityAsync(int id, CityVM city)
        {
            throw new NotImplementedException();
        }
    }
}
