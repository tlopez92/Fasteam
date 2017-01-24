using FasTeamLogicBusiness;
using FasTeamLogicBusiness.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FasTeamLogic.Controllers
{
    public class UserController : ApiController
    {
        private readonly LogicHelper biz = new LogicHelper();

        //This will be a get request to get all users from the database
        public async Task<HttpResponseMessage> Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, await biz.GetAllUsers());
        }

        [HttpPost]
        public HttpResponseMessage AddUser([FromBody] UserDto user)
        {
            if(user == null || (String.IsNullOrWhiteSpace(user.Role) || String.IsNullOrWhiteSpace(user.Location) || String.IsNullOrWhiteSpace(user.FirstName) || String.IsNullOrWhiteSpace(user.LastName)))
            {
                var message = "You are missing some information. Please review and submit again";
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, err);
            }

            else
            {
                var add = biz.AddNewUser(user);
                return Request.CreateResponse(HttpStatusCode.OK, add);
            }
        }

        //This will update the user when specified
        [HttpPost]
        public HttpResponseMessage UpdateUser([FromBody] UserDto user)
        {
            if (user == null || String.IsNullOrEmpty(user.FirstName) || String.IsNullOrEmpty(user.LastName))
            {
                var message = "You are mission some information. Please review and submit again";
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotAcceptable, err);
            }

            else
            {
                bool update = biz.UpdateUser(user);
                return Request.CreateResponse(HttpStatusCode.OK, update);
            }
        }
    }
}
