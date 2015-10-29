using MLP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MLP.Data
{
    public class CourseRepository : ICourseRepository
    {
        private MLPContext db = null;

        protected MLPContext DataContext
        {
            get { return db ?? (db = new MLPContext()); }
        }

        public CourseRepository()
        {
            this.db = DataContext;
        }
        public IEnumerable<Course> SelectAll()
        {
            return db.Courses.ToList();
        }

        public Course SelectByID(int id)
        {
            return db.Courses.Find(id);
        }

        public void Add(Course course)
        {
            db.Courses.Add(course);
        }

        public void Update(Course course)
        {
            db.Entry(course).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}