using System;
namespace Demeter
{
  public class DB
  {
    public User GetUser (int id)
    {
      //call to the DB, getting record
      return new User ();
    }
    public void Save (object item)
    {
      //save to DB
    }
  }

  public class User
  {
    public String Status { get; set; }
  }

  public class Membership
  {
    DB _db;
    public Membership ()
    {
      _db = new DB ();
    }
    public User GetUser (int id)
    {
      //get the user
      return _db.GetUser (id);
    }

    public void SuspendUser (int id)
    {
      var user = this.GetUser (id);
      user.Status = "suspended";
      _db.Save (user);
    }
  }
}

