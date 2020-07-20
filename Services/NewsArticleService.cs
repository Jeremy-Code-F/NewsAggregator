using NewsAggregation.DAL;
using NewsAggregation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregation.Services
{
    public class NewsArticleService
    {
        private NewsArticleRepository _newsArticleRepository;
        public NewsArticleService(NewsArticleRepository newsArticleRepository)
        {
            _newsArticleRepository = newsArticleRepository;
        }

        public async Task<NewsArticleModel> GetFirstNewsArticleAsync()
        {
            return await _newsArticleRepository.GetFirstModelAsync();
        }
    }
}
