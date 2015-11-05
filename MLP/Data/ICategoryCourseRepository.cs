using MLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLP.Data
{
    public interface ICategoryCourseRepository
    {
        IEnumerable<CategoryCourse> SelectAll();
        CategoryCourse SelectByID(int id);
        void Add(CategoryCourse categoryCourse);
        void Update(CategoryCourse categoryCourse);
        void Delete(int id);
        void Save();
    }
}
