using CleanApi.Application.Interfaces;
using CleanApi.Domain.Entities;

namespace CleanApi.Application.UseCases;

public class GetAllProductsUseCase : IUseCase<IEnumerable<Product>>
{
    private readonly IRepository<Product, Guid> _repository;

    public GetAllProductsUseCase(IRepository<Product, Guid> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> ExecuteAsync()
    {
        return await _repository.GetAllAsync();
    }
}