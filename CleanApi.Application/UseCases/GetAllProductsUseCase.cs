using CleanApi.Application.Interfaces;
using CleanApi.Domain.Entities;

namespace CleanApi.Application.UseCases;

public class GetAllProductsUseCase
{
    private readonly IProductRepository _repository;

    public GetAllProductsUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> ExecuteAsync()
    {
        return await _repository.GetAllAsync();
    }
}