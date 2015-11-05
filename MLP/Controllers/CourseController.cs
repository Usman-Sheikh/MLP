using MLP.Data;
using MLP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MLP.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository courseRepository = null;
        private ICategoryCourseRepository categoryCourseRepository = null;
        public CourseController()
        {
         this.courseRepository = new CourseRepository();
         this.categoryCourseRepository = new CategoryCourseRepository();
        }
        public CourseController(ICourseRepository courseRepository, ICategoryCourseRepository categoryCourseRepository)
        {
            this.courseRepository = courseRepository;
            this.categoryCourseRepository = categoryCourseRepository;
        }
        //
        // GET: /Course/
        public ActionResult Index()
        {
            var courseCategoryModel = new CourseCategoryModel();
            courseCategoryModel.CategoryCourseList = (List<CategoryCourse>)categoryCourseRepository.SelectAll();
            courseCategoryModel.CourseList = (List<Course>)courseRepository.SelectAll();
            return View(courseCategoryModel);
        }

        public ActionResult List(int id)
        {
            //var course = new MixedCourse();
            var courseList = courseRepository.FilterByParam(x => x.CategoryCourses_CategoryCourseId == id);
            return PartialView("~/Views/Course/_CourcesList.cshtml", courseList);
        }
	}
}