namespace WebApplication7._0.RepositoryService
{
    public interface IRepositoryWrapper
    {
        ITestRepository Test { get; }

        void save();
    }
}
