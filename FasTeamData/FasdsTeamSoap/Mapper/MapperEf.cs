using AutoMapper;
using FasdsTeamSoap.DAO;
using FasTeamData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FasdsTeamSoap.Mapper
{
    public class MapperEf
    {
        private readonly MapperConfiguration UserMapper = new MapperConfiguration(u => u.CreateMap<User, UserDao>());

        private readonly MapperConfiguration UserMapperReverse = new MapperConfiguration(u => u.CreateMap<UserDao, User>());

        public UserDao MapToService(User user)
        {
            var mapper = UserMapper.CreateMapper();
            return mapper.Map<UserDao>(user);
        }

        public User MapToData(UserDao user)
        {
            var mapper = UserMapperReverse.CreateMapper();
            return mapper.Map<User>(user);
        }
    }
}