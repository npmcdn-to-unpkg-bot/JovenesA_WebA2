using System;
using System.Linq;
using System.Web.Mvc;
using JovenesA.Models;
using JovenesA.DataAccess;
using JovenesA.Services;
using System.Web.Routing;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using System.Security.Claims;
using System.Collections.Generic;

namespace JovenesA.Controllers
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, 
                                  Inherited = true, AllowMultiple = true)]
    public class AuthorizeRedirect : AuthorizeAttribute
    {
        private const string IS_AUTHORIZED = "isAuthorized";

        //http://stackoverflow.com/questions/1498727/asp-net-mvc-how-to-show-unauthorized-error-on-login-page
        //http://stackoverflow.com/questions/13284729/asp-net-mvc-4-custom-authorize-attribute-how-to-redirect-unauthorized-users-to
        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            bool rtnVal = false;
            Roles = "Admin";

            var isAuthorized = base.AuthorizeCore(httpContext);
            if (isAuthorized)
            {
                rtnVal = true;
            }

            ClaimsIdentity claimsIdent = httpContext.User.Identity as ClaimsIdentity;
            foreach (Claim claim in claimsIdent.Claims)
            {
                if (claim.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")
                {
                    if (Roles.Contains(claim.Value) && claim.Value == "Admin")
                    {
                        httpContext.Items.Add(IS_AUTHORIZED, isAuthorized);
                        rtnVal = true;
                    }
                }
            }
            return rtnVal;
        }


        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            // if not authenticated base will redirect to login screen
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
            else // user is authenticated, but is he authorized?
            {
                var isAuthorized = filterContext.HttpContext.Items[IS_AUTHORIZED] != null
                    ? Convert.ToBoolean(filterContext.HttpContext.Items[IS_AUTHORIZED])
                    : false;

                if (!isAuthorized)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary
                        {
                            { "controller", "Home" },
                            { "action", "AdminAuthError" }
                        });
                }
            }
        }

    }

    [Authorize]
  public class HomeController : Controller
  {
    //private IMailService _mail;
    private IJovenesARepository _repo;


    public HomeController(IJovenesARepository repo)
    {
      Log4.Trace("Home Controller constructor, repo = ");
      Log4.Trace(repo);
      _repo = repo;
    }


    [AuthorizeRedirect]
    [Authorize(Roles = "Admin")]
    public ActionResult Moderation()
    {
        return View();
    }

    [AuthorizeRedirect]
    [Authorize(Roles = "Admin")]
    public ActionResult Admins()
    {
        var vm = new AdminsViewModel();

        vm.adminId = JovenesA.Services.MyUserIdentity.GetUserID();
        return View(vm);
    }

    public ActionResult AdminAuthError()
    {
        ViewBag.Message = "Admin Authorization Restriction";
        return View();
    }

    public ActionResult Mentors(int? studentIndex)
    {
        var vm = new MentorsViewModel();

            vm.mentorId = JovenesA.Services.MyUserIdentity.GetUserID();
            var sds = new JovenesA.Services.StudentDataService();
            vm.rpt_StudentMentors = sds.GetStudentsForThisMentor(vm.mentorId);
            if(vm.rpt_StudentMentors.Count() > 0)
            { 
                vm.studentId = vm.rpt_StudentMentors.Skip(studentIndex ?? 0).First().StudentId;
            }
            else
            {
                vm.studentId = 0;
            }
            return View(vm);
    }

        private Dictionary<int, string> GetStudentsFromDB()
        {
            return new Dictionary<int, string>
            {
                {192, "ARANA GUZMAN"},
                {189, "ARELLANO LADRILLERO"},
                {123, "BADILLO CASTILLO"},
                {224, "Banca Ceja"}
                // some lines skipped
            };
        }
        public ActionResult Psychologists()
        {
            var vm = new PsychologistsViewModel();
            vm.studentId = 0;
            vm.psychologistId = JovenesA.Services.MyUserIdentity.GetUserID();
            return View(vm);
        }

    public ActionResult Volunteers()
    {
        ViewBag.Message = "Volunteers Page.";
        return View();
    }

    public ActionResult Students()
    {
            var vm = new StudentsViewModel();
            vm.studentMemberId = 0;
            vm.studentMemberId = JovenesA.Services.MyUserIdentity.GetUserID();
            vm.studentMemberId = 0;
            vm.studentId = 0;
            

            vm.studentMemberId = JovenesA.Services.MyUserIdentity.GetUserID();
            var sds = new JovenesA.Services.StudentDataService();
            vm.studentId = sds.GetStudentId(vm.studentMemberId);
            vm.student = sds.GetStudent(vm.studentId);


            return View(vm);

        }

    [AllowAnonymous]
    public ActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    [AllowAnonymous]
    [HttpPost]
    public ActionResult Contact(ContactModel model)
    {
      var msg = string.Format("Comment From: {1}{0}Email:{2}{0}Website: {3}{0}Comment:{4}",
        Environment.NewLine, 
        model.Name,
        model.Email,
        model.Website,
        model.Comment);

      //if (_mail.SendMail("noreply@kapilla.net", 
      //  "chris@kapilla.net",
      //  "JovenesA Contact Request",
      //  msg))
      //{
      //  ViewBag.MailSent = true;
      //}

      return View();
    }

    public ActionResult MyAccount()
    {
      return View();
    }

  }
}