namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            // Q01  =>  b) 

            // Q02  =>  a) 

            // Q03  =>  c) 

            // Q04  =>  b)

            // Q05  =>  d) 

            // Q06  =>  a) 

            // Q07  =>  b) 

            // Q08  =>  a) 

            // Q09  =>  b) 

            // Q10  =>  c) 
            #endregion

            #region Q1

            //IShape circle = new Circle(5);
            //circle.DisplayShapeInfo();
            //Console.WriteLine();
            //IShape rectangle = new Rectangle(4, 5);
            //rectangle.DisplayShapeInfo();
            //Console.WriteLine();
            #endregion

            #region Q2
            //BasicAuthenticationService authenticationService = new BasicAuthenticationService();
            //bool isAuthenticated = authenticationService.AuthenticateUser("Saad", "Panda55"); 
            //if (isAuthenticated)
            //    Console.WriteLine("Authentication Dn!");
            //else
            //    Console.WriteLine("Authentication Failed!");

            //bool isAuthorized = authenticationService.AuthorizeUser("Saad", "Admin");
            //if (isAuthorized)
            //    Console.WriteLine("Authentication Dn!");
            //else
            //    Console.WriteLine("User is not Authorized!");
            #endregion


        }
    }
}
#region Q1
//public interface IShape
//{
//    double Area { get; }
//    void DisplayShapeInfo();
//}
//public interface ICircle : IShape
//{
//    double R { get; set; }
//}

//public interface IRectangle : IShape
//{
//    double L { get; set; }
//    double W { get; set; }

//}
//public class Circle : ICircle
//{
//    public double Rad { get; set; }

//    public Circle(double r)
//    {
//        R = r;
//    }

//    public double Area => (22/7) * Rad * Rad;

//    public double R { get; set; }

//    public void DisplayShapeInfo()
//    {
//        Console.WriteLine(Rad);
//        Console.WriteLine(Area);
//    }
//}
//public class Rectangle : IRectangle
//{
//    public double L { get; set; }
//    public double W { get; set; }

//    public Rectangle(double length, double width)
//    {
//        L = length;
//        W = width;
//    }

//    public double Area => L * W;

//    public void DisplayShapeInfo()
//    {

//        Console.WriteLine(L);
//        Console.WriteLine(W);
//        Console.WriteLine(Area);
//    }
//}

#endregion

#region Q2
//public interface IAuthenticationService
//{
//    bool AuthenticateUser(string username, string password);
//    bool AuthorizeUser(string username, string role);
//}
//public class BasicAuthenticationService : IAuthenticationService
//{
//    private string[] UserNames { get; set; } = { "AbdelAziz", "Saad" };
//    private string[] Passwords { get; set; } = { "Panda55", "Panda55" };
//    private string[] Roles { get; set; } = { "Admin", "User" };

//    public bool AuthenticateUser(string username, string password)
//    {
//        int index = Array.IndexOf(UserNames, username);
//        if (index >= 0 && Passwords[index] == password)
//        {
//            return true;
//        }
//        return false;
//    }

//    public bool AuthorizeUser(string username, string role)
//    {
//        int index = Array.IndexOf(UserNames, username);
//        if (index >= 0 && Roles[index] == role)
//        {
//            return true;
//        }
//        return false;
//    }
//}
#endregion

#region Q3
//interface INotificationService
//{
//    void SendNotification(string recipient, string message);
//}

#endregion