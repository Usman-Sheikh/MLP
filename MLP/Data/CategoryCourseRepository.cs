using MLP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MLP.Data
{
    public class CategoryCourseRepository : ICategoryCourseRepository
    {
        private MLPContext db = null;

        protected MLPContext DataContext
        {
            get { return db ?? (db = new MLPContext()); }
        }

        public CategoryCourseRepository()
        {
            this.db = DataContext;
        }
        public IEnumerable<CategoryCourse> SelectAll()
        {
            return db.CategoryCourses.ToList();
        }

        public CategoryCourse SelectByID(int id)
        {
            return db.CategoryCourses.Find(id);
        }

        public void Add(CategoryCourse categoryCourse)
        {
            db.CategoryCourses.Add(categoryCourse);
        }

        public void Update(CategoryCourse categoryCourse)
        {
            db.Entry(categoryCourse).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            CategoryCourse categoryCourse = db.CategoryCourses.Find(id);
            db.CategoryCourses.Remove(categoryCourse);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}