using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using JovenesA.Models;
using JovenesA.Services;
using Microsoft.AspNet.Identity.EntityFramework;


namespace JovenesA.Services
{
    public static  class MyUserIdentity
    {

        public static int GetUserID()
        {

            int memberId = 0;
            Log4.Trace("MyUserIdentity; User.Identity = ");
            var User = System.Web.HttpContext.Current.User;
            Log4.Trace(User.Identity);
            var name = User.Identity.Name;
            var currentUserId = User.Identity.GetUserId();
            if (!(String.IsNullOrEmpty(currentUserId)))
            {
                var x = new UserStore<MyIdentityUser>(new MyDbContext());
                var manager = new UserManager<MyIdentityUser>(x);
                var currentUser = manager.FindById(currentUserId);
                Log4.Trace(currentUser.MyUserInfo.MemberId);
                memberId = currentUser.MyUserInfo.MemberId;
                
            }
            else
            {
                Log4.Trace("currentUserId is NULL<<<<<<<<<<");
            }
            return memberId;
        }

    }
}