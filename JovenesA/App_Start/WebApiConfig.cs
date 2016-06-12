using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace JovenesA
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver =
              new CamelCasePropertyNamesContractResolver();

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            //config.SuppressDefaultHostAuthentication();
            //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            //Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "MentorReportsRoute",
                routeTemplate: "api/v1/mentorReports/{mentorId}/{studentId}",
                defaults: new
                {
                    controller = "mentorReports",
                    mentorId = RouteParameter.Optional,
                    studentId = RouteParameter.Optional
                }
            );

            config.Routes.MapHttpRoute(
                name: "RPT_MentorReportsRoute",
                routeTemplate: "api/v1/RPT_mentorReports/{mentorId}/{studentId}",
                defaults: new
                {
                    controller = "RPT_mentorReports",
                    mentorId = RouteParameter.Optional,
                    studentId = RouteParameter.Optional
                }
            );

            config.Routes.MapHttpRoute(
                name: "QuarterlyAsssessmentsRoute",
                routeTemplate: "api/v1/quarterlyAssessments/{psychologistId}/{studentId}",
                defaults: new
                {
                    controller = "quarterlyAssessments",
                    psychologistId = RouteParameter.Optional,
                    studentId = RouteParameter.Optional
                }
            );
            config.Routes.MapHttpRoute(
               name: "MentorsRoute",
               routeTemplate: "api/v1/mentors/{Id}",
               defaults: new { controller = "mentors", Id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
               name: "AdminsRoute",
               routeTemplate: "api/v1/admins/{Id}",
               defaults: new { controller = "admins", Id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
               name: "PsychologistsRoute",
               routeTemplate: "api/v1/psychologists/{Id}",
               defaults: new { controller = "psychologists", Id = RouteParameter.Optional }
           );
            config.Routes.MapHttpRoute(
               name: "StudentsRoute",
               routeTemplate: "api/v1/students/{Id}",
               defaults: new { controller = "students", Id = RouteParameter.Optional }
           );

           config.Routes.MapHttpRoute(
               name: "StudentsListRoute",
               routeTemplate: "api/v1/studentDTOs/{statusId}/{gradYear}/{yearJoinedJA}",
               defaults: new { controller = "studentDTOs", statusId = RouteParameter.Optional
                                                       ,gradYear = RouteParameter.Optional
                                                      , yearJoinedJA = RouteParameter.Optional}
           );

            config.Routes.MapHttpRoute(
               name: "ContactsRoute",
               routeTemplate: "api/v1/contacts/{contactId}",
               defaults: new { controller = "contacts", contactId = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
              name: "StudentsMentorsRoute",
              routeTemplate: "api/v1/studentsMentors/{studentId}",
              defaults: new { controller = "studentsMentors", studentId = RouteParameter.Optional }
            );

// Reports

            config.Routes.MapHttpRoute(
                name: "ReportsRoute",
                routeTemplate: "api/v1/threeColumnReport/{reportName}",
                defaults: new
                { controller = "reports",
                   reportName = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/",
                defaults: new { controller = "summaryData" }
            );

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();
        }
    }
}