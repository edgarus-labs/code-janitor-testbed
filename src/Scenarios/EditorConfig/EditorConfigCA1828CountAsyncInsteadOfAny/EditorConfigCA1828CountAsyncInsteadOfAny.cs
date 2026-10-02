using Microsoft.EntityFrameworkCore;

namespace Testbed.EditorConfig.EditorConfigCA1828CountAsyncInsteadOfAny
{
    public class EditorConfigCA1828CountAsyncInsteadOfAny
    {
        private static async System.Threading.Tasks.Task<bool> HasItems(System.Linq.IQueryable<int> source)
        {
            return await source.CountAsync() > 0;
        }

        public static string Run() => HasItems(System.Linq.Queryable.AsQueryable(new[] { 1 })).GetAwaiter().GetResult().ToString();
    }
}
