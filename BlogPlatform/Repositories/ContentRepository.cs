using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class ContentRepository : IRepository<Content>
    {
        private BlogContext _db;

        public ContentRepository(BlogContext db)
        {
            _db = db;
        }

        public void Create(Content obj)
        {
            _db.Contents.Add(obj);
            _db.SaveChanges();
        }
        public void Delete(Content obj)
        {
            _db.Contents.Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Content> GetAll()
        {
            return _db.Contents.ToList();
        }

        public IEnumerable<Content> GetAllContent()
        {
            return this.GetAll();
        }

        public Content GetByID(int id)
        {
            return _db.Contents.Find(id);
            //return _db.Contents.Where(i => i.Id == id).FirstOrDefault();
        }

        public void Update(Content obj)
        {
            _db.Contents.Update(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

    }
}
