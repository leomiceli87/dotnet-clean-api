using CleanApi.Application.UseCases;
using CleanApi.Domain.Entities;
using CleanApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanApi.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly GetAllProductsUseCase _getAllProductsUseCase;
    private readonly IProductRepository _repository;

    public ProductsController(GetAllProductsUseCase getAllProductsUseCase, IProductRepository repository)
    {
        _getAllProductsUseCase = getAllProductsUseCase;
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        var products = await _getAllProductsUseCase.ExecuteAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CreateProductRequest request)
    {
        var product = Product.Create(request.Name, request.Price);
        await _repository.AddAsync(product);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Delete(Guid id, [FromBody] CreateProductRequest request)
    {
        await _repository.GetByIdAsync(id);
        return NoContent();
    }
}

public record CreateProductRequest(string Name, decimal Price);