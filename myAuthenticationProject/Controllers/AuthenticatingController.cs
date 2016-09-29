using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AuthenticationLibrary.BLL;

namespace myAuthenticationProject.Controllers
{
    public class AuthenticatingController : ApiController
    {
        AuthenticationLibrary.BLL.Emp obj = new AuthenticationLibrary.BLL.Emp();
        
    }
}
