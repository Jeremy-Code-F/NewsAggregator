using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregation.Models
{
    [TableName("NewsArticle")]
    [PrimaryKey("id")]
    public class NewsArticleModel
    {
        
        public string id { get; set; }
        public string DisplayName { get; set; }
    }
}
