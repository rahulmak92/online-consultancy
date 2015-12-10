using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ContactUsClass
/// </summary>
public class ContactUsClass
{
    public int ContactId;
    public string Name;
    public string Mail;
    public string Telephone;
    public string Message;

    public ContactUsClass(int contactid,string name, string mail, string telephone, string message)
    {
        ContactId = contactid;
        Name = name;
        Mail = mail;
        Telephone = telephone;
        Message = message;
    }

    public ContactUsClass(string name, string mail, string telephone, string message)
    {
       
        Name = name;
        Mail = mail;
        Telephone = telephone;
        Message = message;
    }
}