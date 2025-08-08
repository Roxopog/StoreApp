namespace Services.Contracts
{
    public interface IServiceManager
    {
        IProductService ProdcutService { get; }
        ICategoryService CategoryService { get; }
    }
}