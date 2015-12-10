using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class NewsManagement
{
    public int id { get; set; }
    public string newsHeadlines { get; set; }
    public string newsDetails { get; set; }
    public DateTime expiryDate { get; set; }

	public NewsManagement(int id,string newsHeadlines,string newsDetails,DateTime expiryDate )
	{
        this.id = id;
        this.newsHeadlines = newsHeadlines;
        this.newsDetails = newsDetails;
        this.expiryDate = expiryDate;
	}

    public NewsManagement(string newsHeadlines, string newsDetails, DateTime expiryDate)
    {
        this.newsHeadlines = newsHeadlines;
        this.newsDetails = newsDetails;
        this.expiryDate = expiryDate;
    }
}