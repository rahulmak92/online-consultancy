using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class NewsClass
{
    public int Id { get; set; }
    public string NewsHeadlines { get; set; }
    public string NewsDetails { get; set; }
    public DateTime ExpiryDate { get; set; }
    public DateTime PublishDate { get; set; }
    
    public NewsClass(int id,string newsheadlines,string newsdetails,DateTime expirydate,DateTime publishdate)
	{
        Id = id;
        NewsHeadlines = newsheadlines;
        NewsDetails = newsdetails;
        ExpiryDate = expirydate;
        PublishDate = publishdate;
	}

    public NewsClass(string newsheadlines, string newsdetails, DateTime expirydate, DateTime publishdate)
    {
        
        NewsHeadlines = newsheadlines;
        NewsDetails = newsdetails;
        ExpiryDate = expirydate;
        PublishDate = publishdate;
    }
}