using System;

namespace OOPUserAuthenticationConsoleApp
{
    class UserAccount
    {
        Guid m_UserAccountID;
        string m_Username;
        string m_Password;
        string m_Email;

        public string UserAccountID { get { return m_UserAccountID.ToString(); } }
        public string Username { get { return m_Username; } }
        public string Password { get { return m_Password; } }
        public string Email { get { return m_Email; } }

        private UserAccount()
        {
            m_UserAccountID = Guid.NewGuid();
        }

        private UserAccount(string username, string password, string email): this()
        {
            m_Username = username;
            m_Password = password;
            m_Email = email;
        }

        public UserAccount(string username, string password) : this(username, password, string.Empty)
        {
            
        }

        public bool Authenticate(string username, string password)
        {
            return Username == username && Password == password;
        }

        public static UserAccount GetInstance()
        {
            return new UserAccount();
        }

        public static UserAccount GetInstance(string username, string password, string email)
        {
            return new UserAccount(username, password, email);
        }

        ~UserAccount()
        {

        }
    }
}
