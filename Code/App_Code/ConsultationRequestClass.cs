using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class ConsultationRequestClass
{
    public int RequestId { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string ConsultationTitle { get; set; }
    public string ConsultationType { get; set; }
    public DateTime Deadline { get; set; }
    public string Description { get; set; }
    public string UploadFile { get; set; }
    public string RequestStatus { get; set; }
    public string ResultFile { get; set; }

    public ConsultationRequestClass(int requestid, string name, string username, string email, string consultationtitle, string consultationtype, DateTime deadline, string description, string uploadfile, string requeststatus, string resultfile)
    {
        RequestId = requestid;
        Name = name;
        UserName = username;
        Email = email;
        ConsultationTitle = consultationtitle;
        ConsultationType = consultationtype;
        Deadline = deadline;
        Description = description;
        UploadFile = uploadfile;
        RequestStatus = requeststatus;
        ResultFile = resultfile;
    }

    public ConsultationRequestClass(string name, string username, string email, string consultationtitle, string consultationtype, DateTime deadline, string description, string uploadfile, string requeststatus, string resultfile)
    {
        Name = name;
        UserName = username;
        Email=email;
        ConsultationTitle = consultationtitle;
        ConsultationType = consultationtype;
        Deadline = deadline;
        Description = description;
        UploadFile = uploadfile;
        RequestStatus = requeststatus;
        ResultFile = resultfile;
    }
}