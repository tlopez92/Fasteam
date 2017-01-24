using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamLogicBusiness.BusinessModels
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; } //Must be a string to ensure that data passes through correctly
        public string Role { get; set; } //Must be a string to ensure that data passes through correctly
    }
}
