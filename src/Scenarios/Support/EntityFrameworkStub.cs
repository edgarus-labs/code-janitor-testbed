namespace Microsoft.EntityFrameworkCore
{
    /// <summary>A stand-in for Entity Framework's query extensions: a scenario that uses its namespace is treated as EF code.</summary>
    public static class EntityFrameworkQueryableExtensions
    {
        public static System.Threading.Tasks.Task<int> CountAsync<T>(this System.Linq.IQueryable<T> source) => System.Threading.Tasks.Task.FromResult(System.Linq.Queryable.Count(source));

        public static System.Threading.Tasks.Task<bool> AnyAsync<T>(this System.Linq.IQueryable<T> source) => System.Threading.Tasks.Task.FromResult(System.Linq.Queryable.Any(source));
    }
}
