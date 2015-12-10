using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
    public int POId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Contactno { get; set; }
    public int Productnumber { get; set; }
    public string Productname { get; set; }
    public decimal Price { get; set; }
    public DateTime Orderdate { get; set; }
    public string Paymentstatus { get; set; }
    public string IPAddress { get; set; }
    public string Transactionid { get; set; }
    
    public Order(int poid,string firstname,string lastname,string username,string email,string contactno,int productnumber,string productname,decimal price,DateTime orderdate,string paymentstatus,string ipaddress,string transactionid)
	{
        POId = poid;
        Firstname = firstname;
        Lastname = lastname;
        Username = username;
        Email = email;
        Contactno = contactno;
        Productnumber = productnumber;
        Productname = productname;
        Price = price;
        Orderdate = orderdate;
        Paymentstatus = paymentstatus;
        IPAddress = ipaddress;
        Transactionid = transactionid;
	}

    public Order(string firstname, string lastname, string username, string email, string contactno, int productnumber, string productname, decimal price, DateTime orderdate, string paymentstatus, string ipaddress, string transactionid)
    {

        Firstname = firstname;
        Lastname = lastname;
        Username = username;
        Email = email;
        Contactno = contactno;
        Productnumber = productnumber;
        Productname = productname;
        Price = price;
        Orderdate = orderdate;
        Paymentstatus = paymentstatus;
        IPAddress = ipaddress;
        Transactionid = transactionid;
    }
}