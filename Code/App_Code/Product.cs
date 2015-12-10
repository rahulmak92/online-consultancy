using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Product
{
    public int ProductId { get; set; }
    public int ProductNumber { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ProductPicture { get; set; }
    public string ProductFile { get; set; }

    public Product(int productid,int productnumber,string productname,string description,decimal price,DateTime releasedate,string productpicture,string productfile)
    {
        ProductId = productid;
        ProductNumber = productnumber;
        ProductName = productname;
        Description = description;
        Price = price;
        ReleaseDate = releasedate;
        ProductPicture = productpicture;
        ProductFile = productfile;
    }

    public Product(int productnumber,string productname, string description, decimal price,DateTime releasedate, string productpicture, string productfile)
    {
        ProductNumber = productnumber;
        ProductName = productname;
        Description = description;
        Price = price;
        ReleaseDate = releasedate;
        ProductPicture = productpicture;
        ProductFile = productfile;
    }
}