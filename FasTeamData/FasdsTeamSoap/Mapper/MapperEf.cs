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

        private readonly MapperConfiguration RoleMapper = new MapperConfiguration(r => r.CreateMap<Role, RoleDao>());

        private readonly MapperConfiguration RoleMapperReverse = new MapperConfiguration(r => r.CreateMap<RoleDao, Role>());

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

        public RoleDao MapToService(Role role)
        {
            var mapper = RoleMapper.CreateMapper();
            return mapper.Map<RoleDao>(role);
        }

        public Role MapToData(RoleDao roleDao)
        {
            var mapper = RoleMapperReverse.CreateMapper();
            return mapper.Map<Role>(roleDao);
        }
    }
}