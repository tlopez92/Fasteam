using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasTeamData.DAO
{
  public class UserDao
  {
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int LocationID { get; set; }
    public int RoleID { get; set; }
  }
}
