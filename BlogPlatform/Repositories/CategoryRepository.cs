using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        public BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }
        public void Create(Category obj)
        {
            db.Categories.Add(obj);
            db.SaveChanges();
        }
        //Read
        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return db.Categories.Find(id);
        }
        // Update
        public void Update(Category obj)
        {
            db.Categories.Update(obj);
            db.SaveChanges();
        }
        // Delete
        public void Delete(Category obj)
        {
            db.Categories.Remove(obj);
            db.SaveChanges();
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return db.Categories.ToList();
        }

    }


}
