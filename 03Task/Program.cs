using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter First name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Family name : ");
            string familyName = Console.ReadLine();
            Console.Write("Enter manager telephone : ");
            string managerPhone = Console.ReadLine();
            Console.Write("Enter name of the company : ");
            string companyName = Console.ReadLine();
            Console.Write("Enter adress of the company : ");
            string companyAdress = Console.ReadLine();
            Console.Write("Enter Telephone number of the company : ");
            string companyTelephone = Console.ReadLine();
            Console.Write("Enter FAX number : ");
            string companyFax = Console.ReadLine();
            Console.Write("Enter WebSite name : ");
            string companyWeb = Console.ReadLine();

            Console.WriteLine($"Hello Mr.{familyName} ! We are so happy to welcome you in our company \"{companyName}\" ! {firstName} are you" +
                $" sure that your telephone number is correct {managerPhone} , because its important ! We are waiting you Monday on this addres :   {companyAdress}" +
                $",this is our addres . If you have any questions you can connect with us on this telephone : {companyTelephone}" +
                $" and the FAX is : {companyFax} . Until that time you can see more in our WebSite -  {companyWeb} ! Thank you ! See you soon !  ");
             
        }
    }
}
