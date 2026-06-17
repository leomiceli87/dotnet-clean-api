namespace CleanApi.Application.Interfaces
{
    public interface IUseCase<TIn, TOut>
    {
        Task<TOut> ExecuteAsync(TIn input);
    }

    public interface IUseCase<TOut>
    {
        Task<TOut> ExecuteAsync();
    }
}
