﻿using FasdsTeamSoap.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FasdsTeamSoap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDataContract
    {
        [OperationContract]
        List<UserDao> GetUsers();


        [OperationContract]
        int AddUser(UserDao user);

        [OperationContract]
        bool UpdateUser(UserDao user);

        [OperationContract]
        List<RoleDao> GetRoles();

        [OperationContract]
        int AddRole(RoleDao role);

        [OperationContract]
        bool UpdateRole(RoleDao role);
    }
}
