using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1P.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private ProducDbDataContext dbContext;
        public CategoryRepository(ProducDbDataContext context)
        {
            dbContext = context;
        }
        public IEnumerable<Category> Categories => dbContext.Category;

        public void AddCategory(Category category)
        {
            dbContext.Category.Add(category);
            dbContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            dbContext.Category.Remove(category);
            dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            dbContext.Category.Update(category);
            dbContext.SaveChanges();
        }
    }
}
