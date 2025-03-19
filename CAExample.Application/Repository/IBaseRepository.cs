using CAExample.Domain.Common;

namespace CAExample.Application.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public IQueryable<T> Table { get; }

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
