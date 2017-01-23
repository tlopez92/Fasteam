using FasdsTeamSoap.DAO;
using FasdsTeamSoap.Mapper;
using FasTeamData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FasdsTeamSoap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FasdsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FasdsService.svc or FasdsService.svc.cs at the Solution Explorer and start debugging.
    public class FasdsService : IDataContract
    {

        //Object from EfData class
        private readonly EfData ef = new EfData();

        //Object of MapperEf class
        private readonly MapperEf mapper = new MapperEf();

        public int AddUser(UserDao user)
        {
            return ef.addUser(mapper.MapToData(user));
        }

        public List<UserDao> GetUsers()
        {
            var users = new List<UserDao>();
            var dataUsers = ef.GetUsers();

            foreach (var item in dataUsers)
            {
                users.Add(mapper.MapToService(item));
            }

            return users;
        }

        public bool UpdateUser(UserDao user)
        {
            return ef.UpdateUser(mapper.MapToData(user));
        }
    }
}
