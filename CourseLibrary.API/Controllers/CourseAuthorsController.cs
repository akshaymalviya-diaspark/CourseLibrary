using CourseLibrary.API.Entities;
using CourseLibrary.API.Models;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Controllers
{
    [ApiController]
    [Route("api/courseauthors")]
    public class CourseAuthorsController : ControllerBase
    {
        ICourseLibraryRepository _repository;

        public CourseAuthorsController(ICourseLibraryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CourseAuthorDto>> Get(string courseName = "", string authorName = "")
        {
            /*
            Author a = _repository.GetAuthors().First();
            a.FirstName = a.FirstName + " - 1";
            _repository.UpdateAuthor(a);
            _repository.Save();
            */
            return new ActionResult<IEnumerable<CourseAuthorDto>>(_repository.GetCourseAuthors(courseName, authorName));
        }
    }
}
