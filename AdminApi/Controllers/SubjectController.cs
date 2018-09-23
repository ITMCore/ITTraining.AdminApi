using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ITTrainingDBContext.DBContext;

namespace AdminApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Subject")]
    public class SubjectController : Controller
    {
		//[HttpGet]
		//public async Task<ActionResult<Subjects>> GetAllSubjects()
		//{
		//	return new { subjectName = "text" };
		//}
    }
}