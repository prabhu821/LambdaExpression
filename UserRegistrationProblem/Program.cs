namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem");

            UserRegistration registration = new UserRegistration();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Email \n4.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}