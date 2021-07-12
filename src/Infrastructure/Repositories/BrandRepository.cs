using Eventinars.Application.Interfaces.Repositories;
using Eventinars.Domain.Entities.Catalog;

namespace Eventinars.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}