using FasTeamLogicBusiness.BusinessModels;
using FasTeamLogicBusiness.FasdsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamLogicBusiness
{
    public class LogicHelper
    {
        private readonly DataContractClient client = new DataContractClient();
        private readonly LogicMapper logic = new LogicMapper();

        //Get requests to get all users from within the database
        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = new List<UserDto>();
            var serviceUsers = await client.GetUsersAsync();

            foreach(var item in serviceUsers)
            {
                var par = logic.MapToBusiness(item);

                users.Add(par);
            }

            return users;
        }

        //This method links to the data layer allowing the user to add a new row to the associated table within the database
        public int AddNewUser(UserDto user)
        {
            var success = client.AddUser(logic.MapToService(user));
            return success;
        }

        //This method connects to DAL and allows the user to Update Existing information from within the database
        public bool UpdateUser(UserDto user)
        {
            //reserved for code necessary to link to DAL
            return true;
        }
    }
}
