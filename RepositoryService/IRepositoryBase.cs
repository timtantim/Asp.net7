using System.Linq.Expressions;

namespace WebApplication7._0.RepositoryService
{
    public interface IRepositoryBase<T>
    {
        // 查詢所有資料
        IQueryable<T> FindAll();
        // 查詢條件資料
        IQueryable<T> FindSpecificData(Expression<Func<T, bool>> expression);
        // 創建資料
        T Create(T entity);
        // 更新資料
        void Update(T entity);
        // 刪除資料
        void Delete(T entity);
    }
}
