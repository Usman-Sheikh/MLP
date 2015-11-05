using MLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Data
{
    public interface ICourseRepository
    {
        IEnumerable<Course> SelectAll();
        Course SelectByID(int id);
        void Add(Course course);
        void Update(Course course);
        IEnumerable<Course> FilterByParam(Expression<Func<Course, bool>> predicate);
        void Delete(int id);
        void Save();
    }
}
