using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamData
{
  public class EfData
  {
    //Object of the Entities model
    private static FasdsTeamEntities ed = new FasdsTeamEntities();
    
    /// <summary>
    /// Get functions to get users
    /// states, locations, and roles
    /// and convert them to a list object
    /// </summary>
    /// <returns></returns>
    public List<User> GetUsers()
    {
      return ed.Users.ToList();
    }
    
    public List<Role> GetRoles()
    {
      return ed.Roles.ToList();
    }

    public Role FindRoleByRoleName(String roleName)
    {
      return ed.Roles.Where(r => r.RoleName == roleName).ToList().First();
    }
    /// <summary>
    /// Finds user by first and last name
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User FindUserByName(User user)
    {
      return ed.Users.Where(u => u.FirstName == user.FirstName && u.LastName == user.LastName).ToList().First();
    }

    public List<User> FindUserByRole(User user)
    {
      return ed.Users.Where(u => u.Role == user.Role).ToList();
    }

    public User FindUserById(User user)
    {
      return ed.Users.Where(u => u.UserID == user.UserID).ToList().First();
    }
   
    //Find users by location using lambda expressions
    public List<User> FindUsersByLocation(User user)
    {
      return ed.Users.Where(u => u.Location.LocationName == user.Location.LocationName).ToList();
    }

    public int addUser(User user)
    {
      ed.Users.Add(user);
      return ed.SaveChanges();
    }
    
    //Updates user if the original content
    //has been changed in any way or form
    public bool UpdateUser(User user)
    {
      var original = ed.Users.Find(user.UserID);

      if(original != null)
      {
        ed.Entry(original).CurrentValues.SetValues(user);
        ed.SaveChanges();
        return true;
      }

      else
      {
        return false;
      }
    }

    public int AddRole(Role role)
    {
      ed.Roles.Add(role);
      return ed.SaveChanges();
    }

    public bool UpdateRole(Role role)
    {
        var original = ed.Roles.Find(role.RoleID);

        if (original != null)
        {
            ed.Entry(original).CurrentValues.SetValues(role);
            ed.SaveChanges();
            return true;
        }

        else
        {
            return false;
        }
    }
    }
}
