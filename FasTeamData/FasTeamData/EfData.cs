using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamData
{
  public class EfData
  {
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

    public List<State> GetStates()
    {
      return ed.States.ToList();
    }

    public List<Location> GetLocations()
    {
      return ed.Locations.ToList();
    }

    public List<Role> GetRoles()
    {
      return ed.Roles.ToList();
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
  }
}
