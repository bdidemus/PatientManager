using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace PatientManager
{
    class LoginMgr
    {
        private LoginMgr()
        {

        }

        public static LoginMgr createInstance()
        {
            m_pInstance = new LoginMgr();
            return m_pInstance;
        }

        // Singleton
        public static LoginMgr Instance
        {
            get
            {
                if (m_pInstance == null)
                {
                    m_pInstance = new LoginMgr();
                }
                return m_pInstance;
            }
        }

        public void submitLogin(String username, String password)
        {
            Database.PatientManagerEntities context = new Database.PatientManagerEntities();

            password = GetMd5Hash(password);

            IQueryable<Database.loginuser> lu = from users in context.loginusers
                        where 
                            users.usrName == username &&
                            users.usrPassword == password
                        select users;

            if (lu.Count() == 1)
            {
                m_bIsLoggedIn = true;
                m_strUsername = lu.First().usrName;
            }
            else
            {
                m_bIsLoggedIn = false;
                m_strUsername = null;
            }
        }

        public bool changePassword(String username, String oldPassword, String password)
        {
            Database.PatientManagerEntities context = new Database.PatientManagerEntities();

            oldPassword = GetMd5Hash(oldPassword);

            IQueryable<Database.loginuser> lu = from users in context.loginusers
                                                where
                                                    users.usrName == username &&
                                                    users.usrPassword == oldPassword
                                                select users;
            if (lu.Count() == 1)
            {
                Database.loginuser user = lu.First();
                user.usrPassword = GetMd5Hash(password);
                context.SaveChanges();
            }
            else
            {
                return false;
            }

            return true;
        }

        public void logout()
        {
            m_bIsLoggedIn = false;
        }

        public bool isLoggedIn
        {
            get
            {
                return m_bIsLoggedIn;
            }
        }

        public String Username
        {
            get
            {
                return m_strUsername;
            }
        }

        private static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyMd5Hash(string input, string hash)
        {
            MD5 md5Hash = MD5.Create();

            // Hash the input.
            string hashOfInput = GetMd5Hash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static LoginMgr m_pInstance;
        private String m_strUsername;
        private bool m_bIsLoggedIn = true;
    }
}
