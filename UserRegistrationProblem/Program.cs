namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            UserRegistration registration = new UserRegistration();
            Email email1 = new Email();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number " +
                    "\n5.Password \n6.Check Sample Email \n7.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter First Name");
                        string fName = Console.ReadLine();
                        Console.WriteLine(registration.ValidateFirstName(fName));
                        break;
                    case 2:
                        Console.WriteLine("\nEnter Last Name");
                        string lName = Console.ReadLine();
                        Console.WriteLine(registration.ValidateLastName(lName));
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Email");
                        string email = Console.ReadLine();
                        Console.WriteLine(registration.ValidateEmail(email));
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Mobile Number");
                        string mobileNumber= Console.ReadLine();
                        Console.WriteLine(registration.ValidateMobileNUmber(mobileNumber));
                        break;
                    case 5:
                        Console.WriteLine("\nEnter Password");
                        string password = Console.ReadLine();
                        Console.WriteLine(registration.ValidatePassword(password));
                        break;
                    case 6:
                        Console.WriteLine("\nEnter Sample Email to Check");
                        string sampleEmail = Console.ReadLine();
                        Console.WriteLine(email1.ValidateSampleEmail(sampleEmail));
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}