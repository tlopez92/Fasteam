using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FasdsTeamSoap.DAO
{
    public class UserDao
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LocationId { get; set; }
        public int RoleId { get; set; }
    }
}