using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string ContactNo { get; set; }
    public int Active { get; set; }
    public string Role { get; set; }

    public User(int id, string name, string password,string firstname,string lastname, string email, string contactno,int active,string role)
    {
        Id = id;
        UserName = name;
        Password = password;
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        ContactNo = contactno;
        Active = active;
        Role = role;
    }

    public User(string name, string password,string firstname,string lastname, string email, string contactno,int active,string role)
    { 
        UserName = name;
        Password = password;
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        ContactNo = contactno;
        Active = active;
        Role = role;
    }
}