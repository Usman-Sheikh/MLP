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
        public CourseController()
        {
         this.courseRepository = new CourseRepository();
        }
        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        //
        // GET: /Course/
        public ActionResult Index()
        {
            List<Course> courseList = (List<Course>)courseRepository.SelectAll();
            return View(courseList);
        }
	}
}