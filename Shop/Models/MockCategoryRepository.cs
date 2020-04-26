using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruit pies"},
                new Category {CategoryId = 1, CategoryName = "Cheese pies", Description = "Cheesy all the way"},
                new Category {CategoryId = 1, CategoryName = "Season pies", Description = "Get in the mood for a season pie"}
            };
    }
}
