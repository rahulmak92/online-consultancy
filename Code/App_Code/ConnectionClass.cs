using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Collections;


public static class ConnectionClass
{
    private static SqlConnection conn;
    private static SqlCommand com;
    static ConnectionClass()
	{
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        conn = new SqlConnection(connectionString);
        com = new SqlCommand("", conn);
	}

    public static ArrayList GetNews(string tablename)
    {
        ArrayList list = new ArrayList();
        
        string query = string.Format("SELECT * FROM {0} ORDER BY ExpiryDate",tablename);
        com.CommandText = query;
        try
        {
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string newsHeadlines = reader.GetString(1);
                string newsDetails = reader.GetString(2);
                DateTime expiryDate = reader.GetDateTime(3);
                DateTime publishDate = reader.GetDateTime(4);

                list.Add(newsHeadlines);
                list.Add(newsDetails);
                
            }
            return list;
            
        }
        finally
        {
            conn.Close();
        }
        
    }

    public static ArrayList GetFullNews(string tablename)
    {
        ArrayList list = new ArrayList();

        string query = string.Format("SELECT * FROM {0} ORDER BY ExpiryDate", tablename);
        com.CommandText = query;
        try
        {
            conn.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string newsHeadlines = reader.GetString(1);
                string newsDetails = reader.GetString(2);
                DateTime expiryDate = reader.GetDateTime(3);
                DateTime publishDate = reader.GetDateTime(4);

                list.Add(newsHeadlines);
                list.Add(newsDetails);
                list.Add(publishDate);

            }
            return list;

        }
        finally
        {
            conn.Close();
        }
        
    }

    public static string AddNews(NewsClass news)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT into NewsManagement VALUES ('{0}','{1}','{2}','{3}')", news.NewsHeadlines, news.NewsDetails, news.ExpiryDate, news.PublishDate);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "News Added Succesfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static User LoginUser(string name, string password)
    {
        com.Parameters.Clear();
        string query = string.Format("SELECT COUNT(*) FROM dbo.Users  WHERE username = @username ");
        com.CommandText = query;
        com.Parameters.AddWithValue("@username", name);
        try
        {
            conn.Open();
            int amtOfUsers = (int)com.ExecuteScalar();

            if (amtOfUsers == 1)
            {
                query = string.Format("SELECT password FROM dbo.Users  WHERE username = @name1");
                com.CommandText = query;
                com.Parameters.AddWithValue("@name1", name);
                
                string dbpassword = com.ExecuteScalar().ToString();

                if (dbpassword == password)
                {
                    query = string.Format("SELECT firstname,lastname,email,contactno,isactive,role FROM dbo.Users  WHERE username = @name2");
                    com.CommandText = query;
                    com.Parameters.AddWithValue("@name2", name);

                    SqlDataReader reader = com.ExecuteReader();
                    User user = null;

                    while (reader.Read())
                    {
                        string firstname = reader.GetString(0);
                        string lastname = reader.GetString(1);
                        string email = reader.GetString(2);
                        string contactno = reader.GetString(3);
                        int active = reader.GetInt32(4);
                        string role = reader.GetString(5);
                        user = new User(name, password,firstname,lastname, email, contactno,active,role);
                    }
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static string RegisterUser(User user)
    {
        string query = string.Format("SELECT COUNT(*) FROM dbo.Users where username = '{0}'", user.UserName);
        com.CommandText = query;

        try
        {
            conn.Open();
            int amtOfUsers = (int) com.ExecuteScalar();

            if (amtOfUsers < 1)
            {
                query=string.Format("INSERT INTO Users VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",user.UserName,user.Password,user.FirstName,user.LastName,user.Email,user.ContactNo,user.Active,user.Role);
                com.CommandText=query;
                com.ExecuteNonQuery();
                return "Thank You for registering with us";
            }
            else
            {
                return "Username already exists";
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddRequest(ConsultationRequestClass consultationrequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstConsultation VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", consultationrequest.Name, consultationrequest.UserName, consultationrequest.Email, consultationrequest.ConsultationTitle, consultationrequest.ConsultationType, consultationrequest.Deadline, consultationrequest.Description, consultationrequest.UploadFile, consultationrequest.RequestStatus, consultationrequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddAccoutingRequest(ConsultationRequestClass consultationrequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstAccouting VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", consultationrequest.Name, consultationrequest.UserName, consultationrequest.Email, consultationrequest.ConsultationTitle, consultationrequest.ConsultationType, consultationrequest.Deadline, consultationrequest.Description, consultationrequest.UploadFile, consultationrequest.RequestStatus, consultationrequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddBusinessRequest(ConsultationRequestClass consultationrequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstBusiness VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", consultationrequest.Name, consultationrequest.UserName, consultationrequest.Email, consultationrequest.ConsultationTitle, consultationrequest.ConsultationType, consultationrequest.Deadline, consultationrequest.Description, consultationrequest.UploadFile, consultationrequest.RequestStatus, consultationrequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddPayrollRequest(ConsultationRequestClass consultationrequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstPayroll VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", consultationrequest.Name, consultationrequest.UserName, consultationrequest.Email, consultationrequest.ConsultationTitle, consultationrequest.ConsultationType, consultationrequest.Deadline, consultationrequest.Description, consultationrequest.UploadFile, consultationrequest.RequestStatus, consultationrequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddOthersRequest(ConsultationRequestClass consultationrequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstOthers VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", consultationrequest.Name, consultationrequest.UserName, consultationrequest.Email, consultationrequest.ConsultationTitle, consultationrequest.ConsultationType, consultationrequest.Deadline, consultationrequest.Description, consultationrequest.UploadFile, consultationrequest.RequestStatus, consultationrequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }

    }

    public static string AddVisaRequest(VisaRequestClass visarequest)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO RqstVisaServices VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", visarequest.Name, visarequest.UserName, visarequest.Email, visarequest.VisaTitle, visarequest.VisaType, visarequest.NameofApplicant,visarequest.DateofBirth,visarequest.PassportNo,visarequest.MotherName,visarequest.PassportCopy, visarequest.Deadline, visarequest.Description, visarequest.UploadFile, visarequest.RequestStatus, visarequest.ResultFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddEnquiry(ContactUsClass contact)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO ContactUs VALUES ('{0}','{1}','{2}','{3}')", contact.Name, contact.Mail, contact.Telephone, contact.Message);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Enquiry Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static Product GetProduct(int id)
    {
        
        try
        {
            conn.Open();
            

            string query = string.Format("SELECT productNumber,productName,description,price,releasedate,productPicture,productFile FROM StoreMaster WHERE Id='{0}'", id);
            com.CommandText = query;
            Product product = null;
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                int productno = reader.GetInt32(0);
                string productname = reader.GetString(1);
                string description = reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                DateTime dt = reader.GetDateTime(4);
                string productpicture = reader.GetString(5);
                string productfile = reader.GetString(6);

                product = new Product(id,productno, productname, description, price,dt, productpicture, productfile);
            }

            return product;
        }
        finally
        {
            conn.Close();
        }
    }

    public static int GetTotalProducts()
    {
        try
        {
            conn.Open();
            string query = string.Format("SELECT COUNT(*) FROM StoreMaster");
            com.CommandText = query;
            int total = (int)com.ExecuteScalar();
            return total;
        }
        finally
        {
            conn.Close();
        }
    }

    public static string AddNewProduct(Product p)
    {
        try
        {
            conn.Open();
            string query = string.Format("INSERT INTO StoreMaster VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",p.ProductNumber,p.ProductName,p.Description,p.Price,p.ReleaseDate,p.ProductPicture,p.ProductFile);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Product Added Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static Product GetProductByName(string name)
    {
        try
        {
            conn.Open();
            

            string query = string.Format("SELECT Id,productNumber,description,price,releasedate,productPicture,productFile FROM StoreMaster WHERE productName='{0}'", name);
            com.CommandText = query;
            Product product = null;
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                int productid = reader.GetInt32(0);
                int productno = reader.GetInt32(1);
                string description = reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                DateTime dt = reader.GetDateTime(4);
                string productpicture = reader.GetString(5);
                string productfile = reader.GetString(6);

                product = new Product(productid,productno,name, description, price,dt, productpicture, productfile);
            }

            return product;
        }
        finally
        {
            conn.Close();
        }
    }

    public static User GetUserByName(string name)
    {
        try
        {
            conn.Open();
            string query = String.Format("SELECT id,password,firstname,lastname,email,contactno,isactive,role FROM Users WHERE username='{0}'", name);
            com.CommandText = query;
            User user = null;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string password = reader.GetString(1);
                string firstname = reader.GetString(2);
                string lastname = reader.GetString(3);
                string email = reader.GetString(4);
                string contactno = reader.GetString(5);
                int active = reader.GetInt32(6);
                string role = reader.GetString(7);
                user = new User(id,name, password, firstname, lastname, email, contactno, active, role);
            }
            return user;
        }
        finally
        {
            conn.Close();
        }
    }

    public static string UpdateUser(User user)
    {   
        try
        {
            conn.Open();
         //   com.Parameters.Clear();
            string query = String.Format("UPDATE Users SET username='{0}',password='{1}',firstname='{2}',lastname='{3}',email='{4}',contactno='{5}',isactive='{6}',role='{7}' WHERE id='{8}'",user.UserName,user.Password,user.FirstName,user.LastName,user.Email,user.ContactNo,user.Active,user.Role,user.Id);
            com.CommandText = query;
    /*        com.Parameters.AddWithValue("@username", user.UserName);
            com.Parameters.AddWithValue("@password", user.Password);
            com.Parameters.AddWithValue("@firstname", user.FirstName);
            com.Parameters.AddWithValue("@lastname", user.LastName);
            com.Parameters.AddWithValue("@email", user.Email);
            com.Parameters.AddWithValue("@contactno", user.ContactNo);
            com.Parameters.AddWithValue("@isactive", user.Active);
            com.Parameters.AddWithValue("@role", user.Role);
            com.Parameters.AddWithValue("@id", user.Id); */
            com.ExecuteNonQuery();
            return "User Updated Successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static ConsultationRequestClass GetRequestById(string i,string tablename)
    {
        int id = Convert.ToInt32(i);
        try
        {
            conn.Open();
            string query = String.Format("SELECT * FROM {0} WHERE requestId={1}",tablename,i);
            com.CommandText = query;
            ConsultationRequestClass c = null;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int requestid = reader.GetInt32(0);
                string name = reader.GetString(1);
                string username = reader.GetString(2);
                string email = reader.GetString(3);
                string title = reader.GetString(4);
                string type = reader.GetString(5);
                DateTime deadline = reader.GetDateTime(6);
                string description = reader.GetString(7);
                string uploadfile = reader.GetString(8);
                string status = reader.GetString(9);
                string resultfile = reader.GetString(10);

                c = new ConsultationRequestClass(requestid,name,username,email,title,type,deadline,description,uploadfile,status,resultfile);
            }
            return c;
        }
        finally
        {
            conn.Close();
        }
    }

    public static string UpdateRequest(ConsultationRequestClass c,string tablename)
    {
        try
        {
            conn.Open();
            string query = String.Format("UPDATE {0} SET requestStatus='{1}',resultFile='{2}' WHERE requestId='{3}'",tablename,c.RequestStatus,c.ResultFile,c.RequestId);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request updated successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static string UpdateVisaRequest(VisaRequestClass c, string tablename)
    {
        try
        {
            conn.Open();
            string query = String.Format("UPDATE {0} SET requestStatus='{1}',resultFile='{2}' WHERE requestId='{3}'", tablename, c.RequestStatus, c.ResultFile, c.RequestId);
            com.CommandText = query;
            com.ExecuteNonQuery();
            return "Request updated successfully";
        }
        finally
        {
            conn.Close();
        }
    }

    public static int RetrieveLastId(string tablename)
    {
        try
        {
            conn.Open();
            string query = String.Format("SELECT MAX(requestId) FROM {0}",tablename);
            com.CommandText = query;
            int id = (int)com.ExecuteScalar();
            return id;
        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateAccountingFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstAccouting SET uploadFile={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateConsultationFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstConsultation SET uploadFile={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdatePayrollFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstPayroll SET uploadFile={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateOthersFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstOthers SET uploadFile={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateBusinessFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstBusiness SET uploadFile={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static void UpdateVisaFilenamebyId(int id)
    {
        string extension = Convert.ToString(id);
        try
        {
            conn.Open();
            string query = String.Format("UPDATE RqstVisaServices SET uploadFile={0},passportCopy={0} WHERE requestId={1}", extension, id);
            com.CommandText = query;
            com.ExecuteNonQuery();

        }
        finally
        {
            conn.Close();
        }
    }

    public static VisaRequestClass GetVisaRequestById(string i,string tablename)
    {
        int id = Convert.ToInt32(i);
        try
        {
            conn.Open();
            string query = String.Format("SELECT * FROM {0} WHERE requestId={1}",tablename,i);
            com.CommandText = query;
            VisaRequestClass c = null;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int requestid = reader.GetInt32(0);
                string name = reader.GetString(1);
                string username = reader.GetString(2);
                string email = reader.GetString(3);
                string title = reader.GetString(4);
                string type = reader.GetString(5);
                string nameofapplicant = reader.GetString(6);
                DateTime dob = reader.GetDateTime(7);
                string passportno = reader.GetString(8);
                string mothername = reader.GetString(9);
                string passportcopy = reader.GetString(10);
                DateTime deadline = reader.GetDateTime(11);
                string description = reader.GetString(12);
                string uploadfile = reader.GetString(13);
                string status = reader.GetString(14);
                string resultfile = reader.GetString(15);

                c = new VisaRequestClass(requestid,name,username,email,title,type,nameofapplicant,dob,passportno,mothername,passportcopy,deadline,description,uploadfile,status,resultfile);
            }
            return c;
        }
        finally
        {
            conn.Close();
        }
    }

    public static string ChangePasswordbyUser(string username, string password,string newpassword)
    {
        string query = String.Format("SELECT password FROM Users WHERE username='{0}'", username);
        try
        {
            conn.Open();
            com.CommandText = query;
            string oldpassword=com.ExecuteScalar().ToString();

            if (oldpassword == password)
            {
                string query1 = String.Format("UPDATE Users SET password='{0}' WHERE username='{1}'", newpassword, username);
                com.CommandText = query1;
                com.ExecuteNonQuery();
                return "Password updated successfully";
            }
            else
            {
                return "Your current Password is wrong!";
            }
        }
        finally
        {
            conn.Close();
        }
    }

    public static void ChangeActive(int id)
    {
        string query = String.Format("SELECT isactive FROM Users WHERE id='{0}'",id);
        try
        {
            conn.Open();
            com.CommandText = query;
            int x = (int)com.ExecuteScalar();
            if (x == 0)
            {
                x = 1;
            }
            else
            {
                x = 0;
            }
            query = String.Format("UPDATE Users SET isactive='{0}' WHERE id='{1}'", x, id);
            com.CommandText = query;
            com.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static void AddOrder(Order order)
    {
        string query = String.Format("INSERT into Orders VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}') ",order.Firstname,order.Lastname,order.Username,order.Email,order.Contactno,order.Productnumber,order.Productname,order.Price,order.Orderdate,order.Paymentstatus,order.IPAddress,order.Transactionid);
        try
        {
            conn.Open();
            com.CommandText = query;
            com.ExecuteNonQuery();
        }
        finally
        {
            conn.Close();
        }
    }

    public static Order GetOrder(int id)
    {
        string query = String.Format("SELECT * FROM Orders WHERE POId='{0}'", id);
        try
        {
            conn.Open();
            com.CommandText = query;
            Order order = null;
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                int poid = reader.GetInt32(0);
                string firstname = reader.GetString(1);
                string lastname = reader.GetString(2);
                string username = reader.GetString(3);
                string email = reader.GetString(4);
                string contactno = reader.GetString(5);
                int productno = reader.GetInt32(6);
                string productname = reader.GetString(7);
                decimal price = reader.GetDecimal(8);
                DateTime orderdate = reader.GetDateTime(9);
                string status = reader.GetString(10);
                string ip = reader.GetString(11);
                string tid = reader.GetString(12);
                order = new Order(poid, firstname, lastname,username, email, contactno, productno, productname, price, orderdate, status, ip, tid);
            }
            return order;
        }
        finally
        {
            conn.Close();
        }
    }

}