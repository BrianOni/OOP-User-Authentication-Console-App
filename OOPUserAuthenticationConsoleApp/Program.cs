using System;

namespace OOPUserAuthenticationConsoleApp
{
    class Program
    {
        static UserAccount[] arrUserAccountList = new UserAccount[10];

        static void Main(string[] args)
        {
            //init users database
            Initialize();

            //ask about username
            Console.WriteLine("Enter the username: ");
            string username = Console.ReadLine();
            //ask about password
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();

            //check username and password
            while (username != "-1" || password != "-1")
            {
                //try to authentificate
                if (Authenticate(username, password))
                    Console.WriteLine("Access has been granted");
                else
                    Console.WriteLine("Logon Failure. Please try again");

                //ask about username
                Console.WriteLine("\nEnter the username: ");
                username = Console.ReadLine();
                //ask about password
                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();
            }

            //end the app
            Console.Write("Program has been terminated");
            Console.ReadLine();
        }

        /// <summary>
        /// Method initialize users DB
        /// </summary>
        public static void Initialize()
        {
            arrUserAccountList[0] = new UserAccount("Joe", "111");
            arrUserAccountList[1] = new UserAccount("Angel", "222");
            arrUserAccountList[2] = new UserAccount("Sam", "333");
            arrUserAccountList[3] = new UserAccount("Mary", "444");
            arrUserAccountList[4] = new UserAccount("Nancy", "555");
        }

        /// <summary>
        /// Method tries to authenticate user
        /// </summary>
        /// <param name="username">user name</param>
        /// <param name="password">user password</param>
        /// <returns></returns>
        private static bool Authenticate(string username, string password)
        {
            //iterate by all usernames and try to find user name and password
            for (int i = 0; i < arrUserAccountList.Length; i++)
            {
                if (arrUserAccountList[i] != null)
                {
                    if (arrUserAccountList[i].Authenticate(username, password))
                        return true;
                }
            }


            return false;
        }
    }
}
