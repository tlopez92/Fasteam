using AutoMapper;
using FasTeamLogicBusiness.BusinessModels;
using FasTeamLogicBusiness.FasdsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamLogicBusiness
{
    public class LogicMapper
    {
        private readonly MapperConfiguration UserMapper = new MapperConfiguration(u => u.CreateMap<UserDao, UserDto>().ForMember(u1 => u1.Location, obj => obj.MapFrom(u2 => u2.LocationId.ToString()))
                                                                                                                      .ForMember(r1 => r1.Role, obj => obj.MapFrom(r2 => r2.RoleId.ToString())));

        private readonly MapperConfiguration UserReverseMapper = new MapperConfiguration(u => u.CreateMap<UserDto, UserDao>().ForMember(u2 => u2.LocationId, obj => obj.MapFrom(u1 => u1.Location))
                                                                                                                      .ForMember(r2 => r2.RoleId, obj => obj.MapFrom(r1 => r1.Role)));

        /// <summary>
        /// The purpose of this method is to link the Dao of the Data Layer to the Dto of the Logic Layer
        /// </summary>
        public UserDto MapToBusiness(UserDao u)
        {
            var mapper = UserMapper.CreateMapper();
            return mapper.Map<UserDto>(u);
        }


        /// <summary>
        /// The purpose of this method is to link the Dto of the Logic Layer to the Dao of the Data Layer
        /// </summary>
        public UserDao MapToService(UserDto u)
        {
            var mapper = UserReverseMapper.CreateMapper();
            return mapper.Map<UserDao>(u);
        }
    }
}
