using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VisaRequestClass
/// </summary>
public class VisaRequestClass
{
    public int RequestId { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string VisaTitle { get; set; }
    public string VisaType { get; set; }
    public string NameofApplicant { get; set; }
    public DateTime DateofBirth { get; set; }
    public string PassportNo { get; set; }
    public string MotherName { get; set; }
    public string PassportCopy { get; set; }    
    public DateTime Deadline { get; set; }
    public string Description { get; set; }
    public string UploadFile { get; set; }
    public string RequestStatus { get; set; }
    public string ResultFile { get; set; }

    public VisaRequestClass(int requestid,string name, string username, string email, string visatitle, string visatype, string nameofapplicant,DateTime dateofbirth,string passportno,string mothername,string passportcopy, DateTime deadline, string description, string uploadfile, string requeststatus, string resultfile)
    {
        RequestId = requestid;
        Name = name;
        UserName = username;
        Email = email;
        VisaTitle = visatitle;
        VisaType = visatype;
        NameofApplicant = nameofapplicant;
        DateofBirth = dateofbirth;
        PassportNo = passportno;
        MotherName = mothername;
        PassportCopy = passportcopy;
        Deadline = deadline;
        Description = description;
        UploadFile = uploadfile;
        RequestStatus = requeststatus;
        ResultFile = resultfile;
    }

    public VisaRequestClass(string name, string username, string email, string visatitle, string visatype, string nameofapplicant, DateTime dateofbirth, string passportno, string mothername, string passportcopy, DateTime deadline, string description, string uploadfile, string requeststatus, string resultfile)
    {
        Name = name;
        UserName = username;
        Email = email;
        VisaTitle = visatitle;
        VisaType = visatype;
        NameofApplicant = nameofapplicant;
        DateofBirth = dateofbirth;
        PassportNo = passportno;
        MotherName = mothername;
        PassportCopy = passportcopy;
        Deadline = deadline;
        Description = description;
        UploadFile = uploadfile;
        RequestStatus = requeststatus;
        ResultFile = resultfile;
    }
}