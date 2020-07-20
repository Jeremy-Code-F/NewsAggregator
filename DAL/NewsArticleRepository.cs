using NewsAggregation.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregation.DAL
{
    public class NewsArticleRepository
    {
        private string _connStr;
        private PetaPoco.Database db;
        public NewsArticleRepository(string connStr, ILogger logger)
        {
            db = new PetaPoco.Database(connStr, "Npgsql");
        }

        public async Task<NewsArticleModel> GetFirstModelAsync()
        {
            return await db.FirstAsync<NewsArticleModel>("WHERE id = @0", "a897898c-d87e-4304-81d4-3db139a3d08c");
        }
    }
}
